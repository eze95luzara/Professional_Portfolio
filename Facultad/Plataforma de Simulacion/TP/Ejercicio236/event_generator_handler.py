from tp5.servers.server import Server

INIT = 0
FOOTBAL_TEAM_ARRIVAL = 1
FOOTBAL_TEAM_STARTS = 2
FOOTBAL_TEAM_LEAVES = 3
HANDBALL_TEAM_ARRIVAL = 4
HANDBALL_TEAM_STARTS = 5
HANDBALL_TEAM_LEAVES = 6
BASKETBAL_TEAM_ARRIVAL = 7
BASKETBAL_TEAM_STARTS = 8
BASKETBAL_TEAM_LEAVES = 9
CLEAN_FIELD_STARTS = 10
CLEAN_FIELD_ENDS = 11

EVENT_TYPES = {
    INIT: "Inicializacion",
    FOOTBAL_TEAM_ARRIVAL: 'Equipo de Futbol: Llega',
    FOOTBAL_TEAM_STARTS: 'Equipo de Futbol: Inicia',
    FOOTBAL_TEAM_LEAVES: 'Equipo de Futbol: Termina',
    HANDBALL_TEAM_ARRIVAL: 'Equipo de Handball: Llega',
    HANDBALL_TEAM_STARTS: 'Equipo de Handball: Inicia',
    HANDBALL_TEAM_LEAVES: 'Equipo de Handball: Termina',
    BASKETBAL_TEAM_ARRIVAL: 'Equipo de Basketball: Llega',
    BASKETBAL_TEAM_STARTS: 'Equipo de Basketball: Inicia',
    BASKETBAL_TEAM_LEAVES: 'Equipo de Basketball: Termina',
    CLEAN_FIELD_STARTS: 'Limpieza: Inicia',
    CLEAN_FIELD_ENDS: 'Limpieza: Termina',
}

class EventGeneratorHandler():
    ARRIVAL = 1
    SERVER_RUN = 2
    SERVER_RUN_FINISH = 3
    
    def __init__(self,
                 generator_handlers,
                 history_selector,
                 sample_size,
                 queues,
                 queues_mapping,
                 cleaning_handler,
                 *args, **kwargs):
        self.history = []
        self.state_vector = []
        self.generator_handlers = generator_handlers
        self.cleaning_handler = cleaning_handler
        self.server = Server(
            queues,
            queues_mapping
        )
        # Expects a function to add elemnts to the history
        self.history_selector = history_selector
        self.sample_size = int(sample_size)
        self.history_kwargs = kwargs.get('history_kwargs', {})    

    def get_next_arrival(self):
        next_generator = None
        for generator in self.generator_handlers:
            if next_generator is None or next_generator.next_arrival() > generator.next_arrival():
                next_generator = generator
        return next_generator
            
    def get_next_event_type(self):
        if self.server.is_free and not self.server.are_queues_empty:
            return self.SERVER_RUN
        next_arrival_generator = self.get_next_arrival()
        next_process_end = self.server.get_next_serve_finish_time()
        if next_process_end is not None and next_process_end < next_arrival_generator.next_arrival():
            return self.SERVER_RUN_FINISH
        return self.ARRIVAL

    def run(self):
        prev_element = None
        self.current_time = 0
        current_time = 0
        occurred_event_key = 0
        prev_arrival_type = None
        for i in range(self.sample_size):
            if len(self.state_vector) > 0:
                prev_element = self.state_vector[0]
            iteration_number = i + 1
            if current_time == 0:
                for generator in self.generator_handlers:
                    generator.generate_item(0)

            if iteration_number > 1:
                next_event_type = self.get_next_event_type()
                if next_event_type == self.SERVER_RUN:
                    # Starts
                    item = self.server.serve()
                    current_time = item.process_start_time
                    clean_used = False
                    occurred_event_key = item.STARTS
                elif next_event_type == self.SERVER_RUN_FINISH:
                    # Leaves
                    item = self.server.dispatch()
                    current_time = item.finish_time
                    occurred_event_key = item.LEAVES
                    if type(item) == self.cleaning_handler.item_class:
                        clean_used = True
                    for generator in self.generator_handlers:
                        if type(item) == generator.item_class:
                            time_in_queue = item.time_in_queue
                            generator.update_metrics(time_in_queue)
                elif next_event_type == self.ARRIVAL:
                    # Arrives
                    arrival_generator = self.get_next_arrival()
                    item = arrival_generator.next_item
                    occurred_event_key = item.ARRIVES
                    current_time = arrival_generator.next_arrival()
                    self.server.receive(item)
                    arrival_generator.generate_item(current_time)
                    if not self.server.is_cleaning_queued or type(item) != prev_arrival_type:
                        self.cleaning_handler.generate_item()
                        self.server.receive(self.cleaning_handler.next_item)
                    prev_arrival_type = type(item)
                    clean_used = False
                self.cleaning_handler.update_metrics(clean_used, current_time)

            parsed_iteration = {
                'iteration': iteration_number, 
                'event_type': EVENT_TYPES[occurred_event_key],
                'current_time': current_time,
                'server_status': self.server.is_free,
                'prev_arrival_type': prev_arrival_type,
                **self.cleaning_handler.item_data
            }
            occurred_event_key = None
            for generator in self.generator_handlers:
                parsed_iteration = {**parsed_iteration, **generator.item_data}
            if len(self.state_vector) > 1:
                self.state_vector.pop()
            self.state_vector.insert(0, parsed_iteration)
            if not getattr(self, 'history_selector'):
                continue
            history_item = self.history_selector(parsed_iteration, **self.history_kwargs)
            if history_item is not None:
                self.history.append(history_item)

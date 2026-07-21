from abc import ABC, abstractmethod


class EventGeneratorHandler(ABC):
    def __init__(self,
                 generator_handlers,
                 history_selector,
                 queue_selector,
                 queue_picker,
                 sample_size,
                 iteration_item_class,
                 *args, **kwargs):
        self.history = []
        self.state_vector = []
        self.generator_handlers = []
        self.queue = []
        # Expects a function to add elemnts to the history
        self.history_selector = history_selector
        self.queue_selector = queue_selector
        self.queue_picker = queue_picker
        self.sample_size = int(sample_size)
        self.iteration_item_class = iteration_item_class
        self.iteration_item_kwargs = kwargs.get('iteration_item_kwargs', {})
        self.history_kwargs = kwargs.get('history_kwargs', {})

    def run(self):
        prev_element = None
        self.current_time = 0
        for i in range(self.sample_size):
            if len(self.state_vector) > 0:
                prev_element = self.state_vector[0]
            iteration_number = i + 1
            next_event_generator_handler = None
            if self.current_time == 0:
                for generator in self.generator_handlers():
                    generator.generate_new_item()
            
            for generator in self.generator_handlers():
                if next_event_generator_handler is None or generator < next_event_generator_handler:
                    next_event_generator_handler = generator
            
            self.current_time = next_event_generator_handler.get_current_time()

            self.iteration_item_kwargs = {
                **self.iteration_item_kwargs,
                'current_time': self.current_time,
            }
            parsed_iteration = self.build_iterartion_data(iteration_number, prev_element, next_event_generator_handler, **self.iteration_item_kwargs)
            if len(self.state_vector) > 1:
                self.state_vector.pop()
            self.state_vector.insert(0, parsed_iteration)
            if not getattr(self, 'history_selector'):
                continue
            history_item = self.history_selector(parsed_iteration, **self.history_kwargs)
            if history_item is not None:
                self.history.append(history_item)

    def build_iterartion_data(self, *args, **kwargs):
        iteration_item = self.iteration_item_class(*args, **kwargs)
        iteration_data = {
            **iteration_item.__dict__,
        }
        for generator in self.generator_handlers():
            iteration_data = {
                **iteration_data,
                **generator.event_data
            }
        return iteration_data

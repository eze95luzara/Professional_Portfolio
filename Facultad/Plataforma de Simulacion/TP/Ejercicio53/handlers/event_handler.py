class EventHandler():
    def __init__(self,
                 arrival_generator,
                 process_generator,
                 generator_name,
                 item_class):
        self.arrival_generator = arrival_generator
        self.process_generator = process_generator
        self.item_class = item_class
        self.name = generator_name
        self.next_item = None
        self.total_time_in_queue = 0
        self.total_items = 0
        self.average_time_in_queue = 0
    
    def get_average_time_in_queue(self):
        return self.total_time_in_queue / self.total_items
    
    def update_metrics(self, time_in_queue):
        self.total_time_in_queue += time_in_queue
        self.total_items += 1
        self.average_time_in_queue = self.get_average_time_in_queue()

    def generate_item(self, current_time):
        item_args = {
            **self.generate_arrival(current_time),
            **self.generate_process()
        }
        self.next_item = self.item_class(**item_args)
    
    def generate_arrival(self, current_time):
        time_btw_arrivals = self.arrival_generator.generate_number()
        arrival = time_btw_arrivals + current_time
        return dict(
            arrival_random=self.arrival_generator.random_number,
            time_between_arrivals=time_btw_arrivals,
            arrival=arrival
        )

    def generate_process(self):
        process_time = self.process_generator.generate_number()
        return dict(
            process_random=self.process_generator.random_number,
            process_time=process_time,
            finish_time=None
        )
    
    def next_arrival(self):
        return self.next_item.arrival
    
    @property
    def item_data(self):
        item_dict = {}
        for key, value in self.next_item.__dict__.items():
            item_dict[f'{self.name}{key}'] = value
        return {
            **item_dict,
            f'{self.name}_total_time_in_queue': self.total_time_in_queue,
            f'{self.name}_total_items': self.total_items,
            f'{self.name}_average_time_in_queue': self.average_time_in_queue
        }

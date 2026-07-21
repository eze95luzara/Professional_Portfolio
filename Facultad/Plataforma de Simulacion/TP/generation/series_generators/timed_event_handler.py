from abc import ABC, abstractmethod


class TimedEventGeneratorHandler(ABC):
    @staticmethod
    def instantiate_distribution_generator(generator_class, *args, **kwargs):
        return generator_class(*args, **kwargs)

    def __init__(self,
                 distribution_generator,
                 event_item_class,
                 *args, **kwargs):
        self.number_generator = distribution_generator
        self.event_item_class = event_item_class
        self.events = []
        # self.iteration_item_class = iteration_item_class
        # self.iteration_item_kwargs = kwargs.get('iteration_item_kwargs', {})

    def generate_new_item(self):
        generated_number = self.number_generator.generate_number()
        self.events.append(self.iteration_item_class(generated_number))

    def get_next_arrival(self, current_time):
        self.prev_element = self.event_data
        generated_number = self.number_generator.generate_number()
        self.iteration_item_kwargs["random_number"] = self.number_generator.random_number
        self.iteration_item_kwargs["current_time"] = current_time
        self.event_data = self.build_iterartion_data(generated_number, self.prev_element, **self.iteration_item_kwargs)

    def build_iterartion_data(self, *args, **kwargs):
        iteration_item = self.iteration_item_class(*args, **kwargs)
        return iteration_item.__dict__
    
    def get_current_time(self):
        current_time = getattr(self.event_data, 'next_event_time')
        assert current_time is not None
        return current_time

    @staticmethod
    def get_next_event_times(current_event, other_event):
        next_event_time = getattr(current_event.event_data, 'next_event_time')
        other_next_event_time = getattr(other_event.event_data, 'next_event_time')
        assert next_event_time is not None
        assert other_next_event_time is not None
        return next_event_time, other_next_event_time

    def __gt__(self, other):
        next_event_time, other_next_event_time = self.get_next_event_times(self, other)
        return next_event_time > other_next_event_time
    
    def __lt__(self, other):
        next_event_time, other_next_event_time = self.get_next_event_times(self, other)
        return next_event_time < other_next_event_time
    
    def __eq__(self, other):
        next_event_time, other_next_event_time = self.get_next_event_times(self, other)
        return next_event_time == other_next_event_time

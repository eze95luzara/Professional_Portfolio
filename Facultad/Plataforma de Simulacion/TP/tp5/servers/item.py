class Item():
    def __init__(self, **kwargs):
        self.arrival_random = kwargs["arrival_random"]
        self.time_between_arrivals = kwargs["time_between_arrivals"]
        self.arrival = kwargs["arrival"]
        self.process_start_time = None
        self.process_random = kwargs["process_random"]
        self.process_time = kwargs["process_time"]
        self.finish_time = kwargs["finish_time"]
        self.time_in_queue = 0
    
    def process(self, current_time):
        self.process_start_time = current_time
        self.finish_time = current_time + self.process_time
        self.time_in_queue = current_time - self.arrival

class HandballItem(Item):
    ARRIVES = 4
    STARTS = 5
    LEAVES = 6
    pass
class FootballItem(Item):
    ARRIVES = 1
    STARTS = 2
    LEAVES = 3
    pass
class BasketballItem(Item):
    ARRIVES = 7
    STARTS = 8
    LEAVES = 9
    pass
class CleaningItem(Item):
    STARTS = 10
    LEAVES = 11

    def __init__(self, **kwargs):
        self.process_start_time = None
        self.process_time = kwargs["process_time"]
        self.finish_time = kwargs["finish_time"]

    def process(self, current_time):
        self.process_start_time = current_time
        self.finish_time = current_time + self.process_time
from tp5.servers.item import CleaningItem


class Server():
    def __init__(self, queues, queues_mapping):
        # Queues is an ordered dict with on top the highest priority queues
        # and at the bottom the lowest
        self.queues = queues
        self.queues_mapping = queues_mapping
        self.serving = []
        self.last_serve_type = None
        self.pick_two = False

    @property
    def are_queues_empty(self):
        for queue in self.queues.values():
            if len(queue) > 0:
                return False
        return True

    @property
    def is_free(self):
        return len(self.serving) == 0
    
    @property
    def is_cleaning_queued(self):
        return len(list(self.queues.values())[-1]) > 0

    def receive(self, item):
        self.queues[self.queues_mapping[type(item)]].insert(0, item)
        if self.is_free and type(item) != CleaningItem:
            self.next_serve_time = item.arrival

    def serve(self):
        response = None
        items = self.next_in_queue()
        for item in items:
            item.process(self.next_serve_time)
            self.serving.append(item)
            self.last_serve_type = type(item)
            response = item
        return response

    def dispatch(self):
        finished_item = self.next_item_serve_finish()
        self.next_serve_time = finished_item.finish_time
        return finished_item

    def get_next_in_main(self):
        main_queue = list(self.queues.values())[0]
        if len(main_queue) == 0:
            return None
        return main_queue[-1]
    
    def get_next_in_basket(self):
        basket_queue = list(self.queues.values())[1]
        if len(basket_queue) == 0:
            return None
        return basket_queue[-1]    

    def get_next_in_queue(self):
        # Returns None when all queues are empty
        for queue in self.queues.values():
            if len(queue) > 0:
                return queue[-1]
        return None

    def next_in_queue(self):
        main_queue = list(self.queues.values())[0]
        basket_queue = list(self.queues.values())[1]
        cleaning_queue = list(self.queues.values())[2]
        next_main_team = self.get_next_in_main()
        next_basket_team = self.get_next_in_basket()
        next_item_type = None
        pick_two = False
        if next_basket_team and next_main_team is None:
            next_item_type = type(basket_queue[-1])
        elif next_main_team and (next_basket_team is None or next_main_team.arrival < next_basket_team.arrival):
            next_item_type = type(main_queue[-1])
        elif next_basket_team and next_basket_team.arrival < next_main_team.arrival:
            if len(basket_queue) < 2:
                next_item_type = type(main_queue[-1])
            else:
                next_item_type = type(basket_queue[-1])
                pick_two = True
        
        if next_basket_team is None and next_main_team is None and len(cleaning_queue) > 0:
            return [cleaning_queue.pop()]
        if next_item_type != CleaningItem and next_item_type != self.last_serve_type and len(cleaning_queue) > 0:
            return [cleaning_queue.pop()]
        
        if pick_two:
            basket_queue = list(self.queues.values())[1]
            pick_two = False
            return [basket_queue[-1], basket_queue[-2]]
        if (next_item_type):
            return [self.queues[self.queues_mapping[next_item_type]].pop()]
        raise Exception("No more items to process")

    def get_next_item_serve_finish(self):
        next_item = None
        for served_item in self.serving:
            if next_item is None or next_item.finish_time > served_item.finish_time:
                next_item = served_item
        return next_item

    def next_item_serve_finish(self):
        next_item = self.get_next_item_serve_finish()
        self.serving.remove(next_item)
        return next_item

    def get_next_serve_finish_time(self):
        next_item = self.get_next_item_serve_finish()
        return next_item.finish_time if next_item else None

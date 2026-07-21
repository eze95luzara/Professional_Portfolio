class CleanEventHandler():
    name = 'Limpieza'
    def __init__(self,
                 item_class,
                 cleaning_time):
        self.item_class = item_class
        self.next_item = None
        self.cleaning_time = float(cleaning_time)
        self.usage_time = 0
        self.use_percentage = 0
    
    def get_use_percentage(self, total_time):
        return self.usage_time / total_time
    
    def update_metrics(self, was_used, current_time):
        if was_used:
            self.usage_time += self.cleaning_time
        self.use_percentage = self.get_use_percentage(current_time)

    def generate_item(self):
        item_args = {
            **self.generate_process()
        }
        self.next_item = self.item_class(**item_args)

    def generate_process(self):
        return dict(
            process_time=self.cleaning_time,
            finish_time=None
        )
    
    @property
    def item_data(self):
        return {
            'cleaning_usage_time': self.usage_time,
            'cleaning_use_percentage': self.use_percentage,
        }

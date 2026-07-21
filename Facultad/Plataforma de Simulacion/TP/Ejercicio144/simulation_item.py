from generation.series_generators.base_iteration_item import BaseIterationItem


class IterationItem(BaseIterationItem):
    def __init__(self, iteration, generated_number, prev_element, **kwargs):
        self.iteration = iteration
        self.random_number = kwargs['random_number']
        generated_number = generated_number
        self.absent_workers = generated_number
        self.available_workers = self.get_available_workers(self.absent_workers, int(kwargs["total_workers"]))
        is_factory_operating = self.is_factory_operating(self.available_workers) 
        self.is_factory_operational = is_factory_operating
        self.worker_costs = float(kwargs['workers_cost'])
        self.production_cost = float(kwargs['production_cost']) if is_factory_operating else 0
        self.production_benefit = float(kwargs['production_benefit']) if is_factory_operating else 0
        self.day_difference = self.production_benefit - self.production_cost - self.worker_costs
        self.accumulated_benefit = prev_element['accumulated_benefit'] + self.day_difference if prev_element is not None else self.day_difference

    @staticmethod
    def get_available_workers(absent_workers, total_workers):
        return total_workers - absent_workers

    @staticmethod
    def is_factory_operating(available_workers):
        return available_workers >= 20
        
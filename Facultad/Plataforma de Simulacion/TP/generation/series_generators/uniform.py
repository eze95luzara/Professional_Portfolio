from decimal import Decimal
from generation.series_generators.base import BaseSeriesGenerator

class UniformNumberGenerator(BaseSeriesGenerator):
    def __init__(self,
                 decimal_places,
                 random_number_generator,
                 lower_limit=0,
                 upper_limit=0,
                 mean=0,
                 range=0):
        self.lower_limit = float(lower_limit)
        self.upper_limit = float(upper_limit)
        mean = float(mean)
        range = float(range)
        if mean and range and (not lower_limit or not upper_limit):
            self.lower_limit = mean - range
            self.upper_limit = mean + range
            
        self.random_number_generator = random_number_generator
        self.decimal_places = decimal_places
        self.random_number = 0

    def generate_number(self):
        random_number = self.random_number_generator.generate_number()
        # a + RND(b - a)
        self.random_number = self.truncate(random_number, self.decimal_places)
        return self.truncate(self.lower_limit + random_number * (self.upper_limit - self.lower_limit), self.decimal_places)
    
    def get_expected_frequency(self, interval, sample_size, **kwargs):
        intervals_amount = kwargs['intervals_amount']
        return sample_size / intervals_amount

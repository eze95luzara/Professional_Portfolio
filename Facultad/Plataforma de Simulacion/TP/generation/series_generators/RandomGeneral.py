from decimal import Decimal
from numpy import sqrt

from generation.series_generators.base import BaseSeriesGenerator


class RandomGeneralNumberGenerator(BaseSeriesGenerator):
    default_lower_limit = 0

    def __init__(self,
                 decimal_places,
                 random_number_generator,
                 mean=0):
        self.decimal_places = decimal_places
        self.random_number_generator = random_number_generator
        self.mean = float(mean)
        self.lower_limit = self.default_lower_limit
        self.random_number = 0

    def generate_number(self):
        random_number = self.random_number_generator.generate_number()
        self.random_number = self.truncate(random_number, self.decimal_places)
        return random_number
    

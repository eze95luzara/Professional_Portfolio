from generation.series_generators.base import BaseSeriesGenerator


class ProbabilityBasedNumberGenerator(BaseSeriesGenerator):
    @staticmethod
    def calculate_probabilities(frequencies, total_values):
        probabilities = {}
        accumulated_probs = {}
        prev_key = None
        for key, value in frequencies.items():
            probabilities[key] = value/total_values
            if prev_key is None:
                accumulated_probs[key] = value/total_values
                prev_key = key
                continue
            accumulated_probs[key] = accumulated_probs[prev_key] + value/total_values
            prev_key = key
        return probabilities, accumulated_probs


    def __init__(self,
                 decimal_places,
                 random_number_generator,
                 frequencies,
                 total_values):
        self.decimal_places = decimal_places
        self.random_number_generator = random_number_generator
        self.frequencies = frequencies
        self.total_values = total_values
        self.probabilities, self.accumulated_probabilities = self.calculate_probabilities(
            frequencies, total_values)


    def generate_number(self):
        self.random_number = self.random_number_generator.generate_number()
        for key, value in self.accumulated_probabilities.items():
            if self.random_number <= value:
                generated_value = key
                break  
        return generated_value
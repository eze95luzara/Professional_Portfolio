from django.shortcuts import render

from generation.number_generator.languaje import LanguajeRandomGenerator
from generation.series_generators.uniform import UniformNumberGenerator
from generation.series_generators.normal import NormalNumberGenerator
from generation.series_generators.exponential import ExponentialNumberGenerator

from tp3.number_generator_handler import TP3NumberGeneratorHandler as NumberGeneratorHandler
from tp3.iteration_item import IterationItem


def index(request):
    return render(request, 'index.html', {})

UNIFORM = 'uniform'
NORMAL = 'normal'
EXPONENTIAL = 'exponential'

DISTRIBUTION_MAPPING = {
    UNIFORM: UniformNumberGenerator,
    NORMAL: NormalNumberGenerator,
    EXPONENTIAL: ExponentialNumberGenerator,
}

def select_item(iteration_item, *args, **kwargs):
    return iteration_item

def generate_series(request):
    data = request.POST
    distribution_generator_class = DISTRIBUTION_MAPPING[data.get("distribution")]
    distribution_arguments = [int(data.get("decimal_places", 4)), LanguajeRandomGenerator(), *data.getlist(f"{data.get('distribution')}_args")]
    distribution_generator = NumberGeneratorHandler.instantiate_distribution_generator(distribution_generator_class, *distribution_arguments)
    number_generator = NumberGeneratorHandler(
        distribution_generator,
        select_item,
        data['sample_size'],
        IterationItem,
        intervals_amount=int(data['intervals_amount'])
    )
    number_generator.run()
    import json

    return render(request, 'results.html', {
        'history': number_generator.history,
        'history_str': json.dumps(number_generator.history), 
        'labels': number_generator.frequencies.keys(),
        'values': number_generator.frequencies.values(),
        'frequencies': number_generator.frequencies,
    })
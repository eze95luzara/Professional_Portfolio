from django.shortcuts import render

from generation.number_generator.languaje import  LanguajeRandomGenerator

from tp4.simulation_item import IterationItem
from tp4.simulation_handler import NumberGeneratorHandler
from tp4.simulation_series_generator import ProbabilityBasedNumberGenerator

# Create your views here.

def index(request):
    return render(request, 'tp4/index.html', {})

def select_item(iteration_item, *args, **kwargs):
    from_time = int(kwargs['from_time'])
    iterations_to_show = int(kwargs['iterations_to_show'])
    to_time = from_time + iterations_to_show
    return iteration_item if (iteration_item['iteration'] >= from_time and iteration_item['iteration'] <= to_time) or (iteration_item['iteration'] == int(kwargs['total_iterations'])) else None

def generate_frequencies_dict(frequencies_list):
    frequencies = {}
    total_values = 0
    for index in range(len(frequencies_list)):
        value = int(frequencies_list[index])
        frequencies[index] = value
        total_values += value
    return frequencies, total_values

def generate_frequency_table(frequencies, probabilities, accumulated_probabilities):
    table = {}
    for index in range(len(frequencies)):
        row = []
        row.append(frequencies[index])
        row.append(probabilities[index])
        accumulated_probability = round(accumulated_probabilities[index], 2)
        row.append(accumulated_probability)
        if index == 0:
            interval = '0.00 - ' + str(accumulated_probability - 0.01)
        else:
            interval = str(round(accumulated_probabilities[index-1], 2)) + ' - ' + str(accumulated_probability - 0.01)
        row.append(interval)
        table[index] = row
    return table

def simulate(request):
    data = request.POST
    frequencies, total_values = generate_frequencies_dict(data.getlist('absent'))
    distribution_generator_class = ProbabilityBasedNumberGenerator
    distribution_arguments = [int(data.get("decimal_places", 4)), LanguajeRandomGenerator(), frequencies, total_values]
    distribution_generator = NumberGeneratorHandler.instantiate_distribution_generator(distribution_generator_class, *distribution_arguments)
    number_generator = NumberGeneratorHandler(
        distribution_generator,
        select_item,
        data['total_iterations'],
        IterationItem,
        iteration_item_kwargs={
            'total_workers':data['total_workers'],
            'workers_cost':float(data['per_worker_cost']) * int(data['total_workers']),
            'production_cost':data['production_cost'],
            'production_benefit':data['production_benefit'],
        },
        history_kwargs={
            'from_time': data['from_time'],
            'iterations_to_show': data['iterations_to_show'],
            'total_iterations': data['total_iterations'],
        }
    )
    number_generator.run()
    frequency_table = generate_frequency_table(
        frequencies,
        distribution_generator.probabilities,
        distribution_generator.accumulated_probabilities
    )
    response_data = dict(
        history=number_generator.history,
        total_workers=data['total_workers'],
        workers_cost=data['per_worker_cost'],
        production_cost=data['production_cost'],
        production_benefit=data['production_benefit'],
        total_iterations=data['total_iterations'],
        frequency_table=frequency_table
    )
    return render(request, 'tp4/results.html', response_data)
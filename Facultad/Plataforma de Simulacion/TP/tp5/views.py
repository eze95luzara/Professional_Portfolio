from django.shortcuts import render
from generation.number_generator.languaje import LanguajeRandomGenerator
from generation.series_generators.uniform import UniformNumberGenerator
from generation.series_generators.normal import NormalNumberGenerator
from generation.series_generators.exponential import ExponentialNumberGenerator

from generation.series_generators.generator_handler import NumberGeneratorHandler
from tp5.event_generator_handler import EventGeneratorHandler
from tp5.handlers.cleaning_handler import CleanEventHandler
from tp5.handlers.event_handler import EventHandler
from tp5.servers.item import BasketballItem, CleaningItem, FootballItem, HandballItem
from tp5.equipos import BasketballTeam, FootballTeam, HandballTeam
import copy

# Create your views here.
def index(request):
    return render(request, 'tp5/index.html', {})

def select_item(iteration_item, *args, **kwargs):
    from_time = int(kwargs['from_time'])
    iterations_to_show = int(kwargs['iterations_to_show'])
    to_time = from_time + iterations_to_show
    return iteration_item if (iteration_item['iteration'] >= from_time and iteration_item['iteration'] <= to_time) or (iteration_item['iteration'] == int(kwargs['total_iterations'])) else None


def parse_distribution_generator(data, distribution_generator, variable_names=[], prefix="", in_hours=False):
    value_modifier = 1
    if in_hours:
        value_modifier = 60
    arguments = [int(data.get("decimal_places", 4)), LanguajeRandomGenerator()]
    for variable_name in variable_names:
        arguments.append(float(data[f'{prefix}{variable_name}']) * value_modifier)
    return NumberGeneratorHandler.instantiate_distribution_generator(distribution_generator, *arguments)


def create_generators(data):
    football_mean = data['football_mean']
    Football_llegada_generator = ExponentialNumberGenerator(4,LanguajeRandomGenerator(), mean=football_mean)

    football_ocupation_mean = data['football_ocupation_mean']
    football_ocupation_standard_deviation = data['football_ocupation_standard_deviation']
    Football_ocupation_generator = NormalNumberGenerator(4, LanguajeRandomGenerator(), mean=football_ocupation_mean, standard_deviation=football_ocupation_standard_deviation )

    handball_mean = data['handball_mean']
    handball_standard_deviation = data['handball_standard_deviation']
    Handball_llegada_generator = NormalNumberGenerator(4, LanguajeRandomGenerator(), mean=handball_mean, standard_deviation=handball_standard_deviation)

    handball_ocupation_mean = data['handball_ocupation_mean']
    handball_ocupation_standard_deviation = data['handball_ocupation_standard_deviation']
    Handball_ocupation_generator = NormalNumberGenerator(4, LanguajeRandomGenerator(), mean=handball_ocupation_mean, standard_deviation=handball_ocupation_standard_deviation)

    basketball_mean = data['basketball_mean']
    basketball_standard_deviation = data['basketball_standard_deviation']
    Basketball_llegada_generator = NormalNumberGenerator(4, LanguajeRandomGenerator(), mean=basketball_mean, standard_deviation=basketball_standard_deviation)

    basketball_ocupation_mean = data['basketball_ocupation_mean']
    basketball_ocupation_range = data['basketball_ocupation_range']
    basketball_lower_limit = int(basketball_ocupation_mean) - (int(basketball_ocupation_range))
    basketball_upper_limit = int(basketball_ocupation_mean) + (int(basketball_ocupation_range))
    Basketball_ocupation_generator = UniformNumberGenerator(4, LanguajeRandomGenerator(), lower_limit=basketball_lower_limit, upper_limit=basketball_upper_limit)
    generators = {}
    generators['Basketball_Arrival'] = Basketball_llegada_generator
    generators['Handball_Arrival'] = Handball_llegada_generator
    generators['Football_Arrival'] = Football_llegada_generator
    generators['Basketball_Finish'] = Basketball_ocupation_generator
    generators['Handball_Finish'] = Handball_ocupation_generator
    generators['Football_Finish'] = Football_ocupation_generator
    return generators

def get_eventos(prev_row):
    eventos = []
    eventos.append(float(prev_row['Basketball_arrival']))
    eventos.append(float(prev_row['Handball_arrival']))
    eventos.append(float(prev_row['Football_arrival']))
    if prev_row['Basketball_finish'] != None:
        eventos.append(float(prev_row['Basketball_finish']))
    if prev_row['Handball_finish'] != None:
        eventos.append(float(prev_row['Handball_finish']))
    if prev_row['Football_finish'] != None:
        eventos.append(float(prev_row['Football_finish']))
    if prev_row['Cleaning_finish'] != None:
        eventos.append(float(prev_row['Cleaning_finish']))
    return eventos
    
def generate_random_numbers(generator, current_time):
    time_between = abs(generator.generate_number())
    random = generator.random_number
    end_time = time_between + current_time
    return random, time_between, end_time

def get_next_team(cola_basketball, cola_handball, cola_football):
    next_team = None
    next_time = 0
    if len(cola_handball) > 0:
        handball_time = cola_handball[0].hora_llegada
        next_team = 'Handball'
        next_time = handball_time
    if len(cola_football) > 0:
        football_time = cola_football[0].hora_llegada
        if next_time == 0:
            next_team = 'Football'
            next_time = football_time
        elif football_time < next_time:
            next_time = football_time
            next_team = 'Football'
    if len(cola_basketball) > 0:
        basketball_time = cola_basketball[0].hora_llegada
        if next_time == 0:
            next_team = 'Basketball'
            next_time = basketball_time
        elif basketball_time < next_time and len(cola_basketball) > 1:
            next_team = 'Basketball'
            next_time = basketball_time
    return next_team

def cleanRandoms(current_row):
    current_row['Basketball_arrival_random'] = None
    current_row['Basketball_time_between_arrivals'] = None 
    current_row['Basketball_finish_random'] = None
    current_row['Basketball_time_to_finish'] = None
    current_row['Handball_arrival_random'] = None
    current_row['Handball_time_between_arrivals'] = None 
    current_row['Handball_finish_random'] = None
    current_row['Handball_time_to_finish'] = None
    current_row['Football_arrival_random'] = None
    current_row['Football_time_between_arrivals'] = None 
    current_row['Football_finish_random'] = None
    current_row['Football_time_to_finish'] = None


def generate_last_info(teams_array, start, end):
    info = []
    first_end = False
    for i in range(start, end):
        team_info = {}
        team = teams_array[i]
        team_info['order'] = team.order
        team_info['hora_llegada'] = team.hora_llegada
        team_info['status'] = team.status
        team_info['deporte'] = team.getType()
        info.append(team_info)
    for i in range(end, len(teams_array)):
        team_info = {}
        team = teams_array[i]
        if team.status != 'Destruido' and not first_end:
            first_end = True
            team_info['order'] = team.order
            team_info['hora_llegada'] = team.hora_llegada
            team_info['status'] = team.status
            team_info['deporte'] = team.getType()
            info.append(team_info)
        elif first_end:
            team_info['order'] = team.order
            team_info['hora_llegada'] = team.hora_llegada
            team_info['status'] = team.status
            team_info['deporte'] = team.getType()
            info.append(team_info)
    return info

def generate_last_info_current(teams_array, start, end):
    info = []
    first_end = False
    for i in range(start, end):
        team = teams_array[i]
        if team.status != 'Destruido':
            team_info = {}
            team_info['order'] = team.order
            team_info['hora_llegada'] = team.hora_llegada
            team_info['status'] = team.status
            team_info['deporte'] = team.getType()
            info.append(team_info)
    for i in range(end, len(teams_array)):
        if team.status != 'Destruido':
            team_info = {}
            team = teams_array[i]
            if first_end:
                first_end = True
                team_info['order'] = team.order
                team_info['hora_llegada'] = team.hora_llegada
                team_info['status'] = team.status
                team_info['deporte'] = team.getType()
                info.append(team_info)
            else:
                team_info['order'] = team.order
                team_info['hora_llegada'] = team.hora_llegada
                team_info['status'] = team.status
                team_info['deporte'] = team.getType()
                info.append(team_info)
    return info

def generate_info(teams_array, start, end, first):
    info = []
    for i in range(start, len(teams_array)):
        team_info = {}
        team = teams_array[i]
        team_info['order'] = team.order
        team_info['hora_llegada'] = team.hora_llegada
        team_info['status'] = team.status
        team_info['deporte'] = team.getType()
        
        if team.status != 'Destruido' and not first:
            start = i
            first = True
            info.append(team_info)
        elif first:
            info.append(team_info)
    end = len(teams_array)
    return info, start, end, first

def generate_info_alternativo(teams_array):
    info = []
    first = False
    start = 0
    for i in range(len(teams_array)):
        team_info = {}
        team = teams_array[i]
        team_info['order'] = team.order
        team_info['hora_llegada'] = team.hora_llegada
        team_info['status'] = team.status
        team_info['deporte'] = team.getType()
        
        if team.status != 'Destruido' and not first:
            start = i
            first = True
            info.append(team_info)
        elif first:
            info.append(team_info)
    return info, start

def generate_info_alternativo_last(teams_array, equipos_headers, last_order):
    info = []
    start = len(equipos_headers)
    for i in range(len(teams_array)):
        team_info = {}
        team = teams_array[i]
        team_info['order'] = team.order
        team_info['hora_llegada'] = team.hora_llegada
        team_info['status'] = team.status
        team_info['deporte'] = team.getType()
        
        if team.status != 'Destruido':
            info.append(team_info)
            if team.order > last_order:
                equipos_headers.append(f'Equipo {team.order} - {team.getType()}')
    return info, start, equipos_headers


def generate_info_current(teams_array, max):
    info = []
    for team in teams_array:
        if team.status != 'Destruido':
            team_info = {}
            team_info['order'] = team.order
            team_info['hora_llegada'] = team.hora_llegada
            team_info['status'] = team.status
            team_info['deporte'] = team.getType()
            info.append(team_info)
    if len(info) > max:
        max = len(info)
    return info, max

def simulate(request):
    data = request.POST
    total_iterations = int(data['total_iterations'])
    save_since = int(data['from_time'])
    save_until = int(data['from_time']) + int(data['iterations_to_show'])
    cleaning_time = int(data['cleaning_time'])
    generators = create_generators(data)
    resultados = []
    equipos = []
    current_teams = []
    #Inicializacion de parametros
    current_time = 0
    iteration = 0
    start = 0
    end = 0
    max = 0
    first = False
    order = 1
    equipos_headers = []
    first_row = None
    final_row = False
    last_order = 0
    cola_basketball = []
    cola_handball = []
    cola_football = []
    #Estadisticos
    espera_basketball = 0
    espera_handball = 0
    espera_football = 0
    equipos_finalizados_basketball = 0
    equipos_finalizados_handball = 0
    equipos_finalizados_football = 0
    limpiezas_finalizadas = 0

    current_row = {}
    current_row['event_type'] = 'Inicializacion' 
    current_row['server_status'] = 'Libre'
    current_row['current_time'] = current_time
    current_row['iteration'] = iteration
    current_row['server_status'] = 'Libre'
    current_row['start_equipos'] = 0
    teams = ['Basketball', 'Football', 'Handball']
    
    for team in teams:
        current_row[f'{team}_arrival_random'], current_row[f'{team}_time_between_arrivals'], current_row[f'{team}_arrival'] = generate_random_numbers(generators[f'{team}_Arrival'], current_time)
        current_row[f'{team}_finish'] = None
    current_row['Cleaning_finish'] = None
    current_row['Cola'] = len(cola_basketball) + len(cola_football) + len(cola_handball)
    current_row['espera_basketball'] = espera_basketball
    current_row['espera_handball'] = espera_handball
    current_row['espera_football'] = espera_football
    current_row['equipos_finalizados_basketball'] = equipos_finalizados_basketball
    current_row['equipos_finalizados_handball'] = equipos_finalizados_handball
    current_row['equipos_finalizados_football'] = equipos_finalizados_football
    current_row['limpiezas_finalizadas'] = limpiezas_finalizadas
    current_row['equipos'], start, end, first = generate_info(equipos, start, end, first)
    resultados.append(current_row)
    for i in range(total_iterations):
        prev_row = current_row
        current_row = copy.deepcopy(current_row)
        cleanRandoms(current_row)
        eventos = get_eventos(prev_row)
        iteration +=1
        current_row['iteration'] = iteration
        current_time = min(x for x in eventos if x is not None)
        current_row['current_time'] = current_time

        #Fin Limpieza
        if prev_row['Cleaning_finish'] != None and float(prev_row['Cleaning_finish']) == current_time:
            current_row['Cleaning_finish'] = None
            current_row['event_type'] = 'Fin Limpieza Cancha'
            limpiezas_finalizadas += 1
            #Ver quien sigue
            next_team = get_next_team(cola_basketball, cola_handball, cola_football)
            #Si no sigue nadie, pasar server a libre
            if next_team == None:
                current_row['server_status'] = 'Libre'
            elif next_team == 'Basketball':
                current_row['server_status'] = 'Ocupado'
                team = cola_basketball.pop(0)
                team.setStatus('Jugando')
                espera_basketball += (current_time - team.hora_llegada)
                equipos_finalizados_basketball += 1
                current_teams.append(team)
                current_row['Basketball_finish_random'], current_row['Basketball_time_to_finish'], current_row['Basketball_finish'] = generate_random_numbers(generators['Basketball_Finish'], current_time)
                if len(cola_basketball) > 0:
                    team = cola_basketball.pop(0)
                    current_teams.append(team)
                    team.setStatus('Jugando')
                    espera_basketball += (current_time - team.hora_llegada)
                    equipos_finalizados_basketball += 1
            elif next_team == 'Handball':
                current_row['server_status'] = 'Ocupado'
                team = cola_handball.pop(0)
                team.setStatus('Jugando')
                espera_handball += (current_time - team.hora_llegada)
                equipos_finalizados_handball += 1
                current_teams.append(team)
                current_row['Handball_finish_random'], current_row['Handball_time_to_finish'], current_row['Handball_finish'] = generate_random_numbers(generators['Handball_Finish'], current_time)
            elif next_team == 'Football':
                current_row['server_status'] = 'Ocupado'
                team = cola_football.pop(0)
                team.setStatus('Jugando')
                espera_football += (current_time - team.hora_llegada)
                equipos_finalizados_football += 1
                current_teams.append(team)
                current_row['Football_finish_random'], current_row['Football_time_to_finish'], current_row['Football_finish'] = generate_random_numbers(generators['Football_Finish'], current_time)
        #Fin Basket
        elif prev_row['Basketball_finish'] != None and float(prev_row['Basketball_finish']) == current_time:
            current_row['Basketball_finish'] = None
            for team in current_teams:
                team.setStatus('Destruido')
            current_row['event_type'] = 'Fin Partido Basketball'
            current_teams.clear()
            #Ver quien sigue
            next_team = get_next_team(cola_basketball, cola_handball, cola_football)
            #Si no sigue nadie o es distinto a basket, limpieza
            if next_team != 'Basketball' or next_team == None:
                current_row['Cleaning_finish'] = current_time + cleaning_time
                current_row['server_status'] = 'En Limpieza'
            else:
                team = cola_basketball.pop(0)
                team.setStatus('Jugando')
                espera_basketball += (current_time - team.hora_llegada)
                equipos_finalizados_basketball += 1
                current_teams.append(team)
                current_row['Basketball_finish_random'], current_row['Basketball_time_to_finish'], current_row['Basketball_finish'] = generate_random_numbers(generators['Basketball_Finish'], current_time)
                if len(cola_basketball) > 0:
                    team = cola_basketball.pop(0)
                    current_teams.append(team)
                    team.setStatus('Jugando')
                    espera_basketball += (current_time - team.hora_llegada)
                    equipos_finalizados_basketball += 1
        #Fin Handball
        elif prev_row['Handball_finish'] != None and float(prev_row['Handball_finish']) == current_time:
            current_row['Handball_finish'] = None
            current_row['event_type'] = 'Fin Partido Handball'
            current_teams[0].setStatus('Destruido')
            current_teams.clear()
            #Ver quien sigue
            next_team = get_next_team(cola_basketball, cola_handball, cola_football)
            #Si no sigue nadie o es distinto a handball, limpieza
            if next_team != 'Handball' or next_team == None:
                current_row['Cleaning_finish'] = current_time + cleaning_time
                current_row['server_status'] = 'En Limpieza'
            else:
                team = cola_handball.pop(0)
                team.setStatus('Jugando')
                espera_handball += (current_time - team.hora_llegada)
                equipos_finalizados_handball += 1
                current_teams.append(team)
                current_row['Handball_finish_random'], current_row['Handball_time_to_finish'], current_row['Handball_finish'] = generate_random_numbers(generators['Handball_Finish'], current_time)
        #Fin Football
        elif prev_row['Football_finish'] != None and float(prev_row['Football_finish']) == current_time:
            current_row['Football_finish'] = None
            current_row['event_type'] = 'Fin Partido Football'
            current_teams[0].setStatus('Destruido')
            current_teams.clear()
            #Ver quien sigue
            next_team = get_next_team(cola_basketball, cola_handball, cola_football)
            #Si no sigue nadie o es distinto a football, limpieza
            if next_team != 'Football' or next_team == None:
                current_row['Cleaning_finish'] = current_time + cleaning_time
                current_row['server_status'] = 'En Limpieza'
            else:
                team = cola_football.pop(0)
                team.setStatus('Jugando')
                espera_football += (current_time - team.hora_llegada)
                equipos_finalizados_football += 1
                current_teams.append(team)
                current_row['Football_finish_random'], current_row['Football_time_to_finish'], current_row['Football_finish'] = generate_random_numbers(generators['Football_Finish'], current_time)
        #Llegada Basket
        elif prev_row['Basketball_arrival'] != None and float(prev_row['Basketball_arrival']) == current_time:
            current_row['event_type'] = 'Llegada Equipo Basketball'
            basketball_team = BasketballTeam(order, current_time, 'En espera')
            equipos.append(basketball_team)
            if not final_row:
                equipos_headers.append(f'Equipo {order} - Basketball')
                last_order = order
            order += 1
            
            if prev_row['server_status'] == 'Libre': #Si servidor esta libre, pasa a jugar
                basketball_team.setStatus('Jugando')
                current_teams.append(basketball_team)
                current_row['server_status'] = 'Ocupado'
                current_row['Basketball_finish_random'], current_row['Basketball_time_to_finish'], current_row['Basketball_finish'] = generate_random_numbers(generators['Basketball_Finish'], current_time)
            else: #Si servidor ocupado, va a la cola
                cola_basketball.append(basketball_team)
            #Generar nueva llegada basket
            current_row['Basketball_arrival_random'], current_row['Basketball_time_between_arrivals'], current_row['Basketball_arrival'] = generate_random_numbers(generators['Basketball_Arrival'], current_time)
        
        #Llegada Handball
        elif prev_row['Handball_arrival'] != None and float(prev_row['Handball_arrival']) == current_time:
            current_row['event_type'] = 'Llegada Equipo Handball'
            handball_team = HandballTeam(order, current_time, 'En espera')
            equipos.append(handball_team)
            if not final_row:
                equipos_headers.append(f'Equipo {order} - Handball')
                last_order = order
            order += 1
            if prev_row['server_status'] == 'Libre': #Si servidor esta libre, pasa a jugar
                handball_team.setStatus('Jugando')
                current_teams.append(handball_team)
                current_row['server_status'] = 'Ocupado'
                current_row['Handball_finish_random'], current_row['Handball_time_to_finish'], current_row['Handball_finish'] = generate_random_numbers(generators['Handball_Finish'], current_time)
                
            else: #Si servidor ocupado, va a la cola
                cola_handball.append(handball_team)
            #Generar nueva llegada handball
            current_row['Handball_arrival_random'], current_row['Handball_time_between_arrivals'], current_row['Handball_arrival'] = generate_random_numbers(generators['Handball_Arrival'], current_time)
            
        #Llegada Basket
        elif prev_row['Football_arrival'] != None and float(prev_row['Football_arrival']) == current_time:
            current_row['event_type'] = 'Llegada Equipo Football'
            football_team = FootballTeam(order, current_time, 'En espera')
            equipos.append(football_team)
            if not final_row:
                equipos_headers.append(f'Equipo {order} - Football')
                last_order = order
            order += 1
            
            if prev_row['server_status'] == 'Libre': #Si servidor esta libre, pasa a jugar
                football_team.setStatus('Jugando')
                current_teams.append(football_team)
                current_row['server_status'] = 'Ocupado'
                current_row['Football_finish_random'], current_row['Football_time_to_finish'], current_row['Football_finish'] = generate_random_numbers(generators['Football_Finish'], current_time)
            else: #Si servidor ocupado, va a la cola
                cola_football.append(football_team)
            #Generar nueva llegada football
            current_row['Football_arrival_random'], current_row['Football_time_between_arrivals'], current_row['Football_arrival'] = generate_random_numbers(generators['Football_Arrival'], current_time)
        
        current_row['Cola'] = len(cola_basketball) + len(cola_football) + len(cola_handball)
        current_row['espera_basketball'] = espera_basketball
        current_row['espera_handball'] = espera_handball
        current_row['espera_football'] = espera_football
        current_row['equipos_finalizados_basketball'] = equipos_finalizados_basketball
        current_row['equipos_finalizados_handball'] = equipos_finalizados_handball
        current_row['equipos_finalizados_football'] = equipos_finalizados_football
        current_row['limpiezas_finalizadas'] = limpiezas_finalizadas
        
        if (iteration >= save_since and iteration <= save_until):
            current_row['equipos'], start = generate_info_alternativo(equipos)
            if first_row == None:
                first_row = start
                print(first_row)
                for i in range(first_row):
                    equipos_headers.pop(0)
            current_row['start_equipos'] = start - first_row
            #current_row['equipos'], max = generate_info_current(equipos, max)
            resultados.append(current_row)
            #last_equipos = copy.deepcopy(equipos)
        if iteration == save_until:
            final_row = True
        if iteration == total_iterations:
            #current_row['equipos'] = generate_last_info(equipos, start, end)
            current_row['equipos'], start, equipos_headers = generate_info_alternativo_last(equipos, equipos_headers, last_order)
            current_row['start_equipos'] = start
            resultados.append(current_row)
            #last_equipos = copy.deepcopy(equipos)
            max_equipos = []
            for i in range(max):
                max_equipos.append('Team')

    #Calculo resultados
    if equipos_finalizados_basketball > 0:
        promedio_basketball = espera_basketball / equipos_finalizados_basketball
    else:
        promedio_basketball = 0
    if equipos_finalizados_handball > 0:
        promedio_handball = espera_handball / equipos_finalizados_handball
    else:
        promedio_handball = 0
    if equipos_finalizados_football > 0:
        promedio_football = espera_football / equipos_finalizados_football
    else:
        promedio_football = 0
    tasa_limpieza = (limpiezas_finalizadas * cleaning_time) / current_time

    response_data = dict(
        history = resultados,
        equipos = equipos_headers,
        total_iterations = total_iterations,
        promedio_basketball = promedio_basketball,
        promedio_handball = promedio_handball,
        promedio_football = promedio_football,
        tasa_limpieza = tasa_limpieza
    )
    return render(request, 'tp5/results.html', response_data)
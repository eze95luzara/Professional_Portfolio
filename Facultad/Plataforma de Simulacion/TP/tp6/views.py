import json
from django.shortcuts import render
from django.core.paginator import Paginator
from generation.number_generator.languaje import LanguajeRandomGenerator
from generation.series_generators.uniform import UniformNumberGenerator
from generation.series_generators.normal import NormalNumberGenerator
from generation.series_generators.exponential import ExponentialNumberGenerator

from generation.series_generators.generator_handler import NumberGeneratorHandler
from tp6.equipos import BasketballTeam, FootballTeam, HandballTeam
from tp6.models import Row, CommonData, TablaEuler, EquiposHeaders
import copy

# Create your views here.
def index(request):
    return render(request, 'tp6/index.html', {})

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
    current_row['Cleaning_time'] = None
    current_row['Cleaning_d'] = None

def generate_info(teams_array):
    info = []
    first = False
    start = None
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

def generate_info_last(teams_array, equipos_headers, last_order):
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

def calculateCleanings(h, basketball_d, handball_d, football_d):
    c1 = 0
    t = h
    c = 0
    index = 0
    max_d = max(basketball_d, handball_d, football_d)
    row = {}
    row['Ti'] = None
    row['Ci'] = None
    row['derivada'] = None
    row['Ti1'] = t
    row['Ci1'] = c1
    row['teams'] = ''
    save_euler_row(row, index)
    basketball_found, handball_found, football_found = False, False, False
    while c < max_d:
        index +=1
        teams = []
        row = {}
        c = c1
        row['Ti'] = t
        row['Ci'] = c
        if c >= basketball_d and not basketball_found:
            basketball_cleaning_time = t
            basketball_found = True
            teams.append('Basketball')
        if c >= handball_d and not handball_found:
            handball_cleaning_time = t
            handball_found = True
            teams.append('Handball')
        if c >= football_d and not football_found:
            football_cleaning_time = t
            football_found = True
            teams.append('Football')
        teams_string = ''
        for team in teams:
            teams_string += f'{team}, '
        if teams_string:
            teams_string = teams_string[:-2]
        row['teams'] = teams_string
        derivada = 0.6*c + t
        c1 = c + (derivada * h)
        t += h
        row['derivada'] = derivada
        row['Ti1'] = t
        row['Ci1'] = c1
        save_euler_row(row, index)
        
    return basketball_cleaning_time, handball_cleaning_time, football_cleaning_time

def save_euler_row(row, index):
    row = TablaEuler(
        index = index, 
        Ti = row['Ti'],
        Ci = row['Ci'],
        derivada = row['derivada'],
        Ti1 = row['Ti1'],
        Ci1 = row['Ci1'],
        teams = row['teams']
    )
    row.save()

def save_headers_page(equipos_headers, headers_index):
    row = EquiposHeaders(
        index = headers_index,
        headers = json.dumps(equipos_headers)
    )
    row.save()

def save_row(current_row):
    row = Row(
          iteration = current_row['iteration'],
          current_time = current_row['current_time'],
          event_type = current_row['event_type'],
          Basketball_arrival_random = current_row['Basketball_arrival_random'],
          Basketball_time_between_arrivals = current_row['Basketball_time_between_arrivals'],
          Basketball_arrival = current_row['Basketball_arrival'],
          Football_arrival_random = current_row['Football_arrival_random'],
          Football_time_between_arrivals = current_row['Football_time_between_arrivals'],
          Football_arrival = current_row['Football_arrival'],
          Handball_arrival_random = current_row['Handball_arrival_random'],
          Handball_time_between_arrivals = current_row['Handball_time_between_arrivals'],
          Handball_arrival = current_row['Handball_arrival'],
          Basketball_finish_random = current_row['Basketball_finish_random'],
          Basketball_time_to_finish = current_row['Basketball_time_to_finish'],
          Football_finish = current_row['Football_finish'],
          Handball_finish_random = current_row['Handball_finish_random'],
          Handball_time_to_finish = current_row['Handball_time_to_finish'],
          Handball_finish = current_row['Handball_finish'],
          Cleaning_d = current_row['Cleaning_d'],
          Cleaning_time = current_row['Cleaning_time'],
          Cleaning_finish = current_row['Cleaning_finish'],
          server_status = current_row['server_status'],
          Cola = current_row['Cola'],
          equipos_finalizados_basketball = current_row['equipos_finalizados_basketball'],
          espera_basketball = current_row['espera_basketball'],
          equipos_finalizados_football = current_row['equipos_finalizados_football'],
          espera_football = current_row['espera_football'],
          equipos_finalizados_handball = current_row['equipos_finalizados_handball'],
          espera_handball = current_row['espera_handball'],
          tiempo_limpieza_acumulado = current_row['tiempo_limpieza_acumulado'],
          equipos = json.dumps(current_row['equipos']),
          start_equipos = current_row['start_equipos']

        )
    row.save()

def save_common_data(cleaning_d_basketball, cleaning_d_handball, cleaning_d_football, total_iterations, promedio_basketball, promedio_handball, promedio_football, tasa_limpieza, h):
    common_data = CommonData(
        cleaning_d_basketball = cleaning_d_basketball,
        cleaning_d_handball = cleaning_d_handball,
        cleaning_d_football = cleaning_d_football,
        total_iterations = total_iterations,
        promedio_basketball = promedio_basketball,
        promedio_handball = promedio_handball,
        promedio_football = promedio_football,
        tasa_limpieza = tasa_limpieza,
        h = h
    )
    common_data.save()

def simulate(request):
    data = request.POST
    total_iterations = int(data['total_iterations'])
    save_since = int(data['from_time'])
    save_until = int(data['from_time']) + int(data['iterations_to_show'])
    cleaning_d_handball = int(data['cleaning_d_handball'])
    cleaning_d_football = int(data['cleaning_d_football'])
    cleaning_d_basketball = int(data['cleaning_d_basketball'])
    h = float(data['h'])
    request.session['records_per_page'] = int(data['records_per_page'])
    Row.objects.all().delete()
    TablaEuler.objects.all().delete()
    CommonData.objects.all().delete()
    EquiposHeaders.objects.all().delete()
    generators = create_generators(data)
    basketball_cleaning_time, handball_cleaning_time, football_cleaning_time = calculateCleanings(h, cleaning_d_basketball, cleaning_d_handball, cleaning_d_football)
    resultados = []
    equipos = []
    current_teams = []
    #Inicializacion de parametros
    current_time = 0
    iteration = 0
    start = 0
    saved_rows = 1
    headers_index = 1
    update_headers = False
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
    tiempo_limpieza = 0

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
    current_row['Cleaning_time'] = None
    current_row['Cleaning_d'] = None
    current_row['Cola'] = len(cola_basketball) + len(cola_football) + len(cola_handball)
    current_row['espera_basketball'] = espera_basketball
    current_row['espera_handball'] = espera_handball
    current_row['espera_football'] = espera_football
    current_row['equipos_finalizados_basketball'] = equipos_finalizados_basketball
    current_row['equipos_finalizados_handball'] = equipos_finalizados_handball
    current_row['equipos_finalizados_football'] = equipos_finalizados_football
    current_row['tiempo_limpieza_acumulado'] = tiempo_limpieza
    current_row['Basketball_finish_random'] = None
    current_row['Basketball_time_to_finish'] = None
    current_row['Handball_finish_random'] = None
    current_row['Handball_time_to_finish'] = None
    current_row['Football_finish_random'] = None
    current_row['Football_time_to_finish'] = None
    current_row['equipos'] = []
    resultados.append(current_row)
    save_row(current_row)
    if request.session['records_per_page'] == 1:
        save_headers_page(equipos_headers, headers_index)
        headers_index += 1
    for i in range(total_iterations):
        prev_row = current_row
        current_row = copy.deepcopy(current_row)
        cleanRandoms(current_row)
        eventos = get_eventos(prev_row)
        iteration +=1
        current_row['iteration'] = iteration
        current_time = min(x for x in eventos if x is not None)
        current_row['current_time'] = current_time
        if final_row:
            current_row['equipos'] = []

        #Fin Limpieza
        if prev_row['Cleaning_finish'] != None and float(prev_row['Cleaning_finish']) == current_time:
            current_row['Cleaning_finish'] = None
            current_row['event_type'] = 'Fin Limpieza Cancha'
            tiempo_limpieza += cleaning_time
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
                cleaning_time = basketball_cleaning_time
                current_row['Cleaning_time'] = cleaning_time
                current_row['Cleaning_d'] = cleaning_d_basketball
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
                cleaning_time = handball_cleaning_time
                current_row['Cleaning_time'] = cleaning_time
                current_row['Cleaning_d'] = cleaning_d_handball
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
                cleaning_time = football_cleaning_time
                current_row['Cleaning_time'] = cleaning_time
                current_row['Cleaning_d'] = cleaning_d_football
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
                equipos_finalizados_basketball += 1
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
                equipos_finalizados_handball += 1
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
                equipos_finalizados_football += 1
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
        current_row['tiempo_limpieza_acumulado'] = tiempo_limpieza
        
        if update_headers:
            equipos_headers = []
            first_team = None
            headers_start = False
            for equipo in equipos:
                if equipo.status != 'Destruido' and not headers_start:
                    equipos_headers.append(f'Equipo {equipo.order} - {equipo.getType()}')
                    headers_start = True
                    first_team = equipo.order - 1
                elif headers_start:
                    equipos_headers.append(f'Equipo {equipo.order} - {equipo.getType()}')                     
            if first_team == None:
                first_team = len(equipos)
            first_row = first_team
            current_row['start_equipos'] = 0
            update_headers = False
        if (iteration >= save_since and iteration <= save_until):
            saved_rows += 1
            current_row['equipos'], start = generate_info(equipos)
            if first_row == None and start != None:
                first_row = start
                for i in range(first_row):
                    equipos_headers.pop(0)
            if start != None:
                current_row['start_equipos'] = start - first_row
            save_row(current_row)
            if saved_rows % request.session['records_per_page'] == 0:
                save_headers_page(equipos_headers, headers_index)
                headers_index += 1
                update_headers = True
        if iteration == save_until:
            final_row = True
        if iteration == total_iterations:
            if update_headers:
                equipos_headers = []
                first_team = None
                headers_start = False
                for equipo in equipos:
                    if equipo.status != 'Destruido' and not headers_start:
                        equipos_headers.append(f'Equipo {equipo.order} - {equipo.getType()}')
                        headers_start = True
                        first_team = equipo.order - 1
                    elif headers_start:
                        equipos_headers.append(f'Equipo {equipo.order} - {equipo.getType()}')                     
                if first_team == None:
                    first_team = len(equipos)
                first_row = first_team
                current_row['start_equipos'] = 0
                update_headers = False
            current_row['equipos'], start, equipos_headers = generate_info_last(equipos, equipos_headers, last_order)
            save_headers_page(equipos_headers, headers_index)
            current_row['start_equipos'] = start
            if total_iterations > save_until:
                save_row(current_row)
        if iteration % 10000 == 0:
            print(f'{iteration} filas procesadas')
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
    tasa_limpieza = ((tiempo_limpieza) / current_time) * 100

    save_common_data(cleaning_d_basketball, cleaning_d_handball, cleaning_d_football, total_iterations, promedio_basketball, promedio_handball, promedio_football, tasa_limpieza, h)
    rows = Row.objects.all().order_by('iteration')
    cleaning_table = TablaEuler.objects.all().order_by('index')
    paginator = Paginator(rows, request.session['records_per_page'])
    page_number = request.GET.get('page')
    equipos_headers_object = EquiposHeaders.objects.get(index=1)
    equipos_headers = json.loads(equipos_headers_object.headers)
    for row in rows:
        row.empty_spaces = len(equipos_headers) - len(row.get_parsed_teams())
    page_obj = paginator.get_page(page_number)
    response_data = dict(
        history = page_obj,
        equipos = equipos_headers,
        cleaning_d_basketball = cleaning_d_basketball,
        cleaning_d_handball = cleaning_d_handball,
        cleaning_d_football = cleaning_d_football,
        cleaning_table = cleaning_table,
        total_iterations = total_iterations,
        h = h,
        promedio_basketball = promedio_basketball,
        promedio_handball = promedio_handball,
        promedio_football = promedio_football,
        tasa_limpieza = tasa_limpieza
    )
    return render(request, 'tp6/results.html', response_data)

def paginas(request):
    rows = Row.objects.all().order_by('iteration')
    cleaning_table = TablaEuler.objects.all().order_by('index')
    common_data = CommonData.objects.all()[0]
    paginator = Paginator(rows, request.session['records_per_page'])
    page_number = request.GET.get('page')
    equipos_headers_object = EquiposHeaders.objects.get(index=page_number)
    equipos_headers = json.loads(equipos_headers_object.headers)
    for row in rows:
        row.empty_spaces = len(equipos_headers) - len(row.get_parsed_teams())
    page_obj = paginator.get_page(page_number)
    response_data = dict(
        history = page_obj,
        equipos = equipos_headers,
        cleaning_d_basketball = common_data.cleaning_d_basketball,
        h = common_data.h,
        cleaning_d_handball = common_data.cleaning_d_handball,
        cleaning_d_football = common_data.cleaning_d_football,
        cleaning_table = cleaning_table,
        total_iterations = common_data.total_iterations,
        promedio_basketball = common_data.promedio_basketball,
        promedio_handball = common_data.promedio_handball,
        promedio_football = common_data.promedio_football,
        tasa_limpieza = common_data.tasa_limpieza
    )
    return render(request, 'tp6/results.html', response_data)

from django.shortcuts import render
from generation.number_generator.languaje import LanguajeRandomGenerator
from generation.series_generators.uniform import UniformNumberGenerator
from generation.series_generators.exponential import ExponentialNumberGenerator
from generation.series_generators.RandomGeneral import RandomGeneralNumberGenerator

from generation.series_generators.generator_handler import NumberGeneratorHandler
from Ejercicio236.event_generator_handler import EventGeneratorHandler
from Ejercicio236.handlers.cleaning_handler import CleanEventHandler
from Ejercicio236.handlers.event_handler  import EventHandler
from Ejercicio236.Clientes import Cliente
import copy

# Create your views here.

def index(request):
    return render(request, 'ejercicio236/index.html', {})


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
    
    llegada_cliente_mean = data['llegada_cliente_mean']
    llegada_cliente_range = data['llegada_cliente_range']
    llegada_cliente_lower_limit = int(llegada_cliente_mean) - (int(llegada_cliente_range))
    llegada_cliente_upper_limit = int(llegada_cliente_mean) + (int(llegada_cliente_range))
    Llegada_cliente_generator = UniformNumberGenerator(4, LanguajeRandomGenerator(), lower_limit= llegada_cliente_lower_limit, upper_limit= llegada_cliente_upper_limit)

    atencion_informes_mean = data['atencion_informes_mean']
    atencion_informes_range = data['atencion_informes_range']
    atencion_informes_lower_limit = int(atencion_informes_mean) - (int(atencion_informes_range))
    atencion_informes_upper_limit = int(atencion_informes_mean) + (int(atencion_informes_range))
    Atencion_informes_generator = UniformNumberGenerator(4, LanguajeRandomGenerator(), lower_limit= atencion_informes_lower_limit, upper_limit= atencion_informes_upper_limit)
   
    atencion_reservas_mean = data['atencion_reservas_mean']
    atencion_reservas_range = data['atencion_reservas_range']
    atencion_reservas_lower_limit = int(atencion_reservas_mean) - (int(atencion_reservas_range))
    atencion_reservas_upper_limit = int(atencion_reservas_mean) + (int(atencion_reservas_range))
    Atencion_reservas_generator = UniformNumberGenerator(4, LanguajeRandomGenerator(), lower_limit= atencion_reservas_lower_limit, upper_limit= atencion_reservas_upper_limit)
    
    ingreso_adicional_personas_mean = data['ingreso_adicional_personas_mean']
    ingreso_adicional_personas_range = data['ingreso_adicional_personas_range']
    ingreso_adicional_personas_lower_limit = int(ingreso_adicional_personas_mean) - (int(ingreso_adicional_personas_range))
    ingreso_adicional_personas_upper_limit = int(ingreso_adicional_personas_mean) + (int(ingreso_adicional_personas_range))
    Ingreso_adicional_personas_generator = UniformNumberGenerator(4, LanguajeRandomGenerator(), lower_limit= ingreso_adicional_personas_lower_limit, upper_limit= ingreso_adicional_personas_upper_limit)
   
    Desicion_Retirarse_generator = RandomGeneralNumberGenerator(4,LanguajeRandomGenerator())

   #en Segundos
    llegada_mesa_informes_mean = data['llegada_mesa_informes_mean']
    llegada_mesa_informes_range = data['llegada_mesa_informes_range']
    llegada_mesa_informes_lower_limit = int(llegada_mesa_informes_mean) - (int(llegada_mesa_informes_range))
    llegada_mesa_informes_upper_limit = int(llegada_mesa_informes_mean) + (int(llegada_mesa_informes_range))
    Llegada_mesa_informes_generator = UniformNumberGenerator(4, LanguajeRandomGenerator(), lower_limit= llegada_mesa_informes_lower_limit, upper_limit= llegada_mesa_informes_upper_limit)
   
    llegada_mesa_reservas_mean = data['llegada_mesa_reservas_mean']
    llegada_mesa_reservas_range = data['llegada_mesa_reservas_range']
    llegada_mesa_reservas_lower_limit = int(llegada_mesa_reservas_mean) - (int(llegada_mesa_reservas_range))
    llegada_mesa_reservas_upper_limit = int(llegada_mesa_reservas_mean) + (int(llegada_mesa_reservas_range))
    Llegada_mesa_reservas_generator = UniformNumberGenerator(4, LanguajeRandomGenerator(), lower_limit= llegada_mesa_reservas_lower_limit, upper_limit= llegada_mesa_reservas_upper_limit)
   
    llegada_mesa_reservas_adicional_mean = data['llegada_mesa_reservas_adicional_mean']
    llegada_mesa_reservas_adicional_range = data['llegada_mesa_reservas_adicional_range']
    llegada_mesa_reservas_adicional_lower_limit = int(llegada_mesa_reservas_adicional_mean) - (int(llegada_mesa_reservas_adicional_range))
    llegada_mesa_reservas_adicional_upper_limit = int(llegada_mesa_reservas_adicional_mean) + (int(llegada_mesa_reservas_adicional_range))
    Llegada_mesa_reservas_adicional_generator = UniformNumberGenerator(4, LanguajeRandomGenerator(), lower_limit= llegada_mesa_reservas_adicional_lower_limit, upper_limit= llegada_mesa_reservas_adicional_upper_limit)

    llegada_salida_mean = data['llegada_salida_mean']
    llegada_salida_range = data['llegada_salida_range']
    llegada_salida_lower_limit = int(llegada_salida_mean) - (int(llegada_salida_range))
    llegada_salida_upper_limit = int(llegada_salida_mean) + (int(llegada_salida_range))
    Llegada_salida_generator = UniformNumberGenerator(4, LanguajeRandomGenerator(), lower_limit= llegada_salida_lower_limit, upper_limit= llegada_salida_upper_limit)
   

    

    generators = {}
    generators['Cliente_Arrival'] = Llegada_cliente_generator
    generators['Cliente_Adicional_Arrival'] = Ingreso_adicional_personas_generator
    generators['Operacion_Llegada_Mesa_Informes'] = Llegada_mesa_informes_generator
    generators['Operacion_Informes_Finish'] = Atencion_informes_generator
    generators['Operacion_Llegada_Mesa_Reservas'] = Llegada_mesa_reservas_generator
    generators['Operacion_Reservas_Finish'] = Atencion_reservas_generator
    generators['Operacion_Llegada_Mesa_Reservas_Adicional'] = Llegada_mesa_reservas_adicional_generator
    generators['Operacion_Llegada_Salida'] = Llegada_salida_generator    
    generators['Desicion_Retirarse'] = Desicion_Retirarse_generator

    return generators   

def get_eventos(prev_row):
    eventos = []

    if prev_row['Cliente_arrival'] != None:
        eventos.append(float(prev_row['Cliente_arrival']))

    if prev_row['Cliente_adicional_arrival'] != None:
        eventos.append(float(prev_row['Cliente_adicional_arrival']))
    
    if prev_row['Reservas_directo_arrival'] != None:
        eventos.append(float(prev_row['Reservas_directo_arrival']))

    if prev_row['Informes_arrival'] != None:
        eventos.append(float(prev_row['Informes_arrival']))
    
    if prev_row['Reservas_arrival'] != None:
        eventos.append(float(prev_row['Reservas_arrival']))    
    
    if prev_row['Informes_operacion_finish'] != None:
        eventos.append(float(prev_row['Informes_operacion_finish']))
    
    if prev_row['Reservas_operacion_finish'] != None:
        eventos.append(float(prev_row['Reservas_operacion_finish']))
    
    if prev_row['Salida_arrival_1'] != None:
        eventos.append(float(prev_row['Salida_arrival_1']))
    
    if prev_row['Salida_arrival_2'] != None:
        eventos.append(float(prev_row['Salida_arrival_2']))

    return eventos


def generate_random_numbers(generator, current_time):
    time_between = abs(generator.generate_number())
    random = generator.random_number
    end_time = time_between + current_time
    return random, time_between, end_time

def generate_random_numbers_seg(generator, current_time):
    time_between = abs(generator.generate_number())/60
    random = generator.random_number
    end_time = time_between + current_time
    return random, time_between, end_time


def desicion_retirase(random):

    if random <= 0.60:
        return 'SI'
    else: 
        return 'NO'


def cleanRandoms(current_row):
    current_row['Cliente_arrival_random'] = None
    current_row['Cliente_time_between_arrivals'] = None
    current_row['Cliente_adicional_arrival_random'] = None
    current_row['Cliente_adicional_time_between_arrivals'] = None
    current_row['Cliente_retirarse_random'] = None
    current_row['Cliente_retirarse_desicion'] = '--'
    current_row['Operacion_informes_random'] = None
    current_row['Operacion_informes_time_operation'] = None
    current_row['Operacion_reservas_random'] = None
    current_row['Operacion_reservas_time_operation'] = None
    current_row['Informes_arrival_random'] = None
    current_row['Informes_time_between_arrivals'] = None
    current_row['Reservas_arrival_random'] = None
    current_row['Reservas_time_between_arrivals'] = None
    current_row['Reservas_arrival_directo_random'] = None
    current_row['Reservas_directo_time_between_arrivals'] = None
    current_row['Salida_arrival_random'] = None
    current_row['Salida_time_between_arrivals'] = None


def generate_info(clientes_array, start, end, first):
    info = []
    for i in range(start, len(clientes_array)):
        clientes_info = {}
        cliente = clientes_array[i]
        clientes_info['order'] = cliente.order
        clientes_info['status'] = cliente.status
        
        if cliente.status != 'Destruido' and not first:
            start = i
            first = True
            info.append(clientes_info)
        elif first:
            info.append(clientes_info)
    end = len(clientes_array)
    return info, start, end, first

def generate_info_alternativo(clientes_array):
    info = []
    first = False
    start = 0
    for i in range(len(clientes_array)):
        clientes_info = {}
        cliente = clientes_array[i]
        clientes_info['order'] = cliente.order
        clientes_info['status'] = cliente.status
        
        if cliente.status != 'Destruido' and not first:
            start = i
            first = True
            info.append(clientes_info)
        elif first:
            info.append(clientes_info)
    return info, start

def generate_info_alternativo_last(clientes_array, clientes_headers, last_order):
    info = []
    start = len(clientes_headers)
    for i in range(len(clientes_array)):
        clientes_info = {}
        cliente = clientes_array[i]
        clientes_info['order'] = cliente.order       
        clientes_info['status'] = cliente.status        
        
        if cliente.status != 'Destruido':
            info.append(clientes_info)
            if cliente.order > last_order:
                clientes_headers.append(f'Persona {cliente.order}')
    return info, start, clientes_headers

def simulate(request):
    data = request.POST
    total_clientes_retirados = int(data['total_clientes_retirados'])
    save_since = int(data['from_time'])
    save_until = int(data['from_time']) + int(data['iterations_to_show'])
    generators = create_generators(data)
    resultados = []
    cliente_array = []
    clientes_en_informes = []
    clientes_en_reservas = []
    cliente_yendo_informes = []
    cliente_yendo_reservas = []
    cliente_yendo_reservas_adicional = []
    cliente_yendo_salida = []
    #Inicializacion de parametros
    current_time = 0
    iteration = 0
    start = 0
    end = 0
    first = False
    order = 1
    clientes_headers = []
    first_row = None
    final_row = False
    last_order = 0
    cola_informes = []
    cola_reservas = []

    #Estadisticos
    clientes_retirados = 0

    current_row = {}
    current_row['event_type'] = 'Inicializacion'    
    current_row['current_time'] = current_time
    current_row['iteration'] = iteration

    current_row['Cliente_arrival_random'], current_row['Cliente_time_between_arrivals'], current_row['Cliente_arrival'] = generate_random_numbers(generators['Cliente_Arrival'], current_time)
    
    current_row['Cliente_adicional_arrival_random'], current_row['Cliente_adicional_time_between_arrivals'], current_row['Cliente_adicional_arrival'] = generate_random_numbers(generators['Cliente_Adicional_Arrival'], current_time)
    
    current_row['Cliente_retirarse_random'] = None
    current_row['Cliente_retirarse_desicion'] = "--"
    current_row['Operacion_informes_random'] = None
    current_row['Operacion_informes_time_operation'] = None
    current_row['Informes_operacion_finish'] = None
    current_row['Operacion_reservas_random'] = None
    current_row['Operacion_reservas_time_operation'] = None
    current_row['Reservas_operacion_finish'] = None
    current_row['Informes_arrival_random'] = None
    current_row['Informes_time_between_arrivals'] = None
    current_row['Informes_arrival'] = None
    current_row['Reservas_arrival_random'] = None
    current_row['Reservas_time_between_arrivals'] = None
    current_row['Reservas_arrival'] = None
    current_row['Reservas_arrival_directo_random'] = None
    current_row['Reservas_directo_time_between_arrivals'] = None
    current_row['Reservas_directo_arrival'] = None
    current_row['Salida_arrival_random'] = None
    current_row['Salida_time_between_arrivals'] = None
    current_row['Salida_arrival_1'] = None
    current_row['Salida_arrival_2'] = None
    current_row['Informes_status'] = 'Libre'
    current_row['Cola_informes'] = len(cola_informes)
    current_row['Reservas_status'] = 'Libre'
    current_row['Cola_reservas'] = len(cola_reservas)
    current_row['Clientes_retirados'] = clientes_retirados
    current_row['clientes'], start, end, first = generate_info(cliente_array, start, end, first)  
    resultados.append(current_row)

    #Inicio de iteracion
    while clientes_retirados < total_clientes_retirados:
        prev_row = current_row
        current_row = copy.deepcopy(current_row)
        cleanRandoms(current_row)
        eventos = get_eventos(prev_row)
        iteration +=1
        current_row['iteration'] = iteration
        current_time = min(x for x in eventos if x is not None)
        current_row['current_time'] = current_time



        #Llegada Cliente
        if prev_row['Cliente_arrival'] != None and float(prev_row['Cliente_arrival']) == current_time:
                
                current_row['event_type'] = f'Llegada Persona {order}'
                cliente_nuevo = Cliente(order, "Yendo a Informes")
                cliente_array.append(cliente_nuevo)
                cliente_yendo_informes.append(cliente_nuevo)
                #genera llegada a mesa de Informe                
                current_row['Informes_arrival_random'], current_row['Informes_time_between_arrivals'], current_row['Informes_arrival'] = generate_random_numbers_seg(generators['Operacion_Llegada_Mesa_Informes'], current_time)
                
                if not final_row:
                        clientes_headers.append(f'Persona {order} ')
                        last_order = order
                order+=1

                #genera nueva llegada de cliente
                current_row['Cliente_arrival_random'], current_row['Cliente_time_between_arrivals'], current_row['Cliente_arrival'] = generate_random_numbers(generators['Cliente_Arrival'], current_time)    
                    
        #Llegada Cliente Adicional a Reservas
        elif prev_row['Cliente_adicional_arrival'] != None and float(prev_row['Cliente_adicional_arrival']) == current_time:
                
                current_row['event_type'] = f'Llegada Persona {order} (D)'
                cliente_nuevo = Cliente(order, "Yendo a Reservas")
                cliente_array.append(cliente_nuevo)
                cliente_yendo_reservas_adicional.append(cliente_nuevo)
                #genera llegada a mesa de Reserva directamente              
                current_row['Reservas_arrival_directo_random'], current_row['Reservas_directo_time_between_arrivals'], current_row['Reservas_directo_arrival'] = generate_random_numbers_seg(generators['Operacion_Llegada_Mesa_Reservas_Adicional'], current_time)
                

                if not final_row:
                        clientes_headers.append(f'Persona {order} ')
                        last_order = order
                order+=1

                #genera nueva llegada de cliente adicional
                current_row['Cliente_adicional_arrival_random'], current_row['Cliente_adicional_time_between_arrivals'], current_row['Cliente_adicional_arrival'] = generate_random_numbers(generators['Cliente_Adicional_Arrival'], current_time)    
                    
        #Fin Atencion Infromes
        elif prev_row['Informes_operacion_finish'] != None and float(prev_row['Informes_operacion_finish']) == current_time:
                
                current_row['event_type']= 'Fin Atencion Informes'
                cli_informes = clientes_en_informes.pop(0)
                
                #desidir si va a mesa de Reservas                   
                generators['Desicion_Retirarse'].generate_number()
                random_number= generators['Desicion_Retirarse'].random_number
                desicion_elegida= desicion_retirase(random_number)

                if desicion_elegida == "SI":
                        cli_informes.setStatus('Yendo a la Salida')
                        cliente_yendo_salida.append(cli_informes)
                            #generamos llegada a salida
                        current_row['Salida_arrival_random'], current_row['Salida_time_between_arrivals'], current_row['Salida_arrival_1'] = generate_random_numbers_seg(generators['Operacion_Llegada_Salida'], current_time)
                else:   
                        cli_informes.setStatus('Yendo a Reservas')
                        cliente_yendo_reservas.append(cli_informes)                    
                           #generamos llegada a Mesa de Reservas
                        current_row['Reservas_arrival_random'], current_row['Reservas_time_between_arrivals'], current_row['Reservas_arrival'] = generate_random_numbers_seg(generators['Operacion_Llegada_Mesa_Reservas'], current_time)
                
                current_row['Cliente_retirarse_random'] = random_number
                current_row['Cliente_retirarse_desicion'] = desicion_elegida

                if len(cola_informes) > 0:
                    sig_cliente = cola_informes.pop(0)
                    sig_cliente.setStatus('Atendido en Informes')
                    clientes_en_informes.append(sig_cliente)
                    #genero nueva Atencion en Informes
                    current_row['Operacion_informes_random'], current_row['Operacion_informes_time_operation'], current_row['Informes_operacion_finish'] = generate_random_numbers(generators['Operacion_Informes_Finish'], current_time)
                else:
                    current_row['Informes_status'] = 'Libre'
                    current_row['Informes_operacion_finish'] = None

        #Fin Atencion Reservas
        elif prev_row['Reservas_operacion_finish'] != None and float(prev_row['Reservas_operacion_finish']) == current_time:
                
                current_row['event_type']= 'Fin Atencion Reservas'
                cli_reservas = clientes_en_reservas.pop(0)        
                cli_reservas.setStatus('Yendo a la Salida')
                cliente_yendo_salida.append(cli_reservas)
                 #generamos llegada a salida
                current_row['Salida_arrival_random'], current_row['Salida_time_between_arrivals'], current_row['Salida_arrival_2'] = generate_random_numbers_seg(generators['Operacion_Llegada_Salida'], current_time)
                if len(cola_reservas) > 0:
                    sig_cliente = cola_reservas.pop(0)
                    sig_cliente.setStatus('Atendido en Reservas')
                    clientes_en_reservas.append(sig_cliente)
                    #genero nueva Atencion en Informes
                    current_row['Operacion_reservas_random'], current_row['Operacion_reservas_time_operation'], current_row['Reservas_operacion_finish'] = generate_random_numbers(generators['Operacion_Reservas_Finish'], current_time)
                else:
                    current_row['Reservas_status'] = 'Libre'
                    current_row['Reservas_operacion_finish'] = None
                
        #Llegada a Mesa de Informes
        elif prev_row['Informes_arrival'] != None and float(prev_row['Informes_arrival']) == current_time:
            current_row['event_type']= 'Llegada a Mesa de Informes'
            current_row['Informes_arrival'] = None
            if len(cliente_yendo_informes) > 0:
                cli_yendo_informes = cliente_yendo_informes.pop(0)

            if prev_row['Informes_status'] == 'Libre':
                cli_yendo_informes.setStatus('Atendido en Informes')
                clientes_en_informes.append(cli_yendo_informes)
                current_row['Informes_status'] = 'Ocupado'
                #generamos Atencion en Mesa de Informes
                current_row['Operacion_informes_random'], current_row['Operacion_informes_time_operation'], current_row['Informes_operacion_finish'] = generate_random_numbers(generators['Operacion_Informes_Finish'], current_time)
            else:
                cli_yendo_informes.setStatus('Esperando en Informes')
                cola_informes.append(cli_yendo_informes)
                

        #Llegada a Mesa de Reservas
        elif prev_row['Reservas_arrival'] != None and float(prev_row['Reservas_arrival']) == current_time:
            
            current_row['event_type']= 'Llegada a Mesa de Reservas'
            current_row['Reservas_arrival'] = None
            cli_yendo_reservas = cliente_yendo_reservas.pop(0)

            if prev_row['Reservas_status'] == 'Libre':
                cli_yendo_reservas.setStatus('Atendido en Reservas')
                clientes_en_reservas.append(cli_yendo_reservas)
                current_row['Reservas_status'] = 'Ocupado'
                #generamos Atencion en Mesa de Reservas
                current_row['Operacion_reservas_random'], current_row['Operacion_reservas_time_operation'], current_row['Reservas_operacion_finish'] = generate_random_numbers(generators['Operacion_Reservas_Finish'], current_time)
            else:
                cli_yendo_reservas.setStatus('Esperando en Reservas')
                cola_reservas.append(cli_yendo_reservas)             

        #Llegada a Mesa de Reservas de Cliente Adicional
        elif prev_row['Reservas_directo_arrival'] != None and float(prev_row['Reservas_directo_arrival']) == current_time:
            
            current_row['event_type']= 'Llegada a Mesa de Reservas (Directo)'
            current_row['Reservas_directo_arrival'] = None
            if len(cliente_yendo_reservas_adicional) > 0:
                cli_yendo_reservas = cliente_yendo_reservas_adicional.pop(0)
            
            if prev_row['Reservas_status'] == 'Libre':
                cli_yendo_reservas.setStatus('Atendido en Reservas')
                clientes_en_reservas.append(cli_yendo_reservas)
                current_row['Reservas_status'] = 'Ocupado'
                #generamos Atencion en Mesa de Reservas
                current_row['Operacion_reservas_random'], current_row['Operacion_reservas_time_operation'], current_row['Reservas_operacion_finish'] = generate_random_numbers(generators['Operacion_Reservas_Finish'], current_time)
            else:
                cli_yendo_reservas.setStatus('Esperando en Reservas')
                cola_reservas.append(cli_yendo_reservas)

        #Llegada a la Salida desde Informes
        elif prev_row['Salida_arrival_1'] != None and float(prev_row['Salida_arrival_1']) == current_time:
            current_row['event_type']= 'Llegada a la Salida (desde Informes)'
            cli_yendo_salida = cliente_yendo_salida.pop(0)
            cli_yendo_salida.setStatus('Destruido')
            clientes_retirados += 1
            current_row['Salida_arrival_1'] = None
        
        #Llegada a la Salida desde Reservas
        elif prev_row['Salida_arrival_2'] != None and float(prev_row['Salida_arrival_2']) == current_time:
            current_row['event_type']= 'Llegada a la Salida (desde Reservas)'
            cli_yendo_salida = cliente_yendo_salida.pop(0)
            cli_yendo_salida.setStatus('Destruido')
            clientes_retirados += 1
            current_row['Salida_arrival_2'] = None

       
       

        current_row['Cola_informes'] = len(cola_informes)    
        current_row['Cola_reservas'] = len(cola_reservas)
        current_row['Clientes_retirados'] = clientes_retirados



        #verificar si esta iteracion es para mostrar (rango a mostrar)
        if (iteration >= save_since and iteration <= save_until):
            current_row['clientes'], start = generate_info_alternativo(cliente_array)
            if first_row == None:
                first_row = start
                print(first_row)
                for i in range(first_row):
                    clientes_headers.pop(0)
            current_row['start_clientes'] = start - first_row
            resultados.append(current_row)
        if iteration == save_until:
            final_row = True
        if clientes_retirados == total_clientes_retirados:
            current_row['clientes'], start, clientes_headers = generate_info_alternativo_last(cliente_array, clientes_headers, last_order)
            current_row['start_clientes'] = start
            resultados.append(current_row)
            

    
    

    response_data = dict(
        history = resultados,
        clientes = clientes_headers,        
        total_iterations = iteration,
        clientes_retirados = clientes_retirados,

    )
    return render(request, 'ejercicio236/results.html', response_data)
    

    

from django.shortcuts import render
from generation.number_generator.languaje import LanguajeRandomGenerator
from generation.series_generators.uniform import UniformNumberGenerator
from generation.series_generators.normal import NormalNumberGenerator
from generation.series_generators.RandomGeneral import RandomGeneralNumberGenerator

from generation.series_generators.generator_handler import NumberGeneratorHandler
from Ejercicio53.event_generator_handler import EventGeneratorHandler
from Ejercicio53.handlers.cleaning_handler import CleanEventHandler
from Ejercicio53.handlers.event_handler  import EventHandler
from Ejercicio53.Clientes import Cliente
import copy

# Create your views here.
cant_carriles = 4

def index(request):
    return render(request, 'ejercicio53/index.html', {})


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
    llegada_cliente_deEnSeg = data['llegada_cliente_deviation'] 
    llegada_cliente_deviation = float(llegada_cliente_deEnSeg)/60
    Llegada_cliente_generator = NormalNumberGenerator(4, LanguajeRandomGenerator(), mean= llegada_cliente_mean, standard_deviation= llegada_cliente_deviation)

    duracion_deslizamiento_mean = data['duracion_deslizamiento_mean']
    duracion_deslizamiento_range = data['duracion_deslizamiento_range']
    duracion_deslizamiento_lower_limit = int(duracion_deslizamiento_mean) - (int(duracion_deslizamiento_range))
    duracion_deslizamiento_upper_limit = int(duracion_deslizamiento_mean) + (int(duracion_deslizamiento_range))
    Duracion_deslizamiento_generator = UniformNumberGenerator(4, LanguajeRandomGenerator(), lower_limit= duracion_deslizamiento_lower_limit, upper_limit= duracion_deslizamiento_upper_limit)
   
    Proxima_suspension_constante = data['proxima_suspension_cte']
    proxima_limpieza_cteEnHrs= data['proxima_limpieza_cte']
    Proxima_limpieza_constante = int(proxima_limpieza_cteEnHrs)*60
    Duracion_limpieza_constante = data['duracion_limpieza_cte']

       

    generators = {}
    generators['Cliente_Arrival'] = Llegada_cliente_generator
    generators['Operacion_Deslizada_Finish'] = Duracion_deslizamiento_generator
    generators['Operacion_Llegada_Suspension'] = Proxima_suspension_constante
    generators['Operacion_Llegada_Limpieza'] = Proxima_limpieza_constante
    generators['Operacion_Limpieza_Finish'] = Duracion_limpieza_constante
    

    return generators   

def get_eventos(prev_row):
    eventos = []

    if prev_row['Cliente_arrival'] != None:
        eventos.append(float(prev_row['Cliente_arrival']))
    
    if prev_row['Suspension_arrival'] != None:
        eventos.append(float(prev_row['Suspension_arrival']))

    if prev_row['Limpieza_arrival'] != None:
        eventos.append(float(prev_row['Limpieza_arrival']))
    
    if prev_row['Limpieza_operacion_finish'] != None:
        eventos.append(float(prev_row['Limpieza_operacion_finish']))

    for i in range(cant_carriles):
        if prev_row[f'Deslizada_operacion_finish_{(i+1)}'] != None:
            eventos.append(float(prev_row[f'Deslizada_operacion_finish_{(i+1)}']))    
    
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



def cleanRandoms(current_row):
    current_row['Cliente_arrival_random'] = None
    current_row['Cliente_time_between_arrivals'] = None
    current_row['Operacion_deslizada_random'] = None
    current_row['Operacion_deslizada_time_operation'] = None
    current_row['Tiempo_espera'] = None


def generate_info(clientes_array, start, end, first):
    info = []
    for i in range(start, len(clientes_array)):
        clientes_info = {}
        cliente = clientes_array[i]
        clientes_info['order'] = cliente.order
        clientes_info['hora_llegada'] = cliente.hora_llegada
        clientes_info['numero_carril'] = cliente.carril 
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
        clientes_info['hora_llegada'] = cliente.hora_llegada
        clientes_info['numero_carril'] = cliente.carril 
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
        clientes_info['hora_llegada'] = cliente.hora_llegada
        clientes_info['numero_carril'] = cliente.carril     
        clientes_info['status'] = cliente.status        
        
        if cliente.status != 'Destruido':
            info.append(clientes_info)
            if cliente.order > last_order:
                clientes_headers.append(f'Persona {cliente.order}')
    return info, start, clientes_headers

def simulate(request):
    data = request.POST
    total_iterations = int(data['total_iterations'])
    save_since = int(data['from_time'])
    save_until = int(data['from_time']) + int(data['iterations_to_show'])
    generators = create_generators(data)
    resultados = []
    cliente_array = []
    clientes_deslizandose = []
    aviso_limpieza = False
    inicio_limpieza = False
    stop_suspension = False
    
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
    cola = []
    

    #Estadisticos
    tamano_cola_maxima = 0
    tiempo_espera_cola_maxima = 0
    personas_deslizadas = 0

    current_row = {}
    current_row['event_type'] = 'Inicializacion'    
    current_row['current_time'] = current_time
    current_row['iteration'] = iteration

    current_row['Cliente_arrival_random'], current_row['Cliente_time_between_arrivals'], current_row['Cliente_arrival'] = generate_random_numbers(generators['Cliente_Arrival'], current_time)
    
    current_row['Suspension_arrival'] = float(current_time + int(generators['Operacion_Llegada_Suspension']))
    current_row['Limpieza_arrival'] = float(current_time + int(generators['Operacion_Llegada_Limpieza']))
    current_row['Limpieza_operacion_finish'] = None
    current_row['Operacion_deslizada_random'] = None
    current_row['Operacion_deslizada_time_operation'] = None
    current_row['Cola'] = len(cola)

    for i in range(cant_carriles):
        current_row[f'Deslizada_operacion_finish_{(i+1)}'] = None
        current_row[f'Carril_status_{(i+1)}'] = 'Libre'
    
    
    current_row['Tiempo_espera'] = None
    current_row['Tiempo_espera_maxima'] = tiempo_espera_cola_maxima
    current_row['Tamano_cola_maxima'] = tamano_cola_maxima    
    current_row['Personas_deslizadas'] = personas_deslizadas

    current_row['clientes'], start, end, first = generate_info(cliente_array, start, end, first)  
    resultados.append(current_row)

    """ def proximaPersonaADeslizarse (carril):
        if len(cola) > 0:
                sig_cliente= cola.pop(0)
                sig_cliente.setStatusDeslizar(carril,'Operando')
                clientes_deslizandose.append(sig_cliente)
                tiempo_espera = (current_time - sig_cliente.hora_llegada)
                    
                if tiempo_espera >= tiempo_espera_cola_maxima:
                    tiempo_espera_cola_maxima = tiempo_espera
                    
                current_row['Operacion_deslizada_random'], current_row['Operacion_deslizada_time_operation'], current_row[f'Deslizada_operacion_finish_{carril}'] = generate_random_numbers(generators['Operacion_Deslizada_Finish'], current_time)

        else:
                current_row[f'Carril_status_{carril}'] = 'Libre'
                current_row[f'Deslizada_operacion_finish_{carril}'] = None """

    #Inicio de iteracion
    for i in range(total_iterations):
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
                carril_disponible = None

                for i in range(cant_carriles):
                    if prev_row[f'Carril_status_{(i+1)}'] == 'Libre':
                        carril_disponible = (i+1)
                        break
                
                if  carril_disponible == None:
                        cliente_nuevo = Cliente(order, current_time, None, "Esperando")
                        cliente_array.append(cliente_nuevo)
                        cola.append(cliente_nuevo)   
                        if len(cola) >= tamano_cola_maxima:
                            tamano_cola_maxima = len(cola)
                                     
                else:
                    #utiliza el carril
                    cliente_nuevo = Cliente(order, current_time, carril_disponible, "Deslizandose")
                    cliente_array.append(cliente_nuevo)
                    clientes_deslizandose.append(cliente_nuevo)             
                    tiempo_espera = (current_time - cliente_nuevo.hora_llegada)

                    if tiempo_espera >= tiempo_espera_cola_maxima:
                        tiempo_espera_cola_maxima = tiempo_espera

                    current_row['Operacion_deslizada_random'], current_row['Operacion_deslizada_time_operation'], current_row[f'Deslizada_operacion_finish_{carril_disponible}'] = generate_random_numbers(generators['Operacion_Deslizada_Finish'], current_time)
                    current_row[f'Carril_status_{carril_disponible}'] = "Ocupado"

                    current_row['Tamano_cola_maxima'] = tamano_cola_maxima
                    current_row['Tiempo_espera_maxima'] = tiempo_espera_cola_maxima

                if not final_row:
                        clientes_headers.append(f'Persona {order} ')
                        last_order = order
                order+=1

                #genera nueva llegada de cliente
                current_row['Cliente_arrival_random'], current_row['Cliente_time_between_arrivals'], current_row['Cliente_arrival'] = generate_random_numbers(generators['Cliente_Arrival'], current_time)    
                    
        #Llegada Suspension de Alfombra Magica
        elif aviso_limpieza == False and prev_row['Suspension_arrival'] != None and float(prev_row['Suspension_arrival']) == current_time:
                
                current_row['event_type']= 'Llegada Suspension de Alfombra Magica'
                current_row['Suspension_arrival'] = None

                for i in range(cant_carriles):
                    current_row[f'Carril_status_{(i+1)}'] = 'Suspendido'

              

        #Llegada Limpieza de Alfombra Magica
        elif prev_row['Limpieza_arrival'] != None and float(prev_row['Limpieza_arrival']) == current_time:
                
                aviso_limpieza = True
                current_row['event_type']= 'Aviso de Limpieza de Alfombra Magica'
                current_row['Limpieza_arrival'] = None

                for i in range(cant_carriles):
                    current_row[f'Carril_status_{(i+1)}'] = 'Suspendido por Limpieza'

        #Fin Limpieza de Alfombra Magica
        elif prev_row['Limpieza_operacion_finish'] != None and float(prev_row['Limpieza_operacion_finish']) == current_time:
                
                aviso_limpieza = False
                inicio_limpieza = False
                stop_suspension = False
                

                current_row['event_type']= 'Fin Limpieza de Alfombra Magica'
                current_row['Limpieza_operacion_finish'] = None
                current_row['Limpieza_arrival'] = current_time + float(generators['Operacion_Llegada_Limpieza'])
                current_row['Suspension_arrival'] = current_time + float(generators['Operacion_Llegada_Suspension'])

                for i in range(cant_carriles):
                    if len(cola) > 0:
                        sig_cliente= cola.pop(0)
                        sig_cliente.setStatusDeslizar((i+1),'Deslizandose')
                        clientes_deslizandose.append(sig_cliente)
                        tiempo_espera = (current_time - sig_cliente.hora_llegada)
                    
                        if tiempo_espera >= tiempo_espera_cola_maxima:
                            tiempo_espera_cola_maxima = tiempo_espera

                        current_row[f'Carril_status_{(i+1)}'] = 'Ocupado'
                        current_row['Operacion_deslizada_random'], current_row['Operacion_deslizada_time_operation'], current_row[f'Deslizada_operacion_finish_{(i+1)}'] = generate_random_numbers(generators['Operacion_Deslizada_Finish'], current_time)

                    else:
                        current_row[f'Carril_status_{(i+1)}'] = 'Libre'
                        current_row[f'Deslizada_operacion_finish_{(i+1)}'] = None

                    #proximaPersonaADeslizarse(i+1)

        #A la llegada de Suspension de Limpieza, el evento de suspension simple de la Alfombra no se manifesta            
        if aviso_limpieza == True and stop_suspension == False:            
            
            current_row['Suspension_arrival'] = None
            stop_suspension = True

        carril_elegido = []
        for i in range(cant_carriles):
            if prev_row[f'Deslizada_operacion_finish_{(i+1)}'] != None and float(prev_row[f'Deslizada_operacion_finish_{(i+1)}']) == current_time:
                carril_elegido.append(i+1)

        if len(carril_elegido) > 0:
            for c in carril_elegido:

            #registrando el Fin de Deslizada del Carril
                current_row['event_type'] = f'Fin Deslizada Carril {c}'
                current_row[f'Deslizada_operacion_finish_{c}'] = None
                personas_deslizadas += 1

                for cli in clientes_deslizandose:
                    if  cli.carril == c and cli.status == 'Deslizandose':
                        cli.setStatus('Destruido')
                        clientes_deslizandose.remove(cli)                    
                
                #Verificando si hay clientes en la cola y si no esta suspendido 
                if prev_row[f'Carril_status_{c}'] == 'Ocupado':
                    if len(cola) > 0:
                        sig_cliente= cola.pop(0)
                        sig_cliente.setStatusDeslizar(c,'Deslizandose')
                        clientes_deslizandose.append(sig_cliente)
                        tiempo_espera = (current_time - sig_cliente.hora_llegada)
                    
                        if tiempo_espera >= tiempo_espera_cola_maxima:
                            tiempo_espera_cola_maxima = tiempo_espera
                        
                        current_row['Operacion_deslizada_random'], current_row['Operacion_deslizada_time_operation'], current_row[f'Deslizada_operacion_finish_{c}'] = generate_random_numbers(generators['Operacion_Deslizada_Finish'], current_time)

                    else:
                        current_row[f'Carril_status_{c}'] = 'Libre'
                        current_row[f'Deslizada_operacion_finish_{c}'] = None
                carril_elegido.remove(c)
        carril_elegido.clear()

       

        #Verificar cuando se termina la Suspension de la Alfombra Magica
        carriles_suspendidos = []
        
        for i in range(cant_carriles):
            if prev_row[f'Carril_status_{(i+1)}'] == 'Suspendido':
                carriles_suspendidos.append(i+1)

        if len(carriles_suspendidos) > 0:
            if len(carriles_suspendidos) == cant_carriles and len(clientes_deslizandose) == 0:
                current_row['event_type'] += ' - Fin Suspension de Alfombra Magica'
                current_row['Suspension_arrival'] = current_time + int(generators['Operacion_Llegada_Suspension'])
                for i in range(cant_carriles):
                    #proximaPersonaADeslizarse(i+1)
                    if len(cola) > 0:
                        sig_cliente= cola.pop(0)
                        sig_cliente.setStatusDeslizar((i+1),'Deslizandose')
                        clientes_deslizandose.append(sig_cliente)
                        tiempo_espera = (current_time - sig_cliente.hora_llegada)
                    
                        if tiempo_espera >= tiempo_espera_cola_maxima:
                            tiempo_espera_cola_maxima = tiempo_espera

                        current_row[f'Carril_status_{(i+1)}'] = 'Ocupado'
                        current_row['Operacion_deslizada_random'], current_row['Operacion_deslizada_time_operation'], current_row[f'Deslizada_operacion_finish_{(i+1)}'] = generate_random_numbers(generators['Operacion_Deslizada_Finish'], current_time)

                    else:
                        current_row[f'Carril_status_{(i+1)}'] = 'Libre'
                        current_row[f'Deslizada_operacion_finish_{(i+1)}'] = None
        carriles_suspendidos.clear()

        #Verificar si esta vacia la Alfombra Magica para comenzar la limpieza        
        for i in range(cant_carriles):
            if prev_row[f'Carril_status_{(i+1)}'] == 'Suspendido por Limpieza':
                carriles_suspendidos.append(i+1)
        
        if len(carriles_suspendidos) > 0:
            if len(carriles_suspendidos) == cant_carriles and len(clientes_deslizandose) == 0 and inicio_limpieza == False:
                inicio_limpieza = True
                current_row['event_type'] += ' - Inicio Limpieza de Alfombra Magica'
                current_row['Limpieza_operacion_finish'] = current_time + int(generators['Operacion_Limpieza_Finish'])
        carriles_suspendidos.clear()
       
       
        current_row['Tamano_cola_maxima'] = tamano_cola_maxima
        current_row['Tiempo_espera'] = tiempo_espera
        current_row['Tiempo_espera_maxima'] = tiempo_espera_cola_maxima
        current_row['Cola'] = len(cola)
        current_row['Personas_deslizadas'] = personas_deslizadas



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
        if iteration == total_iterations:
            current_row['clientes'], start, clientes_headers = generate_info_alternativo_last(cliente_array, clientes_headers, last_order)
            current_row['start_clientes'] = start
            resultados.append(current_row)
            

    #calculo Resultados
    if personas_deslizadas > 0:
        uso_promedio_sistema_min = current_time / personas_deslizadas
        uso_promedio_sistema_hrs = uso_promedio_sistema_min / 60
    else:
        uso_promedio_sistema_min = 0
        uso_promedio_sistema_hrs = 0

    if tiempo_espera_cola_maxima > 0:
        tiempo_espera_cola_maxima_hrs = tiempo_espera_cola_maxima / 60
    else :
        tiempo_espera_cola_maxima_hrs = 0
    

    response_data = dict(
        history = resultados,
        clientes = clientes_headers,        
        total_iterations = iteration,
        carriles =cant_carriles,
        uso_promedio_sistema_min = uso_promedio_sistema_min,
        uso_promedio_sistema_hrs = uso_promedio_sistema_hrs,
        personas_deslizadas = personas_deslizadas,
        tamano_cola_maxima = tamano_cola_maxima,
        tiempo_espera_cola_maxima = tiempo_espera_cola_maxima,
        tiempo_espera_cola_maxima_hrs = tiempo_espera_cola_maxima_hrs

    )
    return render(request, 'ejercicio53/results.html', response_data)
    

    

from django.shortcuts import render
from generation.number_generator.languaje import LanguajeRandomGenerator
from generation.series_generators.uniform import UniformNumberGenerator
from generation.series_generators.exponential import ExponentialNumberGenerator

from generation.series_generators.generator_handler import NumberGeneratorHandler
from Ejercicio49.event_generator_handler import EventGeneratorHandler
from Ejercicio49.handlers.cleaning_handler import CleanEventHandler
from Ejercicio49.handlers.event_handler  import EventHandler
from Ejercicio49.Clientes import Cliente
import copy

# Create your views here.

def index(request):
    return render(request, 'ejercicio49/index.html', {})


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
    
    
    llegada_cliente_frecuencia = float(int(data['llegada_cliente_mean'])/60)
    llegada_cliente_mean = 1/llegada_cliente_frecuencia
    Llegada_cliente_generator = ExponentialNumberGenerator(4, LanguajeRandomGenerator(), mean=llegada_cliente_mean)

    diracion_llamada_mean = data['diracion_llamada_mean']
    diracion_llamada_range = data['diracion_llamada_range']
    diracion_llamada_lower_limit = int(diracion_llamada_mean) - (int(diracion_llamada_range))
    diracion_llamada_upper_limit = int(diracion_llamada_mean) + (int(diracion_llamada_range))
    Diracion_llamada_generator = UniformNumberGenerator(4, LanguajeRandomGenerator(), lower_limit= diracion_llamada_lower_limit, upper_limit= diracion_llamada_upper_limit)

    Llegada_cabina_generator = float(int(data['llegada_cabina'])/60)
   
    Finalizar_cobro_generator = float(int(data['duracion_cobro'])/60)

    

    generators = {}
    generators['Cliente_Arrival'] = Llegada_cliente_generator
    generators['Cabina_Arrival'] = Llegada_cabina_generator
    generators['Operacion_Llamada_Finish'] = Diracion_llamada_generator
    generators['Operacion_Cobro_Finish'] = Finalizar_cobro_generator

    return generators   

def get_eventos(prev_row):
    eventos = []

    if prev_row['Cliente_arrival'] != None:
        eventos.append(float(prev_row['Cliente_arrival']))

    
    if prev_row['Cabina_arrival_1'] != None:
        eventos.append(float(prev_row['Cabina_arrival_1']))

    if prev_row['Cabina_arrival_2'] != None:
        eventos.append(float(prev_row['Cabina_arrival_2']))
    
    if prev_row['Llamada_1_operacion_finish'] != None:
        eventos.append(float(prev_row['Llamada_1_operacion_finish']))
    
    if prev_row['Llamada_2_operacion_finish'] != None:
        eventos.append(float(prev_row['Llamada_2_operacion_finish']))
    
    if prev_row['Cobro_operacion_finish'] != None:
        eventos.append(float(prev_row['Cobro_operacion_finish']))

    return eventos


def generate_random_numbers(generator, current_time):
    time_between = abs(generator.generate_number())
    random = generator.random_number
    end_time = time_between + current_time
    return random, time_between, end_time



def cleanRandoms(current_row):
    current_row['Cliente_arrival_random'] = None
    current_row['Cliente_time_between_arrivals'] = None    
    current_row['Cabina_arrival_time_operation'] = None
    current_row['Operacion_llamadas_random'] = None
    current_row['Operacion_cobro_time_operation'] = None
    


def generate_info(clientes_array, start, end, first):
    info = []
    for i in range(start, len(clientes_array)):
        clientes_info = {}
        cliente = clientes_array[i]
        clientes_info['order'] = cliente.order
        clientes_info['duracionLlamada'] = cliente.duracionLlamada
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
        clientes_info['duracionLlamada'] = cliente.duracionLlamada
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
        clientes_info['duracionLlamada'] = cliente.duracionLlamada       
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
    cliente_yendo_cabina = []
    cliente_en_cabina= []
    cliente_pagando = []
    

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
    cola_caja = []
    

    #Estadisticos
    personas_no_consiguen_cabina = 0
    personas_totales = 0
    porcentaje_personas_no_consiguen_cabina = 0

    max_cola_caja = 0

    tiempo_llamadas_AC = 0
    cant_llamadas = 0
    tiempo_promedio_llamadas = 0

    dinero_total_caja = 0
    ganancia_neta = 0


    current_row = {}
    current_row['event_type'] = 'Inicializacion'    
    current_row['current_time'] = current_time
    current_row['iteration'] = iteration

    current_row['Cliente_arrival_random'], current_row['Cliente_time_between_arrivals'], current_row['Cliente_arrival'] = generate_random_numbers(generators['Cliente_Arrival'], current_time)
    
    current_row['Cabina_arrival_time_operation'] = None
    current_row['Operacion_llamadas_random'] = None
    current_row['Cabina_arrival_1'] = None
    current_row['Operacion_llamada_time_operation_1'] = None
    current_row['Llamada_1_operacion_finish'] = None
    current_row['Cabina_1_status'] = 'Libre'
    current_row['Cabina_arrival_2'] = None
    current_row['Operacion_llamada_time_operation_2'] = None
    current_row['Llamada_2_operacion_finish'] = None
    current_row['Cabina_2_status'] = 'Libre'

    current_row['Operacion_cobro_time_operation'] = None
    current_row['Cobro_operacion_finish'] = None
    current_row['Cobro_costo_llamada'] = None
    current_row['Caja_status'] = 'Libre'
    current_row['Cola_caja'] = len(cola_caja)   
    
    current_row['Personas_no_consiguen_cabina'] = personas_no_consiguen_cabina
    current_row['Personas_totales'] = personas_totales
    current_row['Porcentaje_personas_no_consiguen_cabina'] = porcentaje_personas_no_consiguen_cabina
    current_row['Cola_maxima_caja'] = max_cola_caja
    current_row['Llamada_duracion_AC'] = tiempo_llamadas_AC
    current_row['Cantidad_llamadas'] = cant_llamadas
    current_row['Tiempo_promedio_llamadas'] = tiempo_promedio_llamadas
    current_row['Dinero_total_caja'] = dinero_total_caja
    current_row['Ganancia_neta'] = ganancia_neta

    current_row['clientes'], start, end, first = generate_info(cliente_array, start, end, first)  
    resultados.append(current_row)

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
                                
                #ver si esta diponible alguna cabina
                cabina_disponible = None
                for i in range(2):
                    if current_row[f'Cabina_{(i+1)}_status'] == 'Libre':
                        cabina_disponible = (i+1)
                        break

                if  cabina_disponible == None:
                    #La Persona se retira sin poder usar ninguna cabina
                    cliente_nuevo = Cliente(order, None, "Destruido")
                    cliente_array.append(cliente_nuevo)
                    personas_no_consiguen_cabina += 1
                else:
                    #va a la cabina que esta disponible
                    cliente_nuevo = Cliente(order, None, f"Yendo a Cabina {cabina_disponible}")
                    cliente_array.append(cliente_nuevo)
                    cliente_yendo_cabina.append(cliente_nuevo)
                    current_row['Cabina_arrival_time_operation'] = generators['Cabina_Arrival']
                    current_row[f'Cabina_arrival_{cabina_disponible}'] = current_time + generators['Cabina_Arrival']
                    current_row[f'Cabina_{cabina_disponible}_status'] = 'Ocupado'

                personas_totales += 1

                if not final_row:
                        clientes_headers.append(f'Persona {order} ')
                        last_order = order
                order+=1

                #genera nueva llegada de cliente
                current_row['Cliente_arrival_random'], current_row['Cliente_time_between_arrivals'], current_row['Cliente_arrival'] = generate_random_numbers(generators['Cliente_Arrival'], current_time)    
                    
        #Llegada a Cabina 1 
        elif prev_row['Cabina_arrival_1'] != None and float(prev_row['Cabina_arrival_1']) == current_time:

            current_row['event_type']= 'Persona Llega a Cabina 1'
            current_row['Cabina_arrival_1'] = None

            personaCabina = None

            for cli in cliente_yendo_cabina:
                    if  cli.status == 'Yendo a Cabina 1':
                        personaCabina = cli
                        cliente_yendo_cabina.remove(cli)
            
            if personaCabina != None:
                personaCabina.setStatus('Hablando en Cabina 1')
                cliente_en_cabina.append(personaCabina)
                
                #Inicia la LLamada
                current_row['Operacion_llamadas_random'], current_row['Operacion_llamada_time_operation_1'], current_row['Llamada_1_operacion_finish'] = generate_random_numbers(generators['Operacion_Llamada_Finish'], current_time) 

        #Llegada a Cabina 2 
        elif prev_row['Cabina_arrival_2'] != None and float(prev_row['Cabina_arrival_2']) == current_time:

            current_row['event_type']= 'Persona Llega a Cabina 2'
            current_row['Cabina_arrival_2'] = None

            personaCabina = None

            for cli in cliente_yendo_cabina:
                    if  cli.status == 'Yendo a Cabina 2':
                        personaCabina = cli
                        cliente_yendo_cabina.remove(cli)
            
            if personaCabina != None:
                personaCabina.setStatus('Hablando en Cabina 2')
                cliente_en_cabina.append(personaCabina)
                
                #Inicia la LLamada
                current_row['Operacion_llamadas_random'], current_row['Operacion_llamada_time_operation_2'], current_row['Llamada_2_operacion_finish'] = generate_random_numbers(generators['Operacion_Llamada_Finish'], current_time) 

        #Fin Llamada Cabina 1
        elif prev_row['Llamada_1_operacion_finish'] != None and float(prev_row['Llamada_1_operacion_finish']) == current_time:
            
            current_row['event_type']= 'Finalizacion de Llamada en Cabina 1'
            current_row['Llamada_1_operacion_finish']= None

            personaLlamada = None

            for cli in cliente_en_cabina:
                    if  cli.status == 'Hablando en Cabina 1':
                        personaLlamada = cli
                        cliente_en_cabina.remove(cli)
            
            #Me fijo si esta libre la caja para cobrar la llamada
            if personaLlamada != None:
                    if current_row['Caja_status'] == 'Libre':
                    
                        current_row['Operacion_cobro_time_operation'] = generators['Operacion_Cobro_Finish']
                        current_row['Cobro_operacion_finish'] = current_time + generators['Operacion_Cobro_Finish']
                        current_row['Caja_status'] = 'Ocupado'

                        #Calculo el costo de la llamada
                        if current_row['Operacion_llamada_time_operation_1'] <= 5:
                            current_row['Cobro_costo_llamada'] = 50
                        else: 
                            segundosExtra = float (current_row['Operacion_llamada_time_operation_1'] - 5)
                            current_row['Cobro_costo_llamada'] = 50 + (segundosExtra * 6 * 2)
                        
                        personaLlamada.setStatus('Pagando Llamada')
                        cliente_pagando.append(personaLlamada)
                    else:
                        personaLlamada.setStatus('Esperando a Pagar')
                        personaLlamada.setDuracionLlamada( float (current_row['Operacion_llamada_time_operation_1']) )
                        cola_caja.append(personaLlamada)
                        
                    #Liberar Cabina
                    current_row['Cabina_1_status'] = 'Libre'

                    #estadisticas para ver la duracion promedio de las llamadas
                    tiempo_llamadas_AC += current_row['Operacion_llamada_time_operation_1']
                    cant_llamadas += 1
                    current_row['Operacion_llamada_time_operation_1'] = None
        

        #Fin Llamada Cabina 2
        elif prev_row['Llamada_2_operacion_finish'] != None and float(prev_row['Llamada_2_operacion_finish']) == current_time:
            
            current_row['event_type']= 'Finalizacion de Llamada en Cabina 2'
            current_row['Llamada_2_operacion_finish']= None

            personaLlamada = None

            for cli in cliente_en_cabina:
                    if  cli.status == 'Hablando en Cabina 2':
                        personaLlamada = cli
                        cliente_en_cabina.remove(cli)
            
            #Me fijo si esta libre la caja para cobrar la llamada
            if personaLlamada != None:
                    if current_row['Caja_status'] == 'Libre':
                    
                        current_row['Operacion_cobro_time_operation'] = generators['Operacion_Cobro_Finish']
                        current_row['Cobro_operacion_finish'] = current_time + generators['Operacion_Cobro_Finish']
                        current_row['Caja_status'] = 'Ocupado'

                        #Calculo el costo de la llamada
                        if current_row['Operacion_llamada_time_operation_2'] <= 5:
                            current_row['Cobro_costo_llamada'] = 50
                        else: 
                            segundosExtra = float (current_row['Operacion_llamada_time_operation_2'] - 5)
                            current_row['Cobro_costo_llamada'] = 50 + (segundosExtra * 6 * 2)
                        
                        personaLlamada.setStatus('Pagando Llamada')
                        cliente_pagando.append(personaLlamada)
                    else:
                        personaLlamada.setStatus('Esperando a Pagar')
                        personaLlamada.setDuracionLlamada( float (current_row['Operacion_llamada_time_operation_2']) )
                        cola_caja.append(personaLlamada)
                        
                    #Liberar Cabina
                    current_row['Cabina_2_status'] = 'Libre'

                    #estadisticas para ver la duracion promedio de las llamadas
                    tiempo_llamadas_AC += current_row['Operacion_llamada_time_operation_2']
                    cant_llamadas += 1
                    current_row['Operacion_llamada_time_operation_2'] = None


        #Finalizar cobro Llamada
        elif prev_row['Cobro_operacion_finish'] != None and float(prev_row['Cobro_operacion_finish']) == current_time:
             
            current_row['event_type']= 'Finalizacion de Cobro de Llamada'
            dinero_total_caja += current_row['Cobro_costo_llamada']            
            current_row['Cobro_operacion_finish']= None            
            current_row['Cobro_costo_llamada'] = None

            clienteCaja = cliente_pagando.pop(0)
            clienteCaja.setStatus("Destruido")
            
            #me fijo si hay personas en la cola
            if len(cola_caja) > 0:
                personaEnCola = cola_caja.pop(0)
                personaEnCola.setStatus('Pagando Llamada')
                cliente_pagando.append(personaEnCola)

                current_row['Operacion_cobro_time_operation'] = generators['Operacion_Cobro_Finish']
                current_row['Cobro_operacion_finish'] = current_time + generators['Operacion_Cobro_Finish']

                #Calculo el costo de la llamada
                if personaEnCola.duracionLlamada <= 5:
                    current_row['Cobro_costo_llamada'] = 50
                else: 
                    segundosExtra = float (personaEnCola.duracionLlamada - 5)
                    current_row['Cobro_costo_llamada'] = 50 + (segundosExtra * 6 * 2)
            else:
               #Libero caja si no hay nadie en la cola
               current_row['Caja_status'] = 'Libre'               
  




        #calcular Porcentaje de personas que no usaron la cabina:
        if personas_totales > 0:
             porcentaje_personas_no_consiguen_cabina = personas_no_consiguen_cabina * 100 / personas_totales

        #calcular el maximo del tamaño de cola:
        if len(cola_caja) > max_cola_caja:
            max_cola_caja = len(cola_caja)
        
        #Calcular la duracion promedio de las llamadas:
        if cant_llamadas > 0:
             tiempo_promedio_llamadas = tiempo_llamadas_AC/cant_llamadas
        
        #calcular la ganancia neta del locutorio:
        ganancia_neta = dinero_total_caja - (50 * personas_no_consiguen_cabina)
        
        

       
       
        current_row['Cola_caja'] = len(cola_caja)    
        current_row['Personas_no_consiguen_cabina'] = personas_no_consiguen_cabina
        current_row['Personas_totales'] = personas_totales
        current_row['Porcentaje_personas_no_consiguen_cabina'] = porcentaje_personas_no_consiguen_cabina
        current_row['Cola_maxima_caja'] = max_cola_caja
        current_row['Llamada_duracion_AC'] = tiempo_llamadas_AC
        current_row['Cantidad_llamadas'] = cant_llamadas
        current_row['Tiempo_promedio_llamadas'] = tiempo_promedio_llamadas
        current_row['Dinero_total_caja'] = dinero_total_caja
        current_row['Ganancia_neta'] = ganancia_neta



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
            

    
    

    response_data = dict(
        history = resultados,
        clientes = clientes_headers,        
        total_iterations = total_iterations,
        porcentaje_personas_no_consiguen_cabina = porcentaje_personas_no_consiguen_cabina,
        max_cola_caja = max_cola_caja,
        tiempo_promedio_llamadas = tiempo_promedio_llamadas,
        dinero_total_caja = dinero_total_caja,
        ganancia_neta = ganancia_neta

    )
    return render(request, 'ejercicio49/results.html', response_data)
    

    

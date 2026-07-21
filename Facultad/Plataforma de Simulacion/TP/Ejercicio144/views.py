from django.shortcuts import render
from generation.number_generator.languaje import LanguajeRandomGenerator
from generation.series_generators.uniform import UniformNumberGenerator
from generation.series_generators.exponential import ExponentialNumberGenerator
from generation.series_generators.RandomGeneral import RandomGeneralNumberGenerator

from generation.series_generators.generator_handler import NumberGeneratorHandler
from Ejercicio144.event_generator_handler import EventGeneratorHandler
from Ejercicio144.handlers.cleaning_handler import CleanEventHandler
from Ejercicio144.handlers.event_handler  import EventHandler
from Ejercicio144.Clientes import Cliente
import copy

# Create your views here.
cant_cajeros = 4

def index(request):
    return render(request, 'ejercicio144/index.html', {})


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

    operacion_cajero_mean = data['operacion_cajero_mean']
    operacion_cajero_range = data['operacion_cajero_range']
    operacion_cajero_lower_limit = int(operacion_cajero_mean) - (int(operacion_cajero_range))
    operacion_cajero_upper_limit = int(operacion_cajero_mean) + (int(operacion_cajero_range))
    Operacion_cajero_generator = UniformNumberGenerator(4, LanguajeRandomGenerator(), lower_limit= operacion_cajero_lower_limit, upper_limit= operacion_cajero_upper_limit)
   
    llegada_cliente_mean = data['llegada_cliente_mean']
    Llegada_cliente_generator = ExponentialNumberGenerator(4,LanguajeRandomGenerator(), mean=llegada_cliente_mean)

    Desicion_Espera_generator = RandomGeneralNumberGenerator(4,LanguajeRandomGenerator())

    generators = {}
    generators['Operacion_Cajero_Finish'] = Operacion_cajero_generator
    generators['Cliente_Arrival'] = Llegada_cliente_generator
    generators['Desicion_Espera'] = Desicion_Espera_generator

    return generators   

def get_eventos(prev_row):
    eventos = []
    if prev_row['Cliente_arrival'] != None:
        eventos.append(float(prev_row['Cliente_arrival']))
    for i in range(cant_cajeros):
        if prev_row[f'cajero_operacion_finish_{(i+1)}'] != None:
            eventos.append(float(prev_row[f'cajero_operacion_finish_{(i+1)}']))
    return eventos


def generate_random_numbers(generator, current_time):
    time_between = abs(generator.generate_number())
    random = generator.random_number
    end_time = time_between + current_time
    return random, time_between, end_time


def desicion_espera(random, tamanio_cola) :

    porc_desicion = None
    
    if (3<= tamanio_cola and tamanio_cola <=6):
        porc_desicion = 0.10
    elif (7<= tamanio_cola and tamanio_cola <=10):
        porc_desicion = 0.20
    elif (11<= tamanio_cola and tamanio_cola <=15):
        porc_desicion = 0.40
    elif (16<= tamanio_cola):
        porc_desicion = 0.80

    if porc_desicion == None:
        return 'SI'
    else:
        if random <= porc_desicion:
            return 'NO'
        else: 
            return 'SI'


def cleanRandoms(current_row):
    current_row['Operacion_Cajero_random'] = None
    current_row['Operacion_Cajero_time_operation'] = None
    current_row['Cliente_arrival_random'] = None
    current_row['Cliente_time_between_arrivals'] = None
    current_row['Cliente_wait_random'] = None
    current_row['Cliente_wait_desicion'] = '--'


def generate_info(clientes_array, start, end, first):
    info = []
    for i in range(start, len(clientes_array)):
        clientes_info = {}
        cliente = clientes_array[i]
        clientes_info['order'] = cliente.order        
        clientes_info['hora_llegada'] = cliente.hora_llegada
        clientes_info['numero_cajero'] = cliente.nro_cajero
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
        clientes_info['numero_cajero'] = cliente.nro_cajero
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
        clientes_info['status'] = cliente.status
        clientes_info['numero_cajero'] = cliente.nro_cajero
        
        if cliente.status != 'Destruido':
            info.append(clientes_info)
            if cliente.order > last_order:
                clientes_headers.append(f'Cliente {cliente.order}')
    return info, start, clientes_headers

def simulate(request):
    data = request.POST
    total_iterations = int(data['total_iterations'])
    save_since = int(data['from_time'])
    save_until = int(data['from_time']) + int(data['iterations_to_show'])
    generators = create_generators(data)
    resultados = []
    cliente_array = []
    clientes_en_cajero = []

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
    cola_clientes = []

    #Estadisticos
    tiempo_espera = 0
    tiempo_espera_AC = 0
    clientes_finalizan_operacion = 0
    clientes_no_esperan = 0
    tiempo_libre_cajeros_AC = 0

    current_row = {}
    current_row['event_type'] = 'Inicializacion'    
    current_row['current_time'] = current_time
    current_row['iteration'] = iteration

    current_row['Cliente_arrival_random'], current_row['Cliente_time_between_arrivals'], current_row['Cliente_arrival'] = generate_random_numbers(generators['Cliente_Arrival'], current_time)
    
    current_row['random_desicion'] = None
    current_row['desicion_elegida'] = "--"
    current_row['Operacion_Cajero_random'] = None
    current_row['Operacion_Cajero_time_operation'] = None

    for i in range(cant_cajeros): 
        current_row[f'cajero_status_{(i+1)}'] = 'Libre'
        current_row[f'cajero_operacion_finish_{(i+1)}'] = None
        current_row[f'tiempo_libre_cajero_{(i+1)}'] = 0

    current_row['cola'] = len(cola_clientes)
    current_row['tiempo_espera_cliente'] = tiempo_espera
    current_row['tiempo_espera_AC'] = tiempo_espera_AC
    current_row['clientes_finalizados_operacion'] = clientes_finalizan_operacion
    current_row['cantidad_clientes_no_esperan'] = clientes_no_esperan
    current_row['tiempo_libre_cajero_AC'] = tiempo_libre_cajeros_AC
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


        for i in range(cant_cajeros):
            tiempo_libre = 0
            if prev_row[f'cajero_status_{(i+1)}'] == 'Libre':
                tiempo_libre = current_time - float(prev_row['current_time'])
            else: 
                tiempo_libre = 0
            current_row[f'tiempo_libre_cajero_{(i+1)}'] = tiempo_libre
            tiempo_libre_cajeros_AC += tiempo_libre

        #Llegada Cliente
        if prev_row['Cliente_arrival'] != None and float(prev_row['Cliente_arrival']) == current_time:
                
                current_row['event_type'] = f'Llegada Cliente {order}'
                #ver si esta diponible algun cajero
                cajero_disponible = None
                for i in range(cant_cajeros):
                    if current_row[f'cajero_status_{(i+1)}'] == 'Libre':
                        cajero_disponible = i
                        break

                if  cajero_disponible == None:
                    #desidir si espera en la cola                    
                    generators['Desicion_Espera'].generate_number()
                    random_number= generators['Desicion_Espera'].random_number
                    desicion_elegida= desicion_espera(random_number, len(cola_clientes))

                    if desicion_elegida == "SI":
                        cliente_nuevo = Cliente(order, current_time, None, "Esperando")
                        cliente_array.append(cliente_nuevo)
                        cola_clientes.append(cliente_nuevo)      
                    else:
                        cliente_nuevo = Cliente(order, float(0), None, "Destruido")
                        cliente_array.append(cliente_nuevo)
                        clientes_no_esperan+=1                        

                    current_row['Cliente_wait_random'] = random_number
                    current_row['Cliente_wait_desicion'] = desicion_elegida
                else:
                    #utiliza el cajero
                    cliente_nuevo = Cliente(order, current_time, 1, "Operando")
                    cliente_array.append(cliente_nuevo)
                    clientes_en_cajero.append(cliente_nuevo)              
                    tiempo_espera += (current_time - cliente_nuevo.hora_llegada)
                    tiempo_espera_AC += tiempo_espera
                    clientes_finalizan_operacion +=1                    
                    current_row['Operacion_Cajero_random'], current_row['Operacion_Cajero_time_operation'], current_row[f'cajero_operacion_finish_{(cajero_disponible+1)}'] = generate_random_numbers(generators['Operacion_Cajero_Finish'], current_time)
                    current_row[f'cajero_status_{(cajero_disponible+1)}'] = "Ocupado"

                if not final_row:
                        clientes_headers.append(f'Cliente {order} ')
                        last_order = order
                order+=1

                #genera nueva llegada de cliente
                current_row['Cliente_arrival_random'], current_row['Cliente_time_between_arrivals'], current_row['Cliente_arrival'] = generate_random_numbers(generators['Cliente_Arrival'], current_time)


        # #Fin Operacion Cajero 1
        # elif prev_row['cajero_operacion_finish_1'] != None and float(prev_row['cajero_operacion_finish_1']) == current_time:        

        #     #registrando finalizacion de Opreacion Cajero
        #     current_row['event_type'] = 'Fin Operacion Cajero 1'
        #     for cli in clientes_en_cajero:
        #         if  cli.nro_cajero == 1 and cli.status == 'Operando':
        #             cli.setStatus('Destruido')
        #             clientes_en_cajero.remove(cli)                    

        #         #Verificando si hay clientes en la cola
        #     if len(cola_clientes) > 0:
        #         sig_cliente= cola_clientes.pop(0)
        #         sig_cliente.setUsarCajero(1,'Operando')
        #         clientes_en_cajero.append(sig_cliente)
        #         tiempo_espera += (current_time - sig_cliente.hora_llegada)
        #         tiempo_espera_AC += tiempo_espera
        #         clientes_finalizan_operacion +=1
        #         current_row['Operacion_Cajero_random'], current_row['Operacion_Cajero_time_operation'], current_row[f'cajero_operacion_finish_1'] = generate_random_numbers(generators['Operacion_Cajero_Finish'], current_time)
        #     else:
        #         current_row[f'cajero_status_1'] = 'Libre'
        #         current_row['cajero_operacion_finish_1'] = None

        # #Fin Operacion Cajero 2
        # elif prev_row['cajero_operacion_finish_2'] != None and float(prev_row['cajero_operacion_finish_2']) == current_time:        

        #     #registrando finalizacion de Opreacion Cajero
        #     current_row['event_type'] = 'Fin Operacion Cajero 2'
        #     for cli in clientes_en_cajero:
        #         if  cli.nro_cajero == 2 and cli.status == 'Operando':
        #             cli.setStatus('Destruido')
        #             clientes_en_cajero.remove(cli)                    

        #         #Verificando si hay clientes en la cola
        #     if len(cola_clientes) > 0:
        #         sig_cliente= cola_clientes.pop(0)
        #         sig_cliente.setUsarCajero(2,'Operando')
        #         clientes_en_cajero.append(sig_cliente)
        #         tiempo_espera += (current_time - sig_cliente.hora_llegada)
        #         tiempo_espera_AC += tiempo_espera
        #         clientes_finalizan_operacion +=1
        #         current_row['Operacion_Cajero_random'], current_row['Operacion_Cajero_time_operation'], current_row[f'cajero_operacion_finish_2'] = generate_random_numbers(generators['Operacion_Cajero_Finish'], current_time)
        #     else:
        #         current_row[f'cajero_status_2'] = 'Libre'
        #         current_row['cajero_operacion_finish_2'] = None

        # #Fin Operacion Cajero 3
        # elif prev_row['cajero_operacion_finish_3'] != None and float(prev_row['cajero_operacion_finish_3']) == current_time:        

        #     #registrando finalizacion de Opreacion Cajero
        #     current_row['event_type'] = 'Fin Operacion Cajero 3'
        #     for cli in clientes_en_cajero:
        #         if  cli.nro_cajero == 3 and cli.status == 'Operando':
        #             cli.setStatus('Destruido')
        #             clientes_en_cajero.remove(cli)                    

        #         #Verificando si hay clientes en la cola
        #     if len(cola_clientes) > 0:
        #         sig_cliente= cola_clientes.pop(0)
        #         sig_cliente.setUsarCajero(3,'Operando')
        #         clientes_en_cajero.append(sig_cliente)
        #         tiempo_espera += (current_time - sig_cliente.hora_llegada)
        #         tiempo_espera_AC += tiempo_espera
        #         clientes_finalizan_operacion +=1
        #         current_row['Operacion_Cajero_random'], current_row['Operacion_Cajero_time_operation'], current_row[f'cajero_operacion_finish_3'] = generate_random_numbers(generators['Operacion_Cajero_Finish'], current_time)
        #     else:
        #         current_row[f'cajero_status_3'] = 'Libre'
        #         current_row['cajero_operacion_finish_3'] = None

        # #Fin Operacion Cajero 4
        # elif prev_row['cajero_operacion_finish_4'] != None and float(prev_row['cajero_operacion_finish_4']) == current_time:        

        #     #registrando finalizacion de Opreacion Cajero
        #     current_row['event_type'] = 'Fin Operacion Cajero 4'
        #     for cli in clientes_en_cajero:
        #         if  cli.nro_cajero == 4 and cli.status == 'Operando':
        #             cli.setStatus('Destruido')
        #             clientes_en_cajero.remove(cli)                    

        #         #Verificando si hay clientes en la cola
        #     if len(cola_clientes) > 0:
        #         sig_cliente= cola_clientes.pop(0)
        #         sig_cliente.setUsarCajero(4,'Operando')
        #         clientes_en_cajero.append(sig_cliente)
        #         tiempo_espera += (current_time - sig_cliente.hora_llegada)
        #         tiempo_espera_AC += tiempo_espera
        #         clientes_finalizan_operacion +=1
        #         current_row['Operacion_Cajero_random'], current_row['Operacion_Cajero_time_operation'], current_row[f'cajero_operacion_finish_4'] = generate_random_numbers(generators['Operacion_Cajero_Finish'], current_time)
        #     else:
        #         current_row[f'cajero_status_4'] = 'Libre'
        #         current_row['cajero_operacion_finish_4'] = None

        #Fin Opreacion para mas cajeros 
        #cajero elegido de los que estan ocupados y es hora de terminar la operacion
        cajero_elegido = []
        for i in range(cant_cajeros):
            if prev_row[f'cajero_operacion_finish_{(i+1)}'] != None and float(prev_row[f'cajero_operacion_finish_{(i+1)}']) == current_time:
                cajero_elegido.append(i+1)
        if len(cajero_elegido) > 0:
            for c in cajero_elegido:
            #registrando finalizacion de Opreacion Cajero
                current_row['event_type'] = f'Fin Operacion Cajero {c}'
                for cli in clientes_en_cajero:
                    if  cli.nro_cajero == c and cli.status == 'Operando':
                        cli.setStatus('Destruido')
                        clientes_en_cajero.remove(cli)                    

                #Verificando si hay clientes en la cola
                if len(cola_clientes) > 0:
                    sig_cliente= cola_clientes.pop(0)
                    sig_cliente.setUsarCajero(c,'Operando')
                    clientes_en_cajero.append(sig_cliente)
                    tiempo_espera += (current_time - sig_cliente.hora_llegada)
                    tiempo_espera_AC += tiempo_espera
                    clientes_finalizan_operacion +=1
                    current_row['Operacion_Cajero_random'], current_row['Operacion_Cajero_time_operation'], current_row[f'cajero_operacion_finish_{c}'] = generate_random_numbers(generators['Operacion_Cajero_Finish'], current_time)
                else:
                    current_row[f'cajero_status_{c}'] = 'Libre'
                    current_row[f'cajero_operacion_finish_{c}'] = None
                cajero_elegido.remove(c)
        cajero_elegido.clear()
       

        current_row['cola'] = len(cola_clientes) 
        current_row['tiempo_espera_cliente'] = tiempo_espera
        current_row['tiempo_espera_AC'] = tiempo_espera_AC 
        current_row['clientes_finalizados_operacion'] = clientes_finalizan_operacion
        current_row['cantidad_clientes_no_esperan'] = clientes_no_esperan
        current_row['tiempo_libre_cajero_AC'] = tiempo_libre_cajeros_AC



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
    if clientes_finalizan_operacion > 0:
        promedio_espera = tiempo_espera_AC / clientes_finalizan_operacion
        promedio_espera_x_hora = promedio_espera / 60
    else:
        promedio_espera = 0
        promedio_espera_x_hora = 0

    if tiempo_libre_cajeros_AC > 0:
        promedio_libre_x_cajero = tiempo_libre_cajeros_AC / cant_cajeros
        porcentaje_libre_cajero = promedio_libre_x_cajero * 100 / current_time
    else:
        porcentaje_libre_cajero = 0

    response_data = dict(
        history = resultados,
        clientes = clientes_headers,        
        total_iterations = total_iterations,
        cajeros = cant_cajeros,
        promedio_espera = promedio_espera,
        promedio_espera_x_hora = promedio_espera_x_hora,
        clientes_no_esperan = clientes_no_esperan,
        porcentaje_libre_cajero = porcentaje_libre_cajero
    )
    return render(request, 'ejercicio144/results.html', response_data)
    

    

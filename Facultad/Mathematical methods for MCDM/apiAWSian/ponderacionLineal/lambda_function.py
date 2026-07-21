import normalizacionEuler as Euler
import normalizacionSuma as Suma
import normalizacionMax as Maximo
import ponderar as Ponderar
import ordenar as Ordenar
import ponderacionlineal as ProgL
import numpy as np
import json
import copy

def maximizar(data_max):
    for i in range(len(data_max["tipos_criterios"])):
        if data_max["tipos_criterios"][i] == "MIN":
            data_max["tipos_criterios"][i]="MAX"
            for j in range(len(data_max["valores"])):
                data_max["valores"][j][i] = data_max["valores"][j][i] ** -1
    return data_max
    
def minimizar(data_min):
    for i in range(len(data_min["tipos_criterios"])):
        if data_min["tipos_criterios"][i] == "MAX":
            data_min["tipos_criterios"][i]="MIN"
            for j in range(len(data_min["valores"])):
                data_min["valores"][j][i] = data_min["valores"][j][i] ** -1
    return data_min

def lambda_handler(event, context):
    # Extrae el conjunto de valores del evento
    datos = json.loads(event['body'])
    
    
    # Crea una copia del conjunto original
    conjunto_criterizado = copy.deepcopy(datos)
    
    if datos["criterio_general"]== "MAX":
        # Actualiza el conjunto copiado con los valores maximos
        maximizar(conjunto_criterizado)
    else:
        # Actualiza el conjunto copiado con los valores minimos
        minimizar(conjunto_criterizado)
        
    conjunto_normalizado = copy.deepcopy(conjunto_criterizado)
    
    if conjunto_normalizado["normalizacion"] == "EULER":
        conjunto_normalizado["valores"] = Euler.normalizar(conjunto_normalizado["valores"])
    elif conjunto_normalizado["normalizacion"] == "SUMA":
        conjunto_normalizado["valores"] = Suma.normalizar(conjunto_normalizado["valores"])
    elif conjunto_normalizado["normalizacion"] == "MAX":
        conjunto_normalizado["valores"] = Maximo.normalizar(conjunto_normalizado["valores"])
        
    # normalizo los pesos si tiene pesos
    
    if "pesos" in conjunto_normalizado and len(conjunto_normalizado["pesos"]) > 0:
        if np.sum(conjunto_normalizado["pesos"]) != 1:
            conjunto_normalizado["pesos"]=Suma.normalizarPeso(conjunto_normalizado["pesos"])
    else:
        pesos = []
        for i in range(len(conjunto_normalizado["criterios"])):
            pesos.append(1)
        conjunto_normalizado["pesos"] = pesos
        conjunto_normalizado["pesos"]=Suma.normalizarPeso(conjunto_normalizado["pesos"])
        
    conjunto_ponderado = copy.deepcopy(conjunto_normalizado)
    conjunto_ponderado["valores"]=Ponderar.ponderar(conjunto_ponderado["valores"],conjunto_ponderado["pesos"])
    
    conjunto_solucion = copy.deepcopy(conjunto_ponderado)
    
    conjunto_solucion["solucion"] = ProgL.solucionar(conjunto_solucion["valores"])
    
    ordenado = {
        "alternativas": [],
        "solucion": []
    }
    
    ordenado["alternativas"],ordenado["solucion"]= Ordenar.orden(conjunto_solucion["alternativas"],conjunto_solucion["solucion"],conjunto_solucion["criterio_general"])
    
    
    
    # Retorna la respuesta con ambos conjuntos
    respuesta = {
        'original': datos,
        'criterizado': conjunto_criterizado,
        'normalizado':conjunto_normalizado,
        'ponderado':conjunto_ponderado,
        'solucion':conjunto_solucion,
        'ordenFinal':ordenado
        
    }
    
    return {
        'statusCode': 200,
        'body': json.dumps(respuesta)
    }
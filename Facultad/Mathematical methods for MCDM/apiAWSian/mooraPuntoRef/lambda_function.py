
import normalizacionEuler as Euler
import normalizacionSuma as Suma
import ponderar as Ponderar
import moora as Moora
import ordenar as Ordenar
import puntoRef as PuntoReferencia
import json
import numpy as np
import copy

    
def lambda_handler(event, context):
    # Extrae el conjunto de valores del evento
    datos = json.loads(event['body'])
    
    
    # Crea una copia del conjunto normalizado
    conjunto_normalizado = copy.deepcopy(datos)

    conjunto_normalizado["valores"] = Euler.normalizar(conjunto_normalizado["valores"])
    
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
    if "pesos" in conjunto_ponderado:
        conjunto_ponderado.pop("pesos")
        
    conjunto_ponderado["puntoref"] = PuntoReferencia.referencia(conjunto_ponderado["valores"],conjunto_ponderado["tipos_criterios"])
    
    
    
    conjunto_solucion = copy.deepcopy(conjunto_ponderado)
    
    conjunto_solucion["valores"] = Moora.solucionar(conjunto_solucion["valores"],conjunto_solucion["puntoref"])
    conjunto_solucion["solucion"] = Moora.resultados(conjunto_solucion["valores"])
    
    ordenado = {
        "alternativas": [],
        "solucion": []
    }
    
    ordenado["alternativas"],ordenado["solucion"]= Ordenar.orden(conjunto_solucion["alternativas"],conjunto_solucion["solucion"])
    
    
    # Retorna la respuesta con ambos conjuntos
    respuesta = {
        'original': datos,
        'normalizado': conjunto_normalizado,
        'ponderado':conjunto_ponderado,
        'solucion':conjunto_solucion,
        'ordenFinal':ordenado
        
    }
    
    return {
        'statusCode': 200,
        'body': json.dumps(respuesta)
    }
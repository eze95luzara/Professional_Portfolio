import normalizarEuler as Euler
import normalizarSuma as Suma
import normalizarMax as Maximo
import ponderar as Ponderar
import distancia as Distancia
import ideal as Obtener
import ordenacion as Ordenar
import topsis as Topsis
import numpy as np
import json
import copy

def lambda_handler(event, context):
    # Extrae el conjunto de valores del evento
    datos = json.loads(event['body'])
    
    conjunto_normalizado = copy.deepcopy(datos)
    
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
    if "pesos" in conjunto_ponderado:
        conjunto_ponderado.pop("pesos")
        
    conjunto_ide_anti = copy.deepcopy(conjunto_ponderado)
    conjunto_ide_anti["ideal"],conjunto_ide_anti["anti_ideal"] = Obtener.ideales(conjunto_ide_anti["valores"],conjunto_ide_anti["tipos_criterios"])
    
    
    conjunto_ideal = copy.deepcopy(conjunto_ide_anti)
    conjunto_anti_ideal = copy.deepcopy(conjunto_ide_anti)
    conjunto_ideal["tipo"] = "Smas"
    conjunto_anti_ideal["tipo"] = "Smenos"
    
    p = 2
    conjunto_ideal["valores"],conjunto_ideal["suma"],conjunto_ideal["resultadosParciales"] = Distancia.calcularDistancia(conjunto_ideal["valores"],conjunto_ideal["ideal"],p)
    conjunto_anti_ideal["valores"],conjunto_anti_ideal["suma"],conjunto_anti_ideal["resultadosParciales"]  = Distancia.calcularDistancia(conjunto_anti_ideal["valores"],conjunto_anti_ideal["anti_ideal"],p)
    if "ideal" in conjunto_ideal:
        conjunto_ideal.pop("ideal")
    if "ideal" in conjunto_anti_ideal:
        conjunto_anti_ideal.pop("ideal")
    if "anti_ideal" in conjunto_ideal:
        conjunto_ideal.pop("anti_ideal")
    if "anti_ideal" in conjunto_anti_ideal:
        conjunto_anti_ideal.pop("anti_ideal")
    
    
    conjunto_topsis = copy.deepcopy(conjunto_ponderado)
    conjunto_topsis["resultados"] = Topsis.Solucion(conjunto_ideal["resultadosParciales"],conjunto_anti_ideal["resultadosParciales"])
    
    ordenado = {
        "alternativas": [],
        "solucion": []
    }
    
    ordenado["alternativas"],ordenado["solucion"]= Ordenar.orden(conjunto_ponderado["alternativas"],conjunto_topsis["resultados"])
    
    
    # Retorna la respuesta con ambos conjuntos
    respuesta = {
        'original': datos,
        'normalizado':conjunto_normalizado,
        'ponderado':conjunto_ponderado,
        'ideales': conjunto_ide_anti,
        'ideal': conjunto_ideal,
        'anti_ideal':conjunto_anti_ideal,
        'solucion':conjunto_topsis,
        'ordenFinal':ordenado
        
        
        
    }
    
    return {
        'statusCode': 200,
        'body': json.dumps(respuesta)
    }


import numpy as np

def orden(alternativas, solucion, criterio):
    if criterio == "MAX":
        # Obtener índices ordenados de solución de mayor a menor
        indices_ordenados = np.argsort(solucion)[::-1]
    elif criterio == "MIN":
        # Obtener índices ordenados de solución de menor a mayor
        indices_ordenados = np.argsort(solucion)
    
    
    # Ordenar alternativas y solución según los índices obtenidos
    alternativas_ordenadas = [alternativas[i] for i in indices_ordenados]
    solucion_ordenada = [solucion[i] for i in indices_ordenados]
    
    return alternativas_ordenadas, solucion_ordenada
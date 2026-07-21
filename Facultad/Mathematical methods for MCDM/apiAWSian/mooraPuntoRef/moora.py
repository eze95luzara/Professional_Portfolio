import numpy as np

def solucionar(valores, puntosref):
    # Iterar sobre las filas de la matriz de valores
    for i in range(len(valores)):
        # Iterar sobre las columnas de la matriz de valores
        for j in range(len(valores[i])):
            # Restar el valor de la celda del punto de referencia correspondiente y tomar el valor absoluto
            valores[i][j] = abs(puntosref[j] - valores[i][j])
    
    return valores
    
def resultados(valores):
    respuesta = []
    # Iterar sobre las filas de la matriz de valores
    for fila in valores:
        maximo = max(fila)  # Encontrar el valor máximo de la fila
        respuesta.append(maximo)  # Agregar el máximo a la lista respuesta
    
    return respuesta
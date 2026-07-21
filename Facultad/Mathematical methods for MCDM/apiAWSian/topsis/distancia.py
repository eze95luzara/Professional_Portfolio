import numpy as np
def calcularDistancia(tabla, vectorIoAI, p):
    distancia_tabla = []
    sumaFila = []
    resultados = []
    for fila in tabla:
        distancia_fila = []
        suma = 0
        for i in range(len(fila)):
            distancia = abs(fila[i] - vectorIoAI[i]) ** p
            distancia_fila.append(distancia)
            suma += distancia
        distancia_tabla.append(distancia_fila)
        sumaFila.append(suma)
        resultados.append(np.power(suma, 1 / p))
    return distancia_tabla, sumaFila, resultados
    
 
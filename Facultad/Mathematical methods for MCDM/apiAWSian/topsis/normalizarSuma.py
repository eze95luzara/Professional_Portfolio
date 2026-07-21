import numpy as np


def normalizarPeso(vector):
    suma_total = np.sum(vector)
    vector_normalizado = np.zeros_like(vector, dtype=float)

    for i in range(len(vector)):
        # Crear el vector normalizado en memoria
        vector_normalizado[i] = vector[i] / suma_total

    return vector_normalizado.tolist()  # Convertir el array NumPy a lista
    
def normalizar(tabla):
    # Calcular la raiz cuadrada de la suma de los cuadrados de cada columna
    suma_columnas = [np.sum(columna) for columna in np.array(tabla).T]

    # Crear la tabla nueva en memoria
    tabla_normalizada = [[celda / suma_columnas[j] for j, celda in enumerate(fila)] for fila in tabla]
    return tabla_normalizada
    
import numpy as np

def normalizar(tabla):
    # Calcular la raiz cuadrada de la suma de los cuadrados de cada columna
    raiz_suma_cuadrados_columnas = [np.sqrt(np.sum(np.square(columna))) for columna in np.array(tabla).T]

    # Crear la tabla nueva en memoria
    tabla_normalizada = [[celda / raiz_suma_cuadrados_columnas[j] for j, celda in enumerate(fila)] for fila in tabla]
    return tabla_normalizada
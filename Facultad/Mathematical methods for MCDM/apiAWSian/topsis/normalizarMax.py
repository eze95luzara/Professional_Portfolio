import numpy as np

def normalizar(tabla):
    # Convertir la tabla a un array NumPy
    tabla_array = np.array(tabla)
    
    # Calcular el valor máximo de cada columna
    maximos_columnas = np.max(tabla_array, axis=0)
    
    # Normalizar cada celda dividiendo por el máximo de su columna
    tabla_normalizada = tabla_array / maximos_columnas
    
    return tabla_normalizada.tolist()  # Convertir el array NumPy resultante a una lista de Python



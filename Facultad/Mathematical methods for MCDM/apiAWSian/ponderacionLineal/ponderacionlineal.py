import numpy as np

def solucionar(valores):
    # Convertir la lista de listas a un array NumPy
    valores_array = np.array(valores)
    
    # Calcular la suma de las filas usando la función sum de NumPy
    vector_solucion = np.sum(valores_array, axis=1)
    
    return vector_solucion.tolist() 
    
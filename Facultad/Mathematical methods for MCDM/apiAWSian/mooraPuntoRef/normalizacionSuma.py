import numpy as np


def normalizarPeso(vector):
    suma_total = np.sum(vector)
    vector_normalizado = np.zeros_like(vector, dtype=float)

    for i in range(len(vector)):
        # Crear el vector normalizado en memoria
        vector_normalizado[i] = vector[i] / suma_total

    return vector_normalizado.tolist()  # Convertir el array NumPy a lista
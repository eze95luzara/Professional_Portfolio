import numpy as np

def referencia(valores, criterios):
    # Inicializar el vector de puntos de referencia como una lista vacía
    puntosref = []
    
    # Iterar sobre las columnas de la matriz de valores
    for j in range(len(criterios)):
        # Inicializar variables para encontrar el max o min
        if criterios[j] == "MAX":
            max_val = valores[0][j]
            for i in range(1, len(valores)):
                if valores[i][j] > max_val:
                    max_val = valores[i][j]
            puntosref.append(max_val)
        elif criterios[j] == "MIN":
            min_val = valores[0][j]
            for i in range(1, len(valores)):
                if valores[i][j] < min_val:
                    min_val = valores[i][j]
            puntosref.append(min_val)
    
    
    return puntosref
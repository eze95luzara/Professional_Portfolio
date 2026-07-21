import numpy as np

def solucionar(valores,criterios):
    resultados = []
    
    for i in range(len(valores)):
        maximo = 0
        minimo = 0
        for j in range(len(valores[i])):
            if criterios[j] == "MAX":
                maximo = maximo + valores[i][j]
            else:
                minimo = minimo + valores[i][j]

        resultados.append(maximo - minimo)
        
        
    
    return resultados
    
    

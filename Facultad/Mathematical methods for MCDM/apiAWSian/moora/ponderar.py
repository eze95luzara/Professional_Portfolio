import numpy as np

def ponderar(valores,pesos):
    for i in range(len(valores)):
        for j in range(len(valores[i])):
            valores[i][j] = valores[i][j] * pesos[j]
    return valores

    
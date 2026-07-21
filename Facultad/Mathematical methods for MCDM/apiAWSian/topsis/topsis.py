import numpy as np

def Solucion(vectorI, vectorAI):
    vectorSolucion = []
    for i in range(len(vectorI)):
        solucion = vectorAI[i] / (vectorI[i] + vectorAI[i])
        vectorSolucion.append(solucion)
    return vectorSolucion
    


    
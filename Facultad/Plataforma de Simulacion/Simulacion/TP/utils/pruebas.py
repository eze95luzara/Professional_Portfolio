import numpy as np
from TP.utils.generador import truncate

tableChiCu= [3.84,5.99, 7.81, 9.49, 11.1, 12.6, 14.1, 15.5, 16.9, 18.3, 
            19.7, 21.0, 22.4, 23.7, 25.0, 26.3, 27.6, 28.9, 30.1, 31.4, 
            32.7, 33.9, 35.2, 36.4, 37.7, 38.9, 40.1, 41.3, 42.6, 43.8]

def chi_cuadrado(numbers, intervals):
    table = []
    length = len(numbers)
    hist = np.histogram(numbers, bins=intervals, range=(0,1))
    esperada = length // intervals
    chi_acumulado = 0
    for i in range(intervals):
        intervalo_label = str(round(hist[1][i], 2)) + ' - ' + str(round(hist[1][i+1], 2))
        frecuencia_obs = hist[0][i]
        resto = length % intervals
        if  (resto > 0 and resto > i):
            frecuencia_esp = esperada + 1
        else:
            frecuencia_esp = esperada
        chi_linea = truncate(((frecuencia_obs - frecuencia_esp)**2) / frecuencia_esp, 4)
        chi_acumulado += chi_linea
        chi_acumulado = truncate(chi_acumulado, 4)
        table_line = [intervalo_label, frecuencia_obs, frecuencia_esp, chi_linea, chi_acumulado]
        table.append(table_line)
    return table

def obtener_chi_tabla(intervals):
    gradoLibertad=intervals-1
    chiCuaTab=tableChiCu[(gradoLibertad-1)]
    return chiCuaTab 

import numpy as np

def ideales(tabla,criterios):
    tabla = np.array(tabla)
    referenciaSoluIdeal = np.zeros(tabla.shape[1]) 
    referenciaSoluAntiIdeal = np.zeros(tabla.shape[1]) 
    
    # Iteramos sobre las columnas de la tabla
    for col_id, columna in enumerate(tabla.T):  # Transponemos la tabla para iterar sobre las columnas
            
        # Verificamos si el criterio de la columna es "MAX" o "MIN"
        if criterios[col_id] == 'MAX':
            # Obtenemos la solucion ideal y anti ideal
            sIdeal = np.max(columna)
            sAntiIdeal = np.min(columna)

            # agregamos las solucion ideal y anti-ideal a los arreglos que correspondan
            referenciaSoluIdeal[col_id] = sIdeal
            referenciaSoluAntiIdeal[col_id] =  sAntiIdeal

        elif criterios[col_id] == 'MIN':
            # Obtenemos la solucion ideal y anti ideal
            sIdeal = np.min(columna)
            sAntiIdeal = np.max(columna)

            # agregamos las solucion ideal y anti-ideal a los arreglos que correspondan
            referenciaSoluIdeal[col_id] = sIdeal
            referenciaSoluAntiIdeal[col_id] =  sAntiIdeal   
    
    return (referenciaSoluIdeal.tolist(),referenciaSoluAntiIdeal.tolist())
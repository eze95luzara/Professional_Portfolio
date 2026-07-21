import numpy as np
def normalizar(tabla, criterios):
    tabla_valores = np.array(tabla)
    valores_amplitud = np.zeros(tabla_valores.shape[1]) 
    valores_optimo = np.zeros(tabla_valores.shape[1]) 

    for col_id, columna in enumerate(tabla_valores.T):  # Transponemos la tabla para iterar sobre las columnas
            
            amplitud = np.max(columna) - np.min(columna)
            valores_amplitud [col_id] = amplitud

            # Verificamos si el criterio de la columna es "MAX" o "MIN"
            if criterios[col_id] == 'MAX':
                # Obtenemos el valor optimo  para criterio "MAX"
                optimo = np.max(columna)

               # agregamos el valor optimo dentro del arrray
                valores_optimo[col_id] = optimo

            elif criterios[col_id] == 'MIN':
                # Obtenemos el valor optimo para criterio "MIN"
                optimo = np.max(columna)

                # agregamos el valor optimo dentro del arrray
                valores_optimo[col_id] = optimo
    
    tabla_normalizada = []
    
    for fila in tabla_valores:
        normalizacion_fila = []
        for i in range(len(fila)):
            normalizacion = abs(fila[i] - valores_optimo[i]) /valores_amplitud[i]
            normalizacion_fila.append(normalizacion)
        tabla_normalizada.append(normalizacion_fila)
        
    return tabla_normalizada
    
 
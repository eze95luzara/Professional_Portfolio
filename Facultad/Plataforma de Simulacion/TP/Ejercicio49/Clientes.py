class Cliente():
    def __init__(self, order, duracionLlamada, status):
        self.order = order
        self.duracionLlamada = duracionLlamada      
        self.status = status
        
    def setStatus(self, new_status):
        self.status = new_status
    
    def setDuracionLlamada(self, durLlamada): 
        self.duracionLlamada = durLlamada

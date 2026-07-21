class Cliente():
    def __init__(self, order, horaLlegada, carril, status):
        self.order = order
        self.hora_llegada = horaLlegada
        self.carril = carril        
        self.status = status

    def setStatus(self, new_status):
        self.status = new_status
        
    def setStatusDeslizar(self, carril, new_status):
        self.carril = carril
        self.status = new_status

class Cliente():
    def __init__(self, order, hora_llegada, nro_cajero, status):
        self.order = order
        self.hora_llegada = hora_llegada
        self.nro_cajero = nro_cajero
        self.status = status
    def setStatus(self, new_status):
        self.status = new_status

    def setUsarCajero(self, nro_cajero, new_status):
        self.nro_cajero = nro_cajero
        self.status =  new_status
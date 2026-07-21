class Team():
    def __init__(self, order, hora_llegada, status):
        self.order = order
        self.hora_llegada = hora_llegada
        self.status = status
    def setStatus(self, new_status):
        self.status = new_status
    def getType(self):
        return 'Team'

class HandballTeam(Team):
    def getType(self):
        return 'Handball'
class FootballTeam(Team):
    def getType(self):
        return 'Football'
class BasketballTeam(Team):
    def getType(self):
        return 'Basketball'
class Cliente():
    def __init__(self, order, status):
        self.order = order        
        self.status = status
        
    def setStatus(self, new_status):
        self.status = new_status

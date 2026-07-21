class BaseSatefullItem():
    possible_states = ()
    possible_transitions = ()
    
    def __init__():

        pass

    def transition(self, target):
        current_state = self.state
        for origin_state, target_state in self.possible_transitions:
            if origin_state == current_state and target_state == target:
                self.state = target_state
                return
        raise Exception("Not a possible transition")
            


    
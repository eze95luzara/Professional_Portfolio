from django.db import models
import json

class Row(models.Model):

    iteration = models.IntegerField()
    current_time = models.FloatField()
    event_type = models.CharField(max_length=100)
    Basketball_arrival_random = models.FloatField(null=True)
    Basketball_time_between_arrivals = models.FloatField(null=True)
    Basketball_arrival = models.FloatField()
    Football_arrival_random = models.FloatField(null=True)
    Football_time_between_arrivals = models.FloatField(null=True)
    Football_arrival = models.FloatField()
    Handball_arrival_random = models.FloatField(null=True)
    Handball_time_between_arrivals = models.FloatField(null=True)
    Handball_arrival = models.FloatField()
    Basketball_finish_random = models.FloatField(null=True)
    Basketball_time_to_finish = models.FloatField(null=True)
    Basketball_finish = models.FloatField(null=True)
    Football_finish_random = models.FloatField(null=True)
    Basketball_time_to_finish = models.FloatField(null=True)
    Football_finish = models.FloatField(null=True)
    Handball_finish_random = models.FloatField(null=True)
    Handball_time_to_finish = models.FloatField(null=True)
    Handball_finish = models.FloatField(null=True)
    Cleaning_d = models.FloatField(null=True)
    Cleaning_time = models.FloatField(null=True)
    Cleaning_finish = models.FloatField(null=True)
    server_status = models.CharField(max_length=100)
    Cola = models.IntegerField()
    equipos_finalizados_basketball = models.IntegerField()
    espera_basketball = models.FloatField()
    equipos_finalizados_football = models.IntegerField()
    espera_football = models.FloatField()
    equipos_finalizados_handball = models.IntegerField()
    espera_handball = models.FloatField()
    tiempo_limpieza_acumulado = models.FloatField()
    equipos = models.CharField(max_length=100000, null=True)
    start_equipos = models.IntegerField(null=True)

    def get_parsed_teams(self):
        return json.loads(self.equipos)


class CommonData(models.Model):
    cleaning_d_basketball = models.FloatField()
    cleaning_d_handball = models.FloatField()
    cleaning_d_football = models.FloatField()
    total_iterations = models.IntegerField()
    promedio_basketball = models.FloatField()
    promedio_handball = models.FloatField()
    promedio_football = models.FloatField()
    tasa_limpieza = models.FloatField()
    h = models.FloatField()

class TablaEuler(models.Model):
    index = models.IntegerField()
    Ti = models.FloatField(null=True)
    Ci = models.FloatField(null=True)
    derivada = models.FloatField(null=True)
    Ti1 = models.FloatField(null=True)
    Ci1 = models.FloatField(null=True)
    teams = models.CharField(max_length=100, null=True)

class EquiposHeaders(models.Model):
    index = models.IntegerField()
    headers = models.CharField(max_length=100000, null=True)
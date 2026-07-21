from django.db import models
from django.forms import ImageField

class RandomNumber(models.Model):
    index = models.IntegerField()
    number = models.FloatField()

class ChiCuadrado(models.Model):
    intervalo = models.CharField(max_length=100)
    fo = models.CharField(max_length=100)
    fe = models.CharField(max_length=100)
    c = models.CharField(max_length=100)
    c_acumulado = models.CharField(max_length=100)

class Graph(models.Model):
    graph = models.CharField(max_length=100000000)
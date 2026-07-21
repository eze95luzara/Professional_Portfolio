from random import Random, random
from django.shortcuts import render
from django.core.paginator import Paginator
from django.http import HttpResponse, HttpResponseRedirect
import TP.utils.generador
import TP.utils.graphs
import TP.utils.pruebas
from . import forms
from .models import ChiCuadrado, RandomNumber, Graph

def clearFiles():
  RandomNumber.objects.all().delete()
  Graph.objects.all().delete()
  ChiCuadrado.objects.all().delete()

def enter_data(request):
  form = forms.FormName()
  if request.method == "POST":
    form = forms.FormName(request.POST)
    if form.is_valid():
      clearFiles()
      seed = form.cleaned_data['seed']
      g = form.cleaned_data['g']
      k = form.cleaned_data['k']
      c = form.cleaned_data['c']
      size = form.cleaned_data['muestra']
      method = form.cleaned_data['method']
      intervalos = int(form.cleaned_data['intervalos'])
      random_numbers = TP.utils.generador.generate(seed, g, k, c, size, method)
      numeros = []
      for i in range(len(random_numbers)):
        randomnumber = RandomNumber(
          index = i + 1,
          number = random_numbers[i]
        )
        numeros.append(randomnumber)
      RandomNumber.objects.bulk_create(numeros)
      histogram = TP.utils.graphs.histogram(random_numbers, intervalos)
      image = Graph(
        graph = histogram
      )
      image.save()
      chi_cuadrado = TP.utils.pruebas.chi_cuadrado(random_numbers, intervalos)
      chi_en_tabla = TP.utils.pruebas.obtener_chi_tabla(intervalos)
      for i in range(len(chi_cuadrado)):
        chi = ChiCuadrado(
          intervalo = chi_cuadrado[i][0],
          fo = chi_cuadrado[i][1],
          fe = chi_cuadrado[i][2],
          c = chi_cuadrado[i][3],
          c_acumulado = chi_cuadrado[i][4]
        )
        chi.save()
      paginator = Paginator(numeros, 50)
      page_number = request.GET.get('page')
      page_obj = paginator.get_page(page_number)
      return render(request, 'App/pages.html', { 
      'histograma': histogram, 'chi_cuadrado': chi_cuadrado, 
      'page_obj': page_obj, 'chi_en_tabla': chi_en_tabla})
  return render(request, 'App/input.html', {'form': form})

def paginas(request):
  numeros = RandomNumber.objects.all().order_by('index')
  chi = ChiCuadrado.objects.all()
  chi_cuadrado = []
  for line in chi:
    fila = []
    fila.append(line.intervalo)
    fila.append(line.fo)
    fila.append(line.fe)
    fila.append(line.c)
    fila.append(line.c_acumulado)
    chi_cuadrado.append(fila)
  intervalos = len(chi_cuadrado)
  chi_en_tabla = TP.utils.pruebas.obtener_chi_tabla(intervalos)
  histogram = Graph.objects.all()[0].graph
  paginator = Paginator(numeros, 50)
  page_number = request.GET.get('page')
  page_obj = paginator.get_page(page_number)
  return render(request, 'App/pages.html', {'histograma': histogram, 'page_obj': page_obj, 
  'chi_cuadrado': chi_cuadrado, 'chi_en_tabla': chi_en_tabla})
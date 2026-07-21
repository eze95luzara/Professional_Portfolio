from django.urls import path

from . import views

app_name = 'ejercicio144'
urlpatterns = [
    path('', views.index, name='index'),
    path('simulacion', views.simulate, name='simulate'),
    
]
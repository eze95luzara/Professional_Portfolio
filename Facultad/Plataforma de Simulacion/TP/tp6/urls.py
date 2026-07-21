from django.urls import path

from . import views

app_name = 'tp6'
urlpatterns = [
    path('', views.index, name='index'),
    path('simulacion', views.simulate, name='simulate'),
    path('paginas', views.paginas, name='paginas'),
]
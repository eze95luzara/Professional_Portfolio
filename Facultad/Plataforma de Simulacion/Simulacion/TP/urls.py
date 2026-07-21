from django.urls import path

from . import views

urlpatterns = [
    path('', views.enter_data, name='input'),
]
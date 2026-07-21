from django.contrib import admin
from django.urls import include, path
from TP import views

urlpatterns = [
    path('', views.enter_data, name = 'input'),
    path('pages', views.paginas, name = 'paginas'),
    path('admin/', admin.site.urls),
]

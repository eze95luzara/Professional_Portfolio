from django import forms
# Create the FormName class

opciones_metodo = [
    ('lineal', 'Congruencial Lineal'),
    ('multiplicativo', 'Congruencial Multiplicativo'),
    ('lenguaje', 'Provisto por lenguaje')
]

intervalos = [
    (5, '5'),
    (10, '10'),
    (15, '15'),
    (20, '20'),
]



class FormName(forms.Form):
 seed = forms.IntegerField(label='Semilla')
 muestra = forms.IntegerField(label='Tamaño de la muestra')
 g = forms.IntegerField(required=False)
 k = forms.IntegerField(required=False)
 c = forms.IntegerField(required=False)
 method = forms.CharField(label='Método de Generación', widget=forms.Select(choices=opciones_metodo))
 intervalos = forms.CharField(label='Cantidad de intervalos', widget=forms.Select(choices=intervalos))
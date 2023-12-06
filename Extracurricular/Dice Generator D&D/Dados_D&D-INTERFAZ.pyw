from tkinter import *
from tkinter import messagebox as mb
from random import randint, uniform

raiz = Tk()
raiz.title("Generador de Dados D&D")
raiz.config(bg="black")
raiz.iconbitmap("img\icono-Dados-D&D.ico")
raiz.resizable(False,False)


#-----------Funciones del generador---------

def calcular_valor_dados(cantDados, caraDado, modificador):
     res_dados = []
     res_total = 0

     for x in range(cantDados):
         if caraDado == 100:
             res_dados.insert(x, randint(1,10)*10)
         else:
             res_dados.insert(x, randint(1,caraDado))

         res_total += res_dados[x]        

     res_total += modificador 

     return [ res_total, res_dados ] 


#valores globales
varResultado = int
varMod = int
varDados = [0,0,0]


def cambiarLblResultado():
  txtResultado.config(text="RESULTADO:  -----> "+ str(varResultado) +" <----- \nMODIFICADOR: ("+ str(varMod) +") \nDADOS: " + str(varDados))


def tirar(cantDadosIngresado, tipoDadoIngresado, modIngresado):
  
  try:
     resultado= calcular_valor_dados(int(cantDadosIngresado), int(tipoDadoIngresado), int(modIngresado) )

     global varResultado
     varResultado = resultado[0]

     global varMod
     varMod = modIngresado

     global varDados
     varDados = resultado[1]

     cambiarLblResultado()                  
  except ValueError:
      mb.showerror("Cuidado","Por favor, ingrese NUMEROS ENTEROS en las casillas")

  


def limpiar():
    global varResultado
    varResultado= 0

    global varMod
    varMod = 0

    global varDados
    varDados = [0,0,0]

    txtCantDados.delete(0, END)
    txtTipoDado.delete(0, END)
    txtModificador.delete(0, END)
    txtModificador.insert(0, "0")
    
    cambiarLblResultado()
                        
                        
    
     
#---------------nombre de la app-----------------
lblTitulo= Label(raiz, bg="black",fg="red", text="Generador de Dados <D&D>", justify="center", font=("Felix Titling",24))
lblTitulo.pack(side="top", padx=10)

#------------Parte de Ingreso de Datos------------

frameIngresoDatos = Frame( bg="black",width="600", height="200")
frameIngresoDatos.pack(pady=3)

#Imagen------------
frameGIF = Frame(frameIngresoDatos, width=249, height=200)
frameGIF.grid(row=0,column=1, padx=5)

miImgDados= PhotoImage(file="img/dado1.png", width=249, height=249)
lblGIF = Label(frameGIF, image= miImgDados, bg="black")
lblGIF.pack()
#-----------------


frameEntradaDados = Frame(frameIngresoDatos)
frameEntradaDados.config(bg="black", width="25000", height="100")
frameEntradaDados.grid(row=0,column=0, padx=5)


lblCantDados = Label(frameEntradaDados, text="Cantidad de Dados a Tirar: ")
lblCantDados.config(font=("Papyrus",16), bg="black", fg="white")
lblCantDados.grid(row=0, column=0)

lblTipoDado = Label(frameEntradaDados, text="Tipo de Dado (Dnro): ")
lblTipoDado.config(font=("Papyrus",16), bg="black", fg="white")
lblTipoDado.grid(row=1, column=0)

lblModificador = Label(frameEntradaDados, text="Modificador: ")
lblModificador.config(font=("Papyrus",16), bg="black", fg="white")
lblModificador.grid(row=2, column=0)

txtCantDados = Entry(frameEntradaDados, width=5, font=("Papyrus",18))
txtCantDados.grid(row=0, column=1)

txtTipoDado = Entry(frameEntradaDados, width=5, font=("Papyrus",18))
txtTipoDado.grid(row=1, column=1)

txtModificador = Entry(frameEntradaDados, width=5, font=("Papyrus",18))
txtModificador.insert(0, "0")
txtModificador.grid(row=2, column=1)


#--------------Parte de Muestra de Datos---------

txtResultado= Label(raiz, bg="black",fg="red", font=("Felix Titling",20))
txtResultado.config(text="RESULTADO:   \nMODIFICADOR: \nDADOS: ")
txtResultado.pack( padx=10, pady=5)

frmBotones = Frame(bg="black")
frmBotones.pack( side="bottom", padx=10)

btnTirar = Button(frmBotones, text="Tirar", font=("Papyrus",16), bg="white")
btnTirar.config( command = lambda: tirar(txtCantDados.get(), txtTipoDado.get(),txtModificador.get()) )
btnTirar.grid(row=0, column=0, padx=5, pady=5)

btnLimpiar = Button(frmBotones, text="Limpiar", font=("Papyrus",16), bg="white")
btnLimpiar.config( command= lambda: limpiar() )
btnLimpiar.grid(row=0, column=1, padx=5, pady=5)


raiz.mainloop()

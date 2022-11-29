# DECLARACION DE VARIABLES

'''

la declaracion es implicita
se usa ; para la asignacion multiple: a=2; b=3
se usa , para asignacion multiple por posicion: a,b,c=1,2,3

se puede poner un alias, por ejemplo a las llamadas a librerias
import random  as rd

'''


# OPERADORES

'''

//  division entera
%   residuo
**  potencia, por ejemplo si ponemos 25**(1/2) es la raiz cuadrada de 25

'''


# OPERADORES RELACIONALES 

'''

los mismos que en otros lenguajes
==  igual
!=  distinto que
etc

'''

# FUNCIONES DE CONVERSION

'''
int()   convierte a entero
str()   convierte a string
float() convierte a float
bool()
'''

# ENTRADA Y SALIDA DE DATOS

'''
print() salida
variable=input()    #todo dato ingresado por el usuario es cadena
    


print("Números divisibles")
print("------------------")


dividendo=float(input("escribe el dividendo : "))
divisor=float(input("escribe el divisor : "))

res=dividendo%divisor

if res==0:
    print("los numeros son divisibles")
elif res!=0:
    print("los numeros no son divisibles")



x=float(input("ingrese el valor de x: "))

res=4*(x**2)+(3/2)*(x)-5

**********************OJO******************
la coma evita tener que usar espacios en blanco
print("es resultado es:",  str(res))

'''

#  FORMATOS DE SALIDA,  FUNCION FORMAT

'''
manda por parametros dos campos de 10 espacios
formatea el float a dos decimales, esto con (,.2f)

la sintaxis es:

"CADENA_CON_DIRECTIVA {} ". format("con el VALOR")


print("{:^10}{:^10}".format("enc 1", "enc2"))

print("{:^10}{:^10,.2f}".format(float("2.555"), float("2.555")))

'''

# FUNCIONES CON CADENAS

'''
referenciar una posicion en una cadena
[:] toda la cadena
[1:] del 1 hasta el fin
[:3] del inicio hasta el 3
[-1:-4] del ultimo hasta 4 menos

[inicio:fin:salto] un tipo especial
[inicio:fin:-1] reversa

len("cadena") devuelve la longitud de la cadena
x=cadena.count("coincidencia") cuenta cuantas veces se da la coincidencia
string.replace("cadena original","nueva cadena") reemplaza
string.strip() borra los espacios al inicio y final, o cuqluier otra cadena como argumento
string.lower()
string.upper()
string.title() pasa la cadena a modo nombre propio
cadena.startswith() inicia con
cadena.endswith() finaliza con
cadena.find("coincidencia") la ventaja contra index es que, de no existir la conincidencia, no causa error, sino 
    devuelve -1


cad="python"

ref=cad[1]
print("la segunda posicion")
print(ref) #manda la y

#referencia la ultima letra
ref=cad[-1]
print("la ultima posicion")
print(ref)

print("una subcadena")
ref=cad[2:4]
print(ref)

print("reversa")
ref=cad[::-1]
print(ref)

print("la posicion de la primera ocurrencia")
ref=cad.index("h")
print(ref)


print("la posicion subsecuente de la ocurrencia")

cad="python_python"
ref1=cad.index("h")
ref2=cad.index("h",ref1+1)
print(ref2)

'''

# STRING

'''
+ sirve para concatenar
* sirve para operar sobre string, ejemplo: "h" * 3="hhh"
\n salto de linea
\t tabulador
r"" indica que va texto plano
\" secuencia de escape, por ejemplo para poner comillas dentro de comillas



#in, sirve para verificar si algo existe en string

st="hola"
x="h" in st

print("es cierta la afirmacion")
print(x)

'''

#COMPROBACION
'''
variable.isdigit() comprueba si la cadena solo contiene numeros, no signos
variable.isalpha() compueba si solo contiene letras
.islower()
.isupper()
'''


#FUNCIONES

'''
checar las que regtornan o no retornan valor
'''

# ARRAYS

'''
los array comienza con 0, aceptan diferentes tipos de datos,
acepta las mismas reglas que los string, por ejemplo arr[3:]
del elemento 3 hasta el final del array

arr=["a",1,2.5,True]
print(arr[1:])

indexacion a indexacion, el ultimo elemento del indice 0
print(arr[0][-1])

arr[::-1] invertir la lista

REVERSE
invierte el orden de la lista
arr.reverse()

lista=arr[:]+arr2[:] concatena los array

lista=arr[:]*2 duplica los valores de arr[:]

x="abc" in arr[:] evalua si un elemento pertenece al array

SPLIT
convierte en lista los elementos de una cadena separador por un 
caracter

cad="uno/dos/tres"
x=cad.split("/")
print(x)

JOIN
une los elementos con un caracter determinado
x="-".join(arr)

LEN
la longitud de la lista
x=len(arr)

SUM
suma los elementos de una lista
x=sum(arr)

MAX el valor maximo de una lista

MIN el valor minimo de la lista

APEND
agrega un elemento al final de la lista
arr.append("agregado al ultimo")

INSERT
agrega elemento en determinado orden
arr.insert(2,"agregado")

EXTEND
concatena dos listas
arr.extend(arr2)

POP
elimina un determindo elemento por indice, sin parametro elimina el ultimo
y guarda en memoria el elemento eliminado
arr.pop(1)

REMOVE
elimina un elemento por nombre, si no existe el elemento causa error

DEL
tambien elimina elementos segun el indice
del arr[2]

INDEX
devuelve el indice del elemento buscado
x=arr.index("elemento buscado")

COUNT
devuelve el numero de veces que se encuentra un elementos de la lista
x=arr.count("elemento")

SORT
ordena de menor a mayor
arr.sort()
arr.sort(reverse=true)  ordena de mayor a menor

SORTED
tambien ordena, pero tambien devuelve el array ordenado
x=sorted(arr)

LIST
deletrea una cadena
list("cadena")

'''

# LIBRERIAS

'''
las librerias estandar solo necesitan importarse

import random as rd  #se le pone un alias
from random * # para asegurarse de que la libreria se importe completa

las librerias de terceros deben instalarse

RAINDINT

from random import * 
n=randint(1,6)
print(n)

RANDRANGE
n=randrange(10) #comienza en 0 hasta el 9, no incluye el extremo

n=randrange(0,100,10) # del 1 al 100 con saltos de 10

UIFORM
n=uniform(1,10) #si se incluyen los dos extremos



CHOICE
saca un caracter aleatorio, si se le manda una lista, selecciona un elemento aleatorio

from random import *
n=choice("cadena")
print(n)

SAMPLE
saca n elementos aleatorios sin que se repitan, tambien los caracteres de una cadena

from random import *
lista=["a","b","c","d","e"]
n=sample(lista,3)

print(n)

SHUFFLE (no retorna)
reordena una cadena, tipo barajear
shuffle("cadena o lista")

¡¡¡video 27

CHOICE
otra forma mas sencilla de que devuelva un elemento 
aleatorio de una lista

from random import *
lista=["ale","bbeto","mmaru"]
palabra=choice(lista)
print (palabra)


#CONDICIONALES

variable=10

if variable>10:
    print("mayor")
elseif variable<10:
    print("menor")
else:
    print("otro")



#BUCLE FOR
#ojo, var es la variable que va a tomar cada uno de los elementos del iterable
'''

'''fam = ["a","b","c"]
for var in fam :
    print(var)
    
#al parecer a 5 se poner como range para que se vuelva iterable
var=5
for var in range(var) :
    print(var)


arr=["","",""]
var=len(arr)
for var in range(var) :
    print(str(var) + "ultimo")'''


x=100.25
y=10

print(int(x/y))






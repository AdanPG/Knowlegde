'''Funciones



'''
'''
#no devuelve valor
#podria tener argumentos opcionales: (a=0,b=0)
def myFunction(a,b):
    c=float(a)+float(b)
    print('la suma es: ' + str(c))


#llamada a ka funcion
myFunction(250,350)'''


#funcion que devuelve valor
def myFunction1(a,b):
    c=float(a)+float(b)
    return c


print('el valor calculado es: ' +str( myFunction1(5,7)))

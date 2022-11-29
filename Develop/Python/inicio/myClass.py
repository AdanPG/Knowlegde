'''METODOS ESPECIALES
existen muchos, uno de los mas importantes es el constructor:

__init__()  constructor, inicializa y valida informacion, x general
__del()     destructor


'''


class claFraccion:
    numerador=0
    denominador=0



    def __init__(self,_num,_den):
        #valida que los numeros sean enteros, si el parametro se iguala a algo quedara
        #como OPCIONAL
        if isinstance(_num,int):
            self.numerador=_num
            self.denominador=_den
        
        #el denominador no debe ser 0
        if isinstance(_den,int) and _den!=0:
            self.numerador=_num
            self.denominador=_den

    def __del__(self):
        #en el destructor pueden ir conexiones a bd, etc. No siempre se destruyen los objetos al 
        #final, sino cuando se dejan de referenciar
        print('destruyendo objetos')


    def __str__(self):
        #otro metodo especial, se ejecuta cuando se muestra o imprime algo. dentro de la clase
        #no es recomendable ejecutar un print, aqui se hace por practicidad.

        '''definiendo un metodo __str__ le estamos diciendo a la clase que tome este metodo para
        que imprima algo al hacer print(clase). es como sobreescribir el metodo toString()'''
        print('destruyendo objetos')

    
    '''
    def defMultiplicar(self, fra):
        self.numerador=self.numerador*fra.numerador
        self.denominador=self.denominador*fra.denominador
        #el resultado tiene que ser de tipo claFraccion
        r=claFraccion(self.numerador,self.denominador)
        return r
    #SOBECARGA de operadores
    si hicieramos f1*f1 saldria un error, porque el perador * no esta sobrecargado o
    definido. en cambio si cambiamos defImprimir(self) por __mul(self), ahora si se podra
    utilizar directo el *
    
    suma sobrecarga:            __add__
    resta sobrecarga:           __sub__
    division sobrecarga:        __div__
    multiplicacion sobrecarga:  __mul__
    igual sobrecarga:           __eq__
    menor sobrecarga:           __lt__
    mayor que sobrecarga:       __gt__
    
    ejemplo
    '''
    def __mul__(self, fra):
        self.numerador=self.numerador*fra.numerador
        self.denominador=self.denominador*fra.denominador
        #el resultado tiene que ser de tipo claFraccion
        r=claFraccion(self.numerador,self.denominador)
        return r

    def defSuma(self,fra):
        self.numerador=self.numerador*fra.denominador + fra.numerador*self.denominador
        self.denominador=self.denominador*fra.denominador
        r=claFraccion(self.numerador,self.denominador)
        return r

    def defResta(self,fra):
        self.numerador=self.numerador*fra.denominador - fra.numerador*self.denominador
        self.denominador=self.denominador*fra.denominador
        r=claFraccion(self.numerador,self.denominador)
        return r
        
    
#OJOOOO, tecnicas avanzadas
    def defImprimir(self):
        print(self.numerador, '/', self.denominador)

    #esto es como sobreescribirle el toString a la clase, manda a print(clase)
    def __str__(self):
       return str(self.numerador) + '/' + str(self.denominador)





#inicia main
#instanciamos la clase, entonces la instancia f1 tendra acceso a los
#metodos, f2 solo para que sea tipo claFracion

print('**************************************************************')
print('bienvenido a las operaciones con fracciones')
print('**************************************************************')


num1=int(input('proporcione el numerador de la primera fraccion: '))
den1=int(input('proporcione el denominador de la primera fraccion: '))

num2=int(input('proporcione el numerador de la segunda fraccion: '))
den2=int(input('proporcione el denominador de la segunda fraccion: '))




f1=claFraccion(num1,den1)
f2=claFraccion(num2,den2)


#como el metodo devuelve una fraccion, al igualar x se convierte en fraccion,
#entonces ya cuenta tambien con un metodo defimprimir
ope=int(input('Selecciona la operacion a realizar: 1=suma, 2=resta,3=multiplicacion: '))
ope1=''

if ope==1:
    x=f1.defSuma(f2)
    print('\n')
    ope1='suma'

elif ope==2:
    x=f1.defResta(f2)
    print('\n')
    ope1='resta'
elif ope==3:
    x=f1.defMultiplicar(f2)
    print('\n')
    ope1='multiplicacion'
    print('')
else:
    print('seleccion no valida')


print('el resultado de la ', ope1,' es: ', )
res=x.defImprimir()

#utiliza el __str__
print(f1)

#osobrecarga
print('sobrecarga de la multiplicacion: ',f1*f2)

print('**************************************************************')
input('presiona una tecla para terminar')



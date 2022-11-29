'''
class claAnimal:
    #atributos de clase, atributos generales que heredara
    #cualquier instancia
    patas=4


    #CONSTRUCTOR para definir valores de clase, self es 'el mismo', es un parametro default
    def __init__ (self, _tipo, _raza):
        self.tipo=_tipo
        self.raza=_raza
        

    def defRuido(self):
        #ojo, para utilizar las variables de clase se pone antes self.
        if self.tipo=='perro':
            print('gua gua')






animal1=claAnimal('perro', 'doberman')
print('la clase dice: soy ' + animal1.tipo + ' , ' +  \
    animal1.raza + ' , ' + str(animal1.patas)  + ' patas')

print(animal1.defRuido())
'''




#OTRA CLASE DE EJEMPLO
'''ESTA CLASE ES PARA HACER UNA MULTIPLICACION DE FRACCIONES
no perder de vista que se deben crear dos objetos de tipo claFraccion para 
poder realizar la operacion, pues en esta se busca el numerador y el denominador

si se pasa por ejemplo 3/2 lo va a tomar como 1.5, al igual que el resultado, debe
ser de tipo fraccion

'''


class claFraccion:
    def __init__(self,num,den):
        #aqui ya esta pasando los valores cuando inicializa
        self.num=num
        self.den=den

    def imprime(self):
        print(self.num, '/',self.den)
    
    def multiplicar(self,b):
        #self.num y self.den ya estan definifos al inicializar 
        n=self.num*b.num
        d=self.den*b.den
        r=claFraccion(n,d)
        return r


#INICIAL EL MAIN

#a de tipo claFraccion 3/2
a=claFraccion(3,2)
#b de tipo fraccion 7/4
b=claFraccion(7,4)
#llama al metodo desde a
res=a.multiplicar(b)

#ya que r tambien es de tipo quebrado
res.imprime()
input()


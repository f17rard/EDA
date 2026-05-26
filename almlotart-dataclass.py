from dataclasses import dataclass

"""Crea un valueobject, es decir, una clase que
se utiliza para almacenar datos y no tiene
comportamiento adicional. El decorador @dataclass
genera automáticamente métodos como __init__,
__repr__, __eq__, entre otros, basados en los
atributos definidos en la clase."""
"""cada uno de estos metodos hace que la clase
sea mas facil de usar, por ejemploel metodo __eq__
hace que se puedan comparar dos objetos de la clase
por su valor, en lugar de por su identidad, lo que
es muy útil para las clases que se utilizan
principalmente para almacenar los datos. El decorador
@dataclass también puede generar un método __init__
automáticamente, lo que hace que sea más fácil crear
instancias de la clase sin tener que escribir un
constructor manualmente. Además, el método __repr__
generado por @dataclass proporciona una representación
legible de la instancia de la clase, lo que facilita la
depuración y el registro de información. En resumen, el
decorador @dataclass es una herramienta poderosa para
simplificar la creación de clases que se utilizan
principalmente para almacenar datos, ya que genera
automáticamente métodos útiles y reduce la cantidad
de código que se necesita escribir."""



class AlumnoSinDecorador:
    def __init__(self, carnet: str, nombre: str):
        self.carnet = carnet
        self.nombre = nombre

Alumno1 = AlumnoSinDecorador("20230001", "Juan Pérez")
Alumno2 = AlumnoSinDecorador("20230001", "Juan Pérez")
print(Alumno1.nombre + " " + Alumno1.carnet)
print(Alumno1==Alumno2)

"""Constructor, __repr__, __eq__ y hace la clase inmutable
osea le pone doble candado a los atributos y modificaciones"""
@dataclass(frozen=True) 
class AlumnoConDecorador:
    carnet: str
    nombre: str

alumno3 = AlumnoConDecorador("20230001", "Juan Pérez")

@dataclass 
class Articulo:
    sku: str
    nombre: str

print(Alumno1)
print(alumno3)



"""si cambiar su valor no hace que sea igual, entonces
no se ocupa el decorador dataclass """

art1 = Articulo("A01", "Zapatos")
art2 = Articulo("A01", "Zapatos")
print(art1)
print(art1==art2)
print(id(art1))
print(id(art2))
print(id(art1) == id(art2))


"""Este true se debe a que el decorador @dataclass genera
automáticamente el método __eq__, si se comparan por id 
seria falso, mientras si se comparan por value object, es
verdadero.
permite modificar el comportamiento de funciones y clases"""

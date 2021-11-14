# Factory method
Es un patr�n creacional. [Link descripci�n](https://sourcemaking.com/design_patterns/factory_method)

El factory method es un m�todo, generalmente est�tico, con el objetivo de devolver instancias concretas de una interfaz conocida.

## Diagrama de clases
![UML](factory_method.jpg)

## SOLID

* Single responsibility

El factory method tiene como responsabilidad generar instancias de clases que implementen una interfaz com�n

* Open/Closed principle

Es dificil cumplir este principio ya que al crearse nuevas implementaciones de la interfaz responsabilidad del factory method, el m�todo debera modificarse para incluir los nuevos casos de uso.

* Liskov substitution 

Cualquier clase que implemente la interfaz puede ser intercambiada sin consecuencias, de hecho es uno de los principios de utilizar un factory method, generar independencia entre el cliente y la implementaci�n de la interfaz necesitada

* Interface segregation

Un buen modelado de clases deber�a permitir segregaci�n de interfaces en el factory method.

* Dependency inversi�n

Ya que el cliente solo necesita conocer la interfaz devuelta por el factory method esto se cumple, aunque no tengo muy claro si la dependencia del factory method en s� con las implementaciones cuenta como violaci�n del principio.
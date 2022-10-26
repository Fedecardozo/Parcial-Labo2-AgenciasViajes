#  <img src="Imgenes/crucero.png" width="30" height="30">  Cruzeiro    
## Parcial de Laboratorio 2 agencia de cruceros


#### Presentación:

Me presento, soy Federico Cardozo tengo 24 años, estoy estudiando programación en la UTN FRA. Actualmente estoy cursando el segundo cuatrimestre
en el cual para su aprobación hago este proyecto. En el cual como expierencia se me hizo muy completo para seguir aprendiendo y seguir perfeccionandome
profesionalmente, fue un desafio que me llevo bastante tiempo desarrollar pero en cual me diverti, me frustre y aprendi sobre todas las cosas.

#### Aplicación: 
##### La aplicación hace que un vendedor de la empresa de viajes de cruceros pueda realizar las siguientes acciones:
* Se pueda loguear con su usuario y contraseña
* Ver el historial de viajes
* Ver los viajes disponibles                          
* De cada viaje poder ver la lista de pasajeros
* Poder crear nuevos viajes
* Consultar datos estadisticos. Como por ejemplo el destino mas elegido.

## Diagrama estructura
<img src="https://user-images.githubusercontent.com/47437164/197897914-67d5eeaf-5172-4c71-a6ab-24c7fece7fca.png">

## Entidades
![Diagrama](https://user-images.githubusercontent.com/47437164/197908193-49ef9719-25f9-48a6-be3b-303457838152.png)

## Diagrama de viaje y crucero
<img src="https://user-images.githubusercontent.com/47437164/197899168-20a9f477-36d8-461f-9db5-473cc4175048.png" width="700" height="700">

### Clases y métodos estáticos
Lo aplique en las siguientes clases:
1. HistorialViajes
2. Harcodeo
3. Aleatorio

Aplique en estas clases porque no es necesario que se instancien para poder usarlas. En la clase **Harcodeo** aproveche para que se carguen
los datos ya en memoria.

### Colecciones
Use las siguientes colecciones:
1. **List<>**
2. **Dictionary<string, Usuario>**

Aplique la colección **List<>** para cargar las clases **Viaje**, **Crucero** y **Pasajero**. Para que el uso se mucho mas facil usuarlo. 
Aplique la colección **Dictionary<string, Usuario>** para cargar varios usuarios con **Key** como password para el harcodeo

### Herencia
Lo aplique en la clase **Pasaporte** que hereda de **Persona** para ahorrar codigo ya que comparten varios de sus atributos.

### Clases abstractas
Las clases abstractas aplique en **Persona** y **Viaje**. Son clases que no se instancian por lo cual para poder hacer uso de ellas 
se necesitan que se herenden para su implementación.

### Polimorfismo
Lo aplique en la clase **Viaje** ya que sus hijos pueden sobreecribir sus metodos y propiedades para que puedan tomar diferente forma
y sin embargo no dejan de ser una viaje


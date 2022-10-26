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
* Cargar pasajeros (validando que haya lugar en el crucero)                         
* De cada viaje poder ver la lista de pasajeros
* Poder crear nuevos viajes
* Consultar datos estadisticos. Como por ejemplo el destino mas elegido.

## Diagrama de clases
![Diagrama](https://user-images.githubusercontent.com/47437164/197908193-49ef9719-25f9-48a6-be3b-303457838152.png)

## Diagrama de viaje y crucero
<img src="https://user-images.githubusercontent.com/47437164/197899168-20a9f477-36d8-461f-9db5-473cc4175048.png" width="700" height="700">

## Temas

### Tema uno
Se utiliza a lo largo de todo el proyecto operadores lógicos, iteraciones y diversos tipos de datos.

### Tema dos: Clases y métodos estáticos
Lo aplique en las siguientes clases:
1. HistorialViajes
2. Harcodeo
3. Aleatorio
4. Viaje

Aplique en estas clases porque no es necesario que se instancien para poder usarlas. En la clase **Harcodeo** aproveche para que se carguen
los datos ya en memoria.

### Tema tres: Programación orientada a objetos
La programación orientada a objetos es lo principal en este proyecto es la base. En la clase Viaje y Crucero son las mas extensas y relevantes, ya que de ellas dependen principalmente el funcionamiento de este proyecto.

### Tema cuatro: Sobrecargas
Utilice las sobrecargas en los constructores y en los operadores.

### Tema cinco: Windows Forms
Lo use para reprensentar graficamente el proyecto. Use formularios modales ya que no queria que iteractue con las otras ventanas sin haber terminado con el nuevo formulario que se abrio.

### Tema seis: Colecciones
Use las siguientes colecciones genericas:
1. **List<>**
2. **Dictionary<string, Usuario>**

Aplique la colección **List<>** como fuerte. ya que me permite recorrer e iteracturar agregando, quitando y modificando sus elementos dinamicamente.
Aplique la colección **Dictionary<string, Usuario>** para cargar varios usuarios con **Key** como password para el harcodeo

### Tema siete: Encapsulaminento
En la mayoria de las clases sus atributos son privados y en algunas clases tiene atributos protected ya asi impidiendo la modificación asi que la unica manera de poder modificar sus atributos es a traves de los Setters y los protected en sus clases derivadas. 
La mayoria de los metodos son publicos pero también hay metodos privados y algunos protected.

### Tema ocho: Herencia 
Lo aplique en la clase **Pasaporte** que hereda de **Persona** para ahorrar codigo ya que comparten varios de sus atributos.
También lo aplique en Herencia de formularios todos eran de un mismo formulario para mantener la misma fuentes y colores. A mi gusto se podria haber hecho mejor pero ya habia creado los otros formularios. 
En los formularios de viaje que utilizan el dataGridViews también aplique herencia de formulario ya que en tres formularios era lo misma forma de mostrar no más que cambiaban sus datos. 

##### Clases abstractas
Las clases abstractas aplique en **Persona** y **Viaje**. Son clases que no se instancian por lo cual para poder hacer uso de ellas 
se necesitan que se herenden para su implementación.

### Tema nueve: Polimorfismo
Lo aplique en la clase **Viaje** ya que sus hijos pueden sobreecribir sus metodos y propiedades para que puedan tomar diferente forma
y sin embargo no dejan de ser una viaje

## Cuentas para loguearse
1. **Primer usuario** 
    - **Usuario:** *admin*
    - **Contraseña:** *admin*
2. **Segundo usuario** 
    - **Usuario:** *admin2*
    - **Contraseña:** *admin2*
3. **Tercer usuario**
    - **Usuario:** *admin3*
    - **Contraseña:** *admin3*
4. **Cuarto usuario**
    - **Usuario:** *admin4*
    - **Contraseña:** *admin4*



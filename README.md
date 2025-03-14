# Scripting

## Taller 2

### Integrantes

Rey Valentin Arias Perez

Pascualtobias Rendon

a

## Preguntas teóricas:

### ¿Qué son los principios SOLID? 

Son un conjunto de reglas y mejores practicas a seguir al diseñar una estructura de clase.

* Single Responsability Principle (SRP).

* Open-Closed Principle (OCP).

* Liskov Substitution Principle (LSP).

* Interface Segregation Principle (ISP).

* Dependency Inversion Principle (DIP).

#### ¿Cómo contribuyen a un buen diseño orientado a objetos?

Ayudan a comprender la necesidad de ciertos patrones de diseño y arquitectura de software.

### ¿Cómo el patrón Singleton asegura que solo haya una instancia de una clase

* **Constructor privado:** Evita que se cree la instancia desde fuera de la clse.

* **Metodo estatico:** Crea o devuelve la unica instancia de la clase.

#### Posibles usos:

* **Manejo de configuracion global:** Un solo objeto que maneje toda la configuracion de la aplicacion.

* **Conexiones a bases de datos:** Evita multiples conexiones innecesarias.

* **Gestion de recursos compartidos:** Como un logger, evitando que se dupliquen los objetos.

### ¿Cómo funciona el patrón Observer? 

Se crean 2 tipos de objetos, un sujeto y uno o varios observadores.

* **Sujeto:** Objeto que contiene el estado. Se encarga de notificar cuando hay un cambio.

* **Observadores:** Objetos que son informados de los cambios del sujeto. Cuando ocurre un cambio, son llamados a traves de un metodo-


#### ¿En qué situaciones es útil?

* **Interfaces graficas:** En aplicaciones donde varios elementos de la interfaz se actualizan automaticamente, segun cambios en el estado.

* **Sistemas de eventos:** Notificar automaticamente sobre eventos, como aplicaciones de mensajeria o notificacion en tiempo real.

* **Publicacion/Suscripcion:** En sistemas como redes sociales, donde los usuarios se suscriben a contenido o reciben actualizaciones automaticamente.

### ¿Qué es un antipatrón?

Es una solucion de diseño o implementacion que parece correcta al principio, pero con el tiempo genera problemas como mal rendimiento, dificultad de mantenimiento, escalabilidad.

#### Ejemplos:

* a

* a


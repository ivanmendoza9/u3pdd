# Patron Composite

## Introduccion
Este programa implementa el patrón de diseño Composite para simular el armado de una PC gamer. El objetivo es permitir que el usuario seleccione distintos componentes de diferentes gamas y calcular el costo total de forma estructurada.

## Qué es el patrón Composite?

El patrón Composite permite tratar objetos individuales y grupos de objetos de la misma manera. Es útil cuando se trabaja con estructuras jerárquicas en forma de árbol.

Dentro de este proyecto:

Un componente individual → RAM
Un conjunto de componentes → toda la PC

## Estructura del programa

1. Clase ComponentePC:
   
Define la estructura base del sistema. Todas las piezas de la PC heredan de esta clase.
<img width="728" height="163" alt="image" src="https://github.com/user-attachments/assets/e549249b-2031-4667-b761-6dd141f5d63f" />

2. Clase ComponenteSimple: 
Representa un componente individual como CPU, GPU, RAM, etc.

✔ Tiene un precio fijo
✔ No contiene otros objetos

3. Clase Composite: 
Es una clase que puede contener otros componentes, ya sean simples o compuestos.

✔ Guarda una lista de componentes
✔ Suma todos los precios

Ejemplo en el programa:

- Componentes internos
- Refrigeración
- Periféricos
- PC completa

4. Clase Program

Aquí es donde el usuario arma la PC seleccionando los componentes.

✔ El usuario elige gama: baja, media o alta
✔ Se agregan los componentes a la estructura
✔ Se calcula el total automáticamente

## Diagrama UML



## Programa en ejecucion:
<img width="1919" height="1079" alt="image" src="https://github.com/user-attachments/assets/71d7f595-2877-4d09-9099-93deaad353d7" />

## Conclusion

El patrón Composite me permitió organizar los componentes de la PC de forma jerárquica, facilitando el cálculo del precio total y haciendo el sistema flexible, escalable y fácil de mantener.

## Referencias

https://www.bing.com/search?pglt=675&q=como+funciona+el+patron+composite&cvid=565675218563483781c684ce5c597a0f&gs_lcrp=EgRlZGdlKgYIABBFGDkyBggAEEUYOTIHCAEQ6wcYQDIGCAIQABhAMgYIAxAAGEAyBggEEAAYQDIGCAUQABhAMgYIBhAAGEAyBggHEAAYQDIGCAgQABhAMggICRDpBxj8VdIBCDY2MTlqMGoxqAIAsAIA&FORM=ANNAB1&PC=U531

https://reactiveprogramming.io/blog/es/patrones-de-diseno/composite

https://chatgpt.com/

https://es.scribd.com/document/446160472/Patrones-de-diseno-Composite

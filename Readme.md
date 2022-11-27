## Práctica 8: Controlador de cámara..
## Objetivo: Desarrollar una escena 2D en la que se incluyan varios personajes, uno de ellos debe considerarse el jugador, que se controlan desde el teclado. Se deben contemplar los siguientes requisitos.

1. Cámara (A) con seguimiento al jugador. Se debe configurar el seguimiento hacia adelante. Esta cámara es la que debe tener la máxima prioridad.

     - Debemos importar el Cinemachine en primer lugar, para luego poder generar desde GameObjects un Cinemachine y asignar una 2D Camera a nuestro personaje que será el zombie en este caso, la prioridad por defecto asignada es 10, pero se le puede configurar, en el atributo Follow de la camara generada es donde asignamos al personaje que queremos que siga la camara.
       
      ![Paso 1](gifs/Ejercicio1.gif)
      
2. Cámara (B) con seguimiento a un grupo de personajes que no sean el jugador. La zona donde no se activa el seguimiento debe ser mayor que la del personaje.

     - Creamos varias copias de los Goblin a los cuales asignaremos un tipo de camara denominada Target Group Camera, se creará un TargetGroup y una camara que tendrá asignado en los parametro Follow y LookAt al TargetGroup, en el TargetGroup haremos referencia a los goblins. Cuando movamos uno de sus objetivos, la posición de la cámara se ajustará en todo momento para mantener a todos los objetivos en pantalla.
     
      ![Paso 2](gifs/Captura1.png)
      
      ![Paso 3](gifs/Ejercicio2.gif)

3. Crear una zona de confinamiento para la cámara A que abarque toda la escena.

     - Creando un GameObject Empty con un Polygon Collider 2D marcando la opción Is Trigger que abarca una zona de la escena, si salimos de la zona la cámara no nos sigue.
      
      ![Paso 4](gifs/Captura2.png)
      
      ![Paso 5](gifs/Ejercicio3.gif)
      
4. Se debe crear una zona de confinamiento de la cámara B que abarque una parte de la escena.

     - Haciendo lo mismo que en el paso anterior, los goblin no se verán a la hora de salir de la zona.
      
      ![Paso 6](gifs/Captura4.png)
      ![Paso 7](gifs/Captura5.png)
      
5. Añadir un objeto que genere una vibración en la cámara cuando A choca con él.

     - Añadiendo el script Cinemachine Collision Impulse source, de modo que cuando nos choquemos con el goblin, se genera una vibración.
     
     ![Paso 8](gifs/Ejercicio4.gif)
      
6. Agregar una tercera cámara (C) que siga a un personaje que no sea el jugador (sólo uno).

     - Agregamos otra cámara (cámara C) para otro personaje de la escena.
      
      ![Paso 7](gifs/Ejercicio5.gif)
      
      ![Paso 8](gifs/gif1.gif)
      
7. Seleccionar un conjunto de teclas que permitan hacer el cambio entre las cámaras A y C . (Habilitar/Deshabilitar el gameobject de la cámara virtual)

     - Desde un script hacemos una referencia a las cámaras virtuales y con los botones 1, 2 y cambiamos la prioridad de las cámaras para cambiar entre ellas.
      
      ![Paso 8](gifs/Captura6.png)
      
      ![Paso 9](gifs/Ejercicio6.gif)
      
8. Extra: Generar una vibración en la cámara cada vez que se pulse la tecla de disparo. Agregar un perfil de ruido a la cámara, y modificar las propiedades de amplitud y frecuencia al component Noise.

     


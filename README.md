# Introducción a la programación de juegos 2D. Cámara.
## Ginés Cruz Chávez

1. Instalar el paquete CineMachine y configurar 2 cámaras virtuales con diferentes zonas de seguimiento al jugador. Mostar el efecto mediante un gif animado. 

![ej1](imgs/ej1.gif)

2. Define un área de confinamiento diferente para cada una de las dos cámaras de la tarea anterior. Realiza una prueba de ejecución con el correspondiente gif animado que permita ver las diferencias.

![ej2](imgs/ej2.gif)

3. Agrega varios sprites en la escena que estén realizando un movimiento (mínimo 3). Genera una cámara adicional que le haga el seguimiento a dichos objetos.

![ej3](imgs/ej3.png)

![ej3](imgs/ej3.gif)

4. Agrega 2 sprites adicionales en la escena que estén realizando un movimiento. Genera una cámara adicional que le haga el seguimiento a dichos objetos, cada uno con un peso en la importancia del seguimiento diferente.

![ej4](imgs/ej4.png)

![ej4](imgs/ej4.gif)

5. Implementar un zoom a la cámara del jugador que se controle con las teclas w-s

![ej5](imgs/ej5.gif)

Script: [CameraZoom.cs](scripts/CameraZoom.cs)

6. Seleccionar un conjunto de teclas que permitan hacer el cambio entre dos cámaras. (Habilitar/Deshabilitar el gameobject de la cámara virtual)

![ej6](imgs/ej6.gif)

Script: [ToggleCameras.cs](scripts/ToggleCameras.cs)

7. Crear un script para activar la cámara lenta cuando el personaje entre en colisión con un elemento de la escena que elijas para activar esta propiedad.
Crear un script para activar la cámara rápida cuando el personaje entre en colisión con un elemento de la escena que elijas para activar esta propiedad. 

![ej7](imgs/ej7.gif)

Script: [TimeTrigger.cs](scripts/TimeTrigger.cs)

8. Crear un script para intercambiar la cámara activa, una estará confinada y la otra no cuando el personaje entre en colisión con un elemento de la escena que elijas para realizar el intercambio.

Modificamos los parámetros de Cinemachine Blend:

![ej8_blend](imgs/ej8_blend.png)

![ej8](imgs/ej8.gif)

Script: [CameraSwitchTrigger.cs](scripts/CameraSwitchTrigger.cs)
# Definición

. Las repetitivas Do-While (también llamadas bucles post-condicionales) son estructuras de control que permiten ejecutar un bloque de instrucciones al menos una vez, y luego repetirlo mientras se cumpla una condición lógica.

. La principal diferencia con el while tradicional es el orden de evaluación de la condición:

. En while, primero se verifica la condición y luego se ejecuta el bloque si se cumple.

. En do-while, primero se ejecuta el bloque y después se evalúa la condición.

. En un do-while el bloque se ejecuta mínimo una vez, incluso si la condición es falsa desde el principio.

## Explicacion de los ejemplos

# Csharp

### Ejercicio 1

. Se inicializa i en 1.

. El bloque dentro del do se ejecuta al menos una vez.

. Después de mostrar el número, se incrementa i.

. Mientras i <= 5, el ciclo se repite.

### Ejercicio 2

. El menú se muestra al menos una vez gracias al do-while.

. Si el usuario elige 1 o 2, se ejecuta una acción.

. El ciclo solo termina cuando el usuario elige la opción 3.

# Python

### Ejercicio 1

. Se usa while True para garantizar que el bloque se ejecute al menos una vez.

. En cada iteración se muestra el número y se incrementa i.

. Cuando i supera 5, se usa break para salir del bucle.

### Ejercicio 2

. El menú siempre aparece al menos una vez.

. El ciclo sigue ejecutándose mientras el usuario no elija 3.

. Se usa break para salir cuando se cumple la condición de salida.
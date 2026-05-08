//Ejercicio 4: Producto Escalar
//Un sistema físico analiza dos conjuntos de fuerzas aplicadas sobre una estructura metálica. Cada fuerza está representada mediante un vector de tamaño 5. El objetivo es calcular el producto escalar entre ambos vectores para analizar su comportamiento.
//Instrucciones
//Crear dos arreglos.
//Recorrer ambos vectores utilizando un ciclo for.
//Multiplicar las posiciones correspondientes.
//Acumular el resultado de cada multiplicación.
//Mostrar el producto escalar total en pantalla.
Console.Clear();
int[] vector1 = new int[5];
int[] vector2 = new int[5];
Console.WriteLine("Por favor ingrese los valores del primer vector:");
for (int i = 0; i < vector1.Length; i++)
{
    try
    {
        Console.Write($"Valor {i + 1}: ");
        vector1[i] = int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Por favor ingrese un número entero válido.");
        i--; // Decrementar el índice para volver a solicitar el valor
        Console.ResetColor();
    }
}
Console.WriteLine("Por favor ingrese los valores del segundo vector: ");
for (int i = 0; i < vector2.Length; i++)
{
    try
    {
        Console.Write($"Valor {i + 1}: ");
        vector2[i] = int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Por favor ingrese un número entero válido.");
        i--; // Decrementar el índice para volver a solicitar el valor
        Console.ResetColor();
    }
}
//Calcular el producto escalar
int productoEscalar = 0;
for (int i = 0; i < vector1.Length; i++)
{
    productoEscalar += vector1[i] * vector2[i];
}
//Mostrar el producto escalar total
Console.WriteLine($"El producto escalar entre los dos vectores es: {productoEscalar}");

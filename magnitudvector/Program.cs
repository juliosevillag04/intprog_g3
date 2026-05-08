//Ejercicio 3: Magnitud de un vector
//Un robot industrial realiza movimientos en cinco direcciones diferentes dentro de una planta automatizada. El equipo de ingeniería necesita calcular la magnitud total del vector de movimiento para validar la trayectoria recorrida.
Console.Clear();
int [] vector = new int[5];
Console.WriteLine("Por favor ingrese los valores del vector de movimiento: ");
for (int i = 0; i < vector.Length; i++)
{
    try
    {
        Console.Write($"Valor {i + 1}: ");
        vector[i] = int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Por favor ingrese un número entero válido.");
        i--; // Decrementar el índice para volver a solicitar el valor
        Console.ResetColor();
    }
}

//Calcular la magnitud del vector
double magnitud = 0;
for (int i = 0; i < vector.Length; i++)
{
    magnitud += Math.Pow(vector[i], 2);
}
magnitud = Math.Sqrt(magnitud);
//Mostrar la magnitud del vector
Console.WriteLine($"La magnitud del vector de movimiento es: {magnitud:F2}");
Console.Clear();
int[] vector1 = new int[5];
int[] vector2 = new int[5];
int[] vectorSuma = new int[5];
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
//Summar los vectores
for (int i = 0; i < vectorSuma.Length; i++)
{
        vectorSuma[i] = vector1[i] + vector2[i];
}

//Mostrar arreglo resultante
Console.WriteLine("Suma de los vectores: ");
for (int i = 0; i < vectorSuma.Length; i++)
{
    Console.ForegroundColor=ConsoleColor.Green;
    Console.WriteLine($"Valor {i + 1}: {vectorSuma[i]}");
}
Console.ResetColor();
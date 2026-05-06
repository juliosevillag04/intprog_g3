//Crea un arreglo de notas de 15 estudiantes, luego calcula el promedio de las notas y los 3 primeros lugares. No se puede ingresar notas menores a 0 ni mayores a 100.
int [] notas = new int[15];
int suma = 0, conterror = 0;
double promedio = 0;
for (int i = 0; i < notas.Length; i++)
{
    if (conterror >= 3)
    {
        Console.ForegroundColor=ConsoleColor.DarkRed;
        Console.WriteLine("Has cometido demasiados errores, es normal, te recomiendo descansar.");
        Console.ResetColor();
    }
    try
    {
        Console.WriteLine("Ingrese la nota del estudiante " + (i + 1) + ":");
        int nota = int.Parse(Console.ReadLine()!);
        if (nota < 0 || nota > 100)
        {
            throw new ArgumentOutOfRangeException("La nota debe estar entre 0 y 100.");
        }
        notas [i] = nota;
        
    }
    catch (FormatException)
    {
        Console.ForegroundColor=ConsoleColor.Red;
        Console.WriteLine("Por favor, ingrese un número válido.");
        i--; // Para volver a pedir la misma posición
        Console.ResetColor();
        conterror++;
    }
    catch (ArgumentOutOfRangeException ex)
    {
        Console.ForegroundColor=ConsoleColor.Red;
        Console.WriteLine(ex.Message);
        conterror++;
        i--; // Para volver a pedir la misma posición
        Console.ResetColor();
    }
}

foreach(int nota in notas)
{
    suma += nota;
}
Console.WriteLine($"Suma: {suma}");
Console.WriteLine($"Cantidad de notas: {notas.Length}");
promedio = (double)suma / notas.Length;
Console.WriteLine($"Promedio: {promedio:F2}");

Array.Sort(notas);
Array.Reverse(notas);
for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Lugar {i + 1}: {notas[i]}");
}
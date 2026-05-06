//Almacenar 10 edades en un arreglo, luego calcular el promedio de edad, luego el máximo y el mínimo.
//crear arreglo de edades
int[] edades = new int[10];
//Pedir edades
for (int i = 0; i < edades.Length; i++)
{
    try
    {
        Console.WriteLine("Ingrese la edad " + (i + 1) + ":");
        edades[i] = int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        Console.ForegroundColor=ConsoleColor.Red;
        Console.WriteLine("Por favor, ingrese un número válido.");
        i--; // Para volver a pedir la misma posición
        Console.ResetColor();
    }
}

//Calcular promedio maximo y minimo
int suma = 0, maximo = edades[0], minimo = edades[0];
foreach (int edad in edades)
{
    suma += edad;
    if (edad > maximo) maximo = edad;
    if (edad < minimo) minimo = edad;
}
double promedio = (double)suma / edades.Length;
//Mostrar resultados
Console.WriteLine("El promedio de edad es: " + promedio);
Console.WriteLine("La edad máxima es: " + maximo);
Console.WriteLine("La edad mínima es: " + minimo);
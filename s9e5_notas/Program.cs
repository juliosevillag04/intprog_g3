//Ejercicio 5
//Notas de Estudiantes
//Un profesor necesita almacenar las calificaciones finales de sus estudiantes.
//El programa debe:
//Solicitar las notas de 8 estudiantes.
//Guardar las notas en un arreglo unidimensional.
//Mostrar únicamente las notas aprobadas. Se aprueba con 70
//Contar cuántos estudiantes reprobaron.
//Calcular el promedio general del grupo.
Console.Clear();
double [] notas = new double [8];
double totalnotas=0, promedio;
int reprobados=0;
Console.WriteLine("NOTAS");
for (int i=0 ; i<notas.Length ; i++)
{
    try
    {
        Console.Write($"Estudiante #{i+1}: ");
        notas[i]=double.Parse(Console.ReadLine()!);
        // Validar rango
        if (notas[i] < 0 || notas[i] > 100)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("La nota debe estar entre 0 y 100");
            Console.ResetColor();

            i--;
            continue;
        }
        totalnotas+=notas[i];
        if (notas[i]<70) reprobados++;
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Por favor ingrese un número válido");
        i--; 
        Console.ResetColor();
    }
    
}

promedio=totalnotas/notas.Length;

Console.Clear();
Console.WriteLine("Aprobados");
for (int i=0 ; i<notas.Length ; i++)
{
    if (notas[i]>=70)
    {
        Console.WriteLine($"Estudiante #{i+1}: {notas[i]}");
    }
}

Console.WriteLine($"\nReprobados: {reprobados}");
Console.WriteLine($"Promedio: {Math.Round(promedio, 2)}");
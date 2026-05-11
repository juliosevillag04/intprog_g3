//Ejercicio 1
//Temperaturas de la Semana
//Una estación meteorológica necesita registrar las temperaturas máximas de 7 días.
//El programa debe:
//Solicitar al usuario las 7 temperaturas.
//Guardar los datos en un arreglo unidimensional.
//Mostrar todas las temperaturas registradas.
//Calcular el promedio semanal.
//Indicar la temperatura más alta y la más baja.
Console.Clear();
double [] temp = new double [7];
double sumatemp = 0;
Console.WriteLine("ESTACIÓN METEOROLÓGICA");
for (int i=0 ; i< temp.Length ; i++)
{
    try
    {
        Console.Write($"Día #{i+1}: ");
        temp[i]=double.Parse(Console.ReadLine()!);
        sumatemp += temp[i];
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Por favor ingrese un número válido");
        i--; 
        Console.ResetColor();
    }
}
double promedio = sumatemp/temp.Length;

double mayor = temp[0];
double menor = temp[0];

for (int i = 0; i < temp.Length; i++)
{
    if (temp[i] > mayor)
    {
        mayor = temp[i];
    }

    if (temp[i] < menor)
    {
        menor = temp[i];
    }
}
Console.Clear();
Console.WriteLine("TEMPERATURAS REGISTRADAS");

for (int i = 0; i < temp.Length; i++)
{
    Console.WriteLine($"Día #{i + 1}: {temp[i]}°C");
}

Console.WriteLine($"\nPromedio semanal: {Math.Round(promedio,2)}");
Console.WriteLine($"Temperatura más alta: {mayor}");
Console.WriteLine($"Temperatura más baja: {menor}");
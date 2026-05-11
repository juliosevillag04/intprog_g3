//Ejercicio 2
//Ventas de una Tienda
//Una tienda desea registrar las ventas diarias de una semana.
//El programa debe:
//Solicitar al usuario las ventas de cada día.
//Guardar las ventas en un arreglo.
//Calcular el total vendido.
//Mostrar cuántos días las ventas superaron 150.
//Indicar la venta más baja registrada.
Console.Clear();
int num_ventas = -1;

while (num_ventas < 0)
{
    try
    {
        Console.Write("Número de ventas diarias: ");
        num_ventas = int.Parse(Console.ReadLine()!);

        if (num_ventas < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error. Ingrese un número válido.");
            Console.ResetColor();
        }
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error. Ingrese un número entero válido.");
        Console.ResetColor();

        num_ventas = -1;
    }
}

if (num_ventas == 0)
{
    Console.WriteLine("Sin ventas");
}
else
{
    double[] ventas = new double[num_ventas];
    double sumaventas = 0;

    for (int i = 0; i < ventas.Length; i++)
    {
        try
        {
            Console.Write($"Venta #{i + 1}: ");
            ventas[i] = double.Parse(Console.ReadLine()!);
            sumaventas += ventas[i];
        }
        catch (FormatException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Por favor ingrese un número válido");
            i--;
            Console.ResetColor();
        }
    }

    Console.WriteLine($"Total vendido: {sumaventas}");
}
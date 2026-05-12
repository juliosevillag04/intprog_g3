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
int num_ventas;

// Validar cantidad de ventas
Console.Write("Número de ventas diarias: ");

while (!int.TryParse(Console.ReadLine(), out num_ventas) || num_ventas < 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Error. Ingrese un número entero válido.");
    Console.ResetColor();

    Console.Write("Número de ventas diarias: ");
}

if (num_ventas == 0)
{
    Console.WriteLine("Sin ventas");
}
else
{
    double[] ventas = new double[num_ventas];
    double sumaventas = 0;
    int dias = 0;

    for (int i = 0; i < ventas.Length; i++)
    {
        Console.Write($"Venta #{i + 1}: ");

        while (!double.TryParse(Console.ReadLine(), out ventas[i]) || ventas[i] < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Por favor ingrese una venta válida. No puede ser negativa.");
            Console.ResetColor();

            Console.Write($"Venta #{i + 1}: ");
        }

        if (ventas[i] > 150)
        {
            dias++;
        }

        sumaventas += ventas[i];
    }

    double ventabaja = ventas[0];

    for (int i = 0; i < ventas.Length; i++)
    {
        if (ventas[i] < ventabaja)
        {
            ventabaja = ventas[i];
        }
    }

    Console.Clear();
    Console.WriteLine("==================");
    Console.WriteLine("RESUMEN DE VENTAS");
    Console.WriteLine("==================");
    Console.WriteLine($"Total vendido: C${sumaventas}");
    Console.WriteLine($"Días de ventas de más de C$150: {dias}");
    Console.WriteLine($"Venta más baja: C${ventabaja}");
}
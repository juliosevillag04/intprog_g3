//Ejercicio 4
//Inventario de una Librería
//Una librería necesita registrar las ventas de libros por categoría.
//El programa debe:
//Solicitar la cantidad de libros vendidos en 5 categorías.
//Guardar la información en un arreglo.
//Mostrar el total de libros vendidos.
//Indicar la categoría con más ventas.
//Calcular el promedio de ventas.
Console.Clear();
double [] categoria = new double [5];
double sumalibros=0, promedio;
Console.WriteLine("INVENTARIO DE LIBRERÍA");
Console.WriteLine("Libros vendidos por categorías");
for (int i=0 ; i<categoria.Length ; i++)
{
    try
    {
        Console.Write($"Categoría #{i+1}: ");
        categoria[i]=double.Parse(Console.ReadLine()!);
        sumalibros+=categoria[i];
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Por favor ingrese un número válido");
        i--; 
        Console.ResetColor();
    }
}

double categoria_mayor = categoria[0];
int posicion=0;
for (int i=0 ; i<categoria.Length ; i++)
{
    if (categoria[i] > categoria_mayor)
    {
        categoria_mayor = categoria[i];
        posicion=i;
    }
}

promedio=sumalibros/categoria.Length;

Console.WriteLine($"Libros totales vendidos: {sumalibros}");
Console.WriteLine($"Categoría más alta: #{posicion+1} | {categoria_mayor}");
Console.WriteLine($"Promedio: {Math.Round(promedio,2)}");

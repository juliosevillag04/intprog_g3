//Leer un número entero y mostrar todos sus antecesores elevados al cubo
using Math = System.Math;
Console.Clear();
int numero;
while (true)
{
    Console.Write("Escribe un número: ");
    if (int.TryParse(Console.ReadLine(), out numero))
    {
        break;
    }
    else
    {
        Console.ForegroundColor=ConsoleColor.Red;
        Console.WriteLine("Error. Ingrese un número entero");
        Console.ResetColor();
    }
}
Console.WriteLine("Los antecesores elevados al cubo son:");
int contador = 1;
while (contador<numero)
{
    double cubo = Math.Pow(contador, 3);
    Console.WriteLine($"{contador}^3 = {cubo}");
    contador++;
}
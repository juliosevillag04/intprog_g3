//Ejercicio 3
//Puntajes de un Videojuego
//Un jugador desea almacenar los puntajes obtenidos en diferentes partidas.
//El programa debe:
//Pedir al usuario ingresar 6 puntajes.
//Guardar los datos en un arreglo unidimensional.
//Mostrar el puntaje más alto.
//Ordenar los puntajes de menor a mayor.
//Contar cuántos puntajes son mayores a 500.
Console.Clear();
double [] puntaje = new double [6];
int puntajesgrandes=0;
Console.WriteLine("SCORE");
for (int i=0 ; i<puntaje.Length ; i++)
{
    try
    {
        Console.Write($"Puntaje #{i+1}: ");
        puntaje[i]=double.Parse(Console.ReadLine()!);
        if (puntaje[i]>500) puntajesgrandes++;
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Por favor ingrese un número válido");
        i--; 
        Console.ResetColor();
    }
}

double puntajealto = puntaje[0];
for (int i=0 ; i<puntaje.Length ; i++)
{
    if (puntaje[i] > puntajealto)
    {
        puntajealto = puntaje[i];
    }
}
Console.Clear();
Console.ForegroundColor=ConsoleColor.Green;
Console.WriteLine($"Puntaje más alto: {puntajealto}");
Console.ResetColor();

Console.ForegroundColor=ConsoleColor.Cyan;
Array.Sort(puntaje);
Console.WriteLine("Puntajes ordenados de menor a mayor:");
for (int i=0 ; i<puntaje.Length ; i++)
{
    Console.WriteLine(puntaje[i]);
}
Console.ResetColor();

Console.ForegroundColor=ConsoleColor.Yellow;
Console.WriteLine($"Puntajes mayores a 500: {puntajesgrandes}");
Console.ResetColor();
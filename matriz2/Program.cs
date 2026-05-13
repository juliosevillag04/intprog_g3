//Matriz 5x5
//El usuario debe buscar un numero y si lo encuentra mostrarla en verde (si hay mas de dos mostrar el primero en verde y el resto en azul)
//Si no lo encuentra mostrar un mensaje en rojo que diga "Registro no encontrado"
//Y validar datos ingresados por el usuario

Console.Clear();
int [,] matriz = new int [5,5];
Console.WriteLine("Digite los elementos de la matriz 5x5");
for (int f=0 ; f<5; f++)
{
    for (int c=0; c<5 ; c++)
    {
        try
        {
            Console.Write($"Elemento [{f},{c}]: ");
            matriz[f,c] = int.Parse(Console.ReadLine()!);
        }
        catch (FormatException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Por favor ingrese un número válido");
            c--; 
            Console.ResetColor();
        }
    }
}

Console.Write("Digite el número a buscar: ");
int num_buscar = int.Parse(Console.ReadLine()!);
bool encontrado = false;
for (int f=0 ; f<5; f++)
{
    for (int c=0; c<5 ; c++)
    {
        if (matriz[f,c] == num_buscar)
        {
            if (!encontrado)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                encontrado = true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            Console.Write($"{matriz[f,c]} ");
        }
        else
        {
            Console.Write($"{matriz[f,c]} ");
        }
    }
    Console.ResetColor();
    Console.WriteLine();
}
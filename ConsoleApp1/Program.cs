Random r = new Random();
int fil = 3;
int col = 3;
Console.WriteLine("Ingrese el minimo: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el maximo: ");
int max = Convert.ToInt32(Console.ReadLine());
//crear columnas
int[,] mat2 = new int[fil, col];
//ingreso
for (int f = 0; f < mat2.GetLength(0); f++)
{
    for (int i = 0; i < mat2.GetLength(1); i++)
    {
        mat2[f, i] = r.Next(min, max + 1);
    }
}
//salida
int acu = 0;
for (int f = 0; f < mat2.GetLength(0); f++)
{
    for (int i = 0; i < mat2.GetLength(1); i++)
    {
        Console.Write($"{mat2[f, i]},");
        acu = acu + mat2[f, i];
    }
    Console.WriteLine($"La suma de la fila {f} es {acu}");
}
int sum = 0;
for (int i = 0; i< mat2.GetLength(1); i++)
{
    for (int f = 0; f < mat2.GetLength(0); f++)
    {
        Console.Write($"{mat2[f, i]},");
        sum = sum + mat2[f, i];
    }
    Console.WriteLine($"La suma de la columna {i} es {sum}");
}
Console.WriteLine($"Las suma de filas es de {acu}");
Console.WriteLine($"Las suma de columnas es de {sum}");
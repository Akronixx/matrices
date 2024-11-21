int fil = 2;
int col = 2;
//crear columnas
int[][] mat = new int[fil][];
for (int f = 0; f < mat.Length; f++)
{
    mat[f] = new int[col];
}
//ingreso
for (int f = 0; f<mat.Length; f++)
{
    for (int i = 0; i<mat[f].Length; i++)
    {
        Console.WriteLine($"En fila {f}, Ingrese un número {i}");
        mat[f][i]=Convert.ToInt32(Console.ReadLine());
    }
}
//salida
int acu = 0;
for (int f = 0;f<mat.Length; f++)
{
    for (int i = 0; i < mat[0].Length; i++)
    {
        Console.Write($"{mat[f][i]},");
        acu=acu+mat[f][i];
    } 
    Console.WriteLine($"La suma de la fila {f} es {acu}");
}
Console.WriteLine($"Las suma de filas es de {acu}");
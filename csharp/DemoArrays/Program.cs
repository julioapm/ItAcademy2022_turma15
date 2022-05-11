int[] numeros = new int[5];
numeros[0] = 0;
numeros[1] = 1;
Console.WriteLine(numeros[0]);
Console.WriteLine(numeros.Length);
foreach (var item in numeros)
{
    Console.WriteLine(item);
}

//int[,] matriz = new int[3,3];
int[,] matriz = {{1,2,3},{4,5,6}};
Console.WriteLine(matriz[0,2]);
Console.WriteLine(matriz.Length);
Console.WriteLine(matriz.Rank);
Console.WriteLine(matriz.GetLength(1));

int[][] matrix = new int[2][];
matrix[0] = new int[3];
matrix[1] = new int[2];
matrix[0][1] = 7;
Console.WriteLine(matrix[0][1]);
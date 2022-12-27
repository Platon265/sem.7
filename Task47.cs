Console.WriteLine("Введите m");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine()!);
 
double[,] mainMatrix = Create2DArray(m, n, -10, 10);
Print2DArray(mainMatrix);
 
 
double[,] Create2DArray(int m, int n, int min, int max)
{
    double[,] matrix = new double[m, n];
 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(new Random().NextDouble() * (max - min) + min, 1);
        }
    }
    return matrix;
}
 
void Print2DArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

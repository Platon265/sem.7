Console.WriteLine("Введите m");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine()!);

int[,] mainMatrix = Create2DArray(m, n, 1, 10);
Print2DArray(mainMatrix);
Console.WriteLine();

for (int j = 0; j < mainMatrix.GetLength(1); j++)
{
    double sumCol = 0;
    int i = 0;
    while (i < mainMatrix.GetLength(0))
    {
        sumCol += mainMatrix[i, j];
        i++;
    }
    double averageValue = sumCol / i;
    Console.Write(Math.Round(averageValue, 1) + "; ");
}

int[,] Create2DArray(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void Print2DArray(int[,] matrix)
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

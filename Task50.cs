Console.WriteLine("Введите m");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine()!);

int[,] mainMatrix = Create2DArray(m, n, -10, 10);
Print2DArray(mainMatrix);

Console.WriteLine("Введите номер строки");
int row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите номер столбца");
int col = int.Parse(Console.ReadLine()!);

if (row > m || col > n) Console.WriteLine("такого числа в массиве нет");
else Console.WriteLine(mainMatrix[row - 1, col - 1]);

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

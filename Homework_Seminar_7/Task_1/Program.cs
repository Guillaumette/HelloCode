// Задайте двумерный массив размером m x n, заполненный случайными вещественными числами.

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] GenerateMatrix(int x, int y)
{
    double[,] matrix = new double[x, y];
    Random rand = new Random();
    for(int i = 0; i < x; i++)
    {
        for(int j = 0; j < y; j++)
        {
            matrix[i,j] = Math.Round(rand.Next(-10, 10) + rand.NextDouble(), 1);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++) // 0 - итерация по столбцам
    {
        for(int j = 0; j < matrix.GetLength(1); j++) // 1 - итерации по строкам
        {
            System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

var m = ReadInt("Введите количество строк матрицы: ");
var n = ReadInt("Введите количество столбцов матрицы: ");
double[,] myMatrix = GenerateMatrix(m, n);
PrintMatrix(myMatrix);
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int x, int y)
{
    int[,] matrix = new int[x, y];
    Random rand = new Random();
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            matrix[i, j] = rand.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) // 0 - итерация по строкам
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 1 - итерации по столбцам
        {
            System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

void SortMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int temp = matrix[i, k];
                    matrix[i, k] = matrix[i, k + 1];
                    matrix[i, k + 1] = temp;
                }
            }
        }
    }
}


int m = ReadInt("Введите количество строк матрицы: ");
int n = ReadInt("Введите количество столбцов матрицы: ");
var myMatrix = GenerateMatrix(m, n);
PrintMatrix(myMatrix);
SortMatrix(myMatrix);
System.Console.WriteLine();
PrintMatrix(myMatrix);
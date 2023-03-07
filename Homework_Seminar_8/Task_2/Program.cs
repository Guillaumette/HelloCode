// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int SumRow(int[,] matrix, int i)
{
    {
        int sumRow = matrix[i, 0];
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            sumRow += matrix[i, j];
        }
        return sumRow;
    }
}


int m = ReadInt("Введите количество строк матрицы: ");
int n = ReadInt("Введите количество столбцов матрицы: ");
var myMatrix = GenerateMatrix(m, n);

int minSumRow = 0;
int sumRow = SumRow(myMatrix, 0);
for (int i = 1; i < myMatrix.GetLength(0); i++)
{
  int tempSumRow = SumRow(myMatrix, i);
  if (sumRow > tempSumRow)
  {
    sumRow = tempSumRow;
    minSumRow = i;
  }
}

PrintMatrix(myMatrix);
System.Console.WriteLine();
System.Console.WriteLine($"{minSumRow + 1} - строка с наименьшей суммой, равной {sumRow}");
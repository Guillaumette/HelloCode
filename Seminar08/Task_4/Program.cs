// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Наименьший элемент - 1, на выходе получим:
// 9 2 3
// 4 2 4
// 2 6 7

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int x, int y)
{
    int[,] matrix = new int[x, y];
    Random rand = new Random();
    for(int i = 0; i < x; i++)
    {
        for(int j = 0; j < y; j++)
        {
            matrix[i,j] = rand.Next(1,10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++) // 0 - итерация по строкам
    {
        for(int j = 0; j < matrix.GetLength(1); j++) // 1 - итерации по столбцам
        {
            System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

void FindMin(int[,] matrix, out int mini, out int minj)
{
    mini = 0;
    minj = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
         for (int j = 0; j < matrix.GetLength(1); j++)
         {
            if (matrix[mini, minj] > matrix[i, j])
            {
                mini = i;
                minj = j;
            }
         }
    }
}

int[,] DeleteStringColumn(int[,] matrix, int mini, int minj)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int row = 0;
    int column = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {   
        if (i == mini) continue;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == minj) continue;
            newMatrix[row, column] = matrix[i,j];
            column++;
        }
        row++;
        column = 0;
    }
    return newMatrix;
}


int m = ReadInt("Введите количество строк матрицы: ");
int n = ReadInt("Введите количество столбцов матрицы: ");
var myMatrix = GenerateMatrix(m, n);
PrintMatrix(myMatrix);
FindMin(myMatrix, out int mini, out int minj);
System.Console.WriteLine();
PrintMatrix(DeleteStringColumn(myMatrix, mini, minj));
// Задайте двумерный массив/ Напишите программу, которая поменяет местами первую и последнюю строку массива.

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
            matrix[i,j] = rand.Next(0,10);
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

void ReverseMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(1); i++) // потому что кол-во итераций зависит от кол-ва столбцов
    {
        int temp = matrix[0,i];
        // меняем первую строку
        matrix[0,i] = matrix[matrix.GetLength(0) - 1, i]; // последняя строка, а перемещаемся так же по столбцам
        matrix[matrix.GetLength(0) - 1, i] = temp; // меняем последнюю строку
    } 
}


int m = ReadInt("Введите количество строк матрицы: ");
int n = ReadInt("Введите количество столбцов матрицы: ");
var myMatrix = GenerateMatrix(m, n);
PrintMatrix(myMatrix);
ReverseMatrix(myMatrix);
System.Console.WriteLine();
PrintMatrix(myMatrix);
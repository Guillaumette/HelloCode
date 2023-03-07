// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

void MyltiplyMatrix(int[,] matrix1, int[,] matrix2, int[,] result)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int mult = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                mult += matrix1[i, k] * matrix2[k, j];
            }
            result[i, j] = mult;
        }
    }
}

int m = ReadInt("Введите количество строк первой матрицы: ");
int n = ReadInt("Введите количество столбцов первой матрицы и число строк второй: ");
int k = n;
int l = ReadInt("Введите количество столбцов второй матрицы ");
System.Console.WriteLine();
var myMatrix = GenerateMatrix(m, n);
var myMatrix2 = GenerateMatrix(k, l);
int[,] resultMatrix = new int[m, l];
System.Console.WriteLine("Первая матрица:");
PrintMatrix(myMatrix);
System.Console.WriteLine();
System.Console.WriteLine("Вторая матрица:");
PrintMatrix(myMatrix2);
MyltiplyMatrix(myMatrix, myMatrix2, resultMatrix);
System.Console.WriteLine("Результат умножения первой и второй матриц:");
PrintMatrix(resultMatrix);
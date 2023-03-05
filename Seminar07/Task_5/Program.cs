// Задать двумерный массив. Найти сумму элементов, находящихся на главной диагонали.

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
    for(int i = 0; i < matrix.GetLength(0); i++) // 0 - итерация по столбцам
    {
        for(int j = 0; j < matrix.GetLength(1); j++) // 1 - итерации по строкам
        {
            System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int SumOnMainDiagonal(int[,] matrix)
{
    int sum = 0;
    for(int i = 0; i < matrix.GetLength(0); i++) // 0 - итерация по столбцам
    {
        for(int j = 0; j < matrix.GetLength(1); j++) // 1 - итерации по строкам
        {
            if(i == j)
            {
               sum += matrix[i, j];
            }
        }
    }
    return sum;
}


int m = ReadInt("Введите количество строк матрицы: ");
int n = ReadInt("Введите количество столбцов матрицы: ");
var myMatrix = GenerateMatrix(m, n);
PrintMatrix(myMatrix);
System.Console.WriteLine();
System.Console.WriteLine($"Сумма элементов главной диагонали равна {SumOnMainDiagonal(myMatrix)}");
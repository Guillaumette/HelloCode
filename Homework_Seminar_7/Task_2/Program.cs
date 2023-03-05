// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

int InputCoordinates(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

bool CheckingCoordinates(int v, int x, int y, int z)
{
    bool coord = true;
    if(v > y || x > z)
    {
        coord = false;
    }
    return coord;
}



int m = ReadInt("Введите количество строк матрицы: ");
int n = ReadInt("Введите количество столбцов матрицы: ");
var myMatrix = GenerateMatrix(m, n);
PrintMatrix(myMatrix);
int a = InputCoordinates("Введите строку элемента: ");
int b = InputCoordinates("Введите столбец элемента: ");
bool coordinate = CheckingCoordinates(a, b, m, n);

object elem = 0;
if(coordinate)
{
    elem = myMatrix.GetValue(a,b);
    System.Console.WriteLine(elem);
}
else
{
    System.Console.WriteLine("Такого числа нет");
}
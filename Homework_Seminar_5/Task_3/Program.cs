// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] GenerateArray(int size, int leftRange, int rightRange)
{
    double[] array = new double[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rand.Next(leftRange, rightRange) + rand.NextDouble(), 2);
    }
    return array;
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
    }
    return max;
}

double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i]) min = array[i];
    }
    return min;
}

const int SIZE = 10;
const int LEFT_RANGE = 1;
const int RIGHT_RANGE = 10;

var arr = GenerateArray(SIZE, LEFT_RANGE, RIGHT_RANGE);
PrintArray(arr);
double result = Math.Round(FindMax(arr) - FindMin(arr), 2);
System.Console.WriteLine($"Максимальным элементом массива является {FindMax(arr)}");
System.Console.WriteLine($"Минимальным элементом массива является {FindMin(arr)}");
System.Console.WriteLine($"Разность между максимальным и минимальным значением массива равна {result}");
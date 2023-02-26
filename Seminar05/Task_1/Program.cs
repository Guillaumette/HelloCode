// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

int[] GenerateArray(int size)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(-9, 10);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

void CountSum(int[] array, out int sumPositive, out int sumNegative)
{
    sumPositive = 0;
    sumNegative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sumPositive += array[i];
        }
        else
        {
            sumNegative += array[i];
        }
    }
}
var arr = GenerateArray(12);

PrintArray(arr);
CountSum(arr, out int sumPos, out int sumNeg);

System.Console.WriteLine($"Сумма положительных чисел: {sumPos}");
System.Console.WriteLine($"Сумма отрицательных чисел: {sumNeg}");
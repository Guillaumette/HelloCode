// Задайте одномерный массив из 20 случайных чисел. Найдите количество элементов массива, значения которых
// лежат в диапазоне [10, 99].

int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int CountQuantity(int[] array, int leftRange, int rightRange)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <= rightRange && array[i] >= leftRange)
        {
            count++;
        }
        
    }
    return count;
}

const int SIZE = 20;
const int LEFT_RANGE = -100;
const int RIGHT_RANGE = 100;

var arr = GenerateArray(SIZE, LEFT_RANGE, RIGHT_RANGE);
PrintArray(arr);
System.Console.WriteLine(CountQuantity(arr, 1, 100));

// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

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

int[] CopyArray(int[] array)
{
    int[] array2 = new int[array.Length];
    for (int i = 0; i < array2.Length; i++)
    {
        array2[i] = array[i];
    }
    return array2;
}


const int SIZE = 5;
const int LEFT_RANGE = -9;
const int RIGHT_RANGE = 9;

var arr = GenerateArray(SIZE, LEFT_RANGE, RIGHT_RANGE);
PrintArray(arr);
var arr2 = CopyArray(arr);
PrintArray(arr2);

// int[] arr2 = arr[..]; - то же самое, что CopyArray, не ссылка на ячейки памяти первого массива, а поэлементное копирование
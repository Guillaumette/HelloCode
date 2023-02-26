// Напишите программу замены элементов массива: положительные элементы замените на отрицательные и наоборот.

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

void ChangeArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
}

const int SIZE = 4;
const int LEFT_RANGE = -9;
const int RIGHT_RANGE = 9;

var arr = GenerateArray(SIZE, LEFT_RANGE, RIGHT_RANGE);
PrintArray(arr);
ChangeArray(arr);
PrintArray(arr);
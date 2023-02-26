// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний, второй и предпоследний и т.д. элементы.
// Результат запишите в новом массиве.

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

int[] MultiplyArray(int[] array)
{
    int[] result = new int[array.Length / 2 + array.Length % 2]; // или (array.Length + 1) / 2
    for (int i = 0; i < result.Length / 2; i++)
    {
        result[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 != 0)
    {
        result[^1] = array[array.Length / 2];
    }
    return result;
}

const int SIZE = 9;
const int LEFT_RANGE = -10;
const int RIGHT_RANGE = 10;

var arr = GenerateArray(SIZE, LEFT_RANGE, RIGHT_RANGE);
PrintArray(arr);
int[] res = MultiplyArray(arr);
PrintArray(res);
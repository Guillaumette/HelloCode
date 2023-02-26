// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

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

void IfNumber(int [] array, int n)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == n)
        {
            System.Console.WriteLine("Да");
            return;
        }
    }
    System.Console.WriteLine("Нет");
}

const int SIZE = 4;
const int LEFT_RANGE = -9;
const int RIGHT_RANGE = 9;

var arr = GenerateArray(SIZE, LEFT_RANGE, RIGHT_RANGE);
PrintArray(arr);
System.Console.Write("Введите искомое число: ");
int number = Convert.ToInt32(Console.ReadLine());
IfNumber(arr, number);
// Напишите программу, которая перевернет одномерный массив (последний элемент будет на первом месте, первый - на последнем и т.д.)
// [1, 2, 3, 4, 5] -> [5, 4, 3, 2, 1]

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

// редактируем исходный массив

void Reverse(int[] array)
{
    int temp = 0;
    for (int i = 0; i < array.Length / 2; i++) // пополам, чтобы массив заново не развернуть
    {
        temp = array[i];
        array[i] = array[array.Length - 1 -i]; // чтобы не out of range и чтобы двигаться назад по массиву
        array[array.Length - 1 -i] = temp; 
    }
}

const int SIZE = 10;
const int LEFT_RANGE = -10;
const int RIGHT_RANGE = 10;

var arr = GenerateArray(SIZE, LEFT_RANGE, RIGHT_RANGE);
PrintArray(arr);
Reverse(arr);
PrintArray(arr);
Array.Reverse(arr); // встроенная функция в класс Array
PrintArray(arr);
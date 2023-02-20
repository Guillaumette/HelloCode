// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// Линейный способ.
// int[] arr = new int[8];
// Random rand = new Random();
// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = rand.Next(0,2);
// }

// for (int i = 0; i < arr.Length; i++)
// {
//     System.Console.Write(arr[i] + " ");
// }

// Функциональный способ.

void FillArray(int[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(0,2);
    }
}

void PrintArray(int[] array)
{
    // for (int i = 0; i < array.Length; i++)
    // {
    //     System.Console.Write(array[i] + " ");
    // }
    // Другой способ написать то, что выше в цикле - строковый метод Join
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int[] arr = new int[8];
FillArray(arr);
PrintArray(arr);
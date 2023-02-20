// Упорядочить массив
// 1. Найти позицию минимального элемента в неотсортированной части массива;
// 2. Произвести обмен этого значения со значением первой неотсортированной позиции;
// 3. Повторять, пока есть неотсортированные элементы

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int minPosition = i;

        // меняем местами минимальный элемент с выбранным, поэтому i + 1
        for (int j = i + 1; j < array.Length - 1; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
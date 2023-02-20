// Упорядочить массив
// 1. Найти позицию максимального элемента в неотсортированной части массива;
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
        for (int j = 0; j < array.Length - 1; j++)
        {
            if (array[j] < array[j + 1])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);

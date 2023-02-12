// Ищем индекс значения в массиве, задаваемого пользователем. Имеет значение первое вхождение

// collection - название аргумента, который принимает массив. Метод заполняет массив рандомными значениями
// Void - это метод, который ничего не возвращает. Нельзя использовать return
void FillArray(int[] collection)
{   
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

// другие имена аргументов! Метод печатает список. 
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    // на случай, если искомого значения нет вообще в массиве
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

// Создай новый массив, в котором будет 10 элементов
int[] array = new int[10];

FillArray(array);
array[4] = 4;
array[6] = 4;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);


// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] InputArray(string text)
{
    System.Console.Write(text);
    return Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
}

int CountTimes(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

string WriteCorrectly(int func)
{
    string str = String.Empty;
    if (func > 0 && func <= 4)
    {
        str = "раза";
    }
    else
    {
        str = "раз";
    }
    return str;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}


int[] arr = InputArray("Введите числа: ");
PrintArray(arr);
System.Console.WriteLine($"Чисел больше нуля введено {CountTimes(arr)} {WriteCorrectly(CountTimes(arr))}");
// Напишите программу, которая принимает на вход число А и выдает сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Линейный способ
// System.Console.Write("Введите число А: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int result = 0;
// for (int i = 1; i <= a; i++)
// {
//     result += i;
// }
// System.Console.WriteLine($"Сумма чисел от 1 до {a} равна {result}");

// С помощью функции.
// Функция, считывающая значение переменной из терминала
int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Sum(int A)
{
    int sum = 0;

    for (int i = 1; i <= A; i++)
    {
        sum += i;
    }
    return sum;
}

int number = ReadInt("Введите число А: ");
System.Console.WriteLine($"Сумма чисел от 1 до {number} равна {Sum(number)}");

number = ReadInt("Введите число B: ");
System.Console.WriteLine($"Сумма чисел от 1 до {number} равна {Sum(number)}");

number = ReadInt("Введите число C: ");
System.Console.WriteLine($"Сумма чисел от 1 до {number} равна {Sum(number)}");
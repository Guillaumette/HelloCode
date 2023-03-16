// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void WriteNumbers(int number)
{
    if (number == 0)
    {
        return;
    }
    System.Console.Write(number + " ");
    WriteNumbers(number - 1);
}


WriteNumbers(ReadInt("Введите число: "));
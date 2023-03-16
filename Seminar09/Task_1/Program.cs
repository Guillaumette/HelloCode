// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке 1 до N.

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
    WriteNumbers(number - 1);
    System.Console.Write(number + " ");
}


WriteNumbers(ReadInt("Введите число: "));
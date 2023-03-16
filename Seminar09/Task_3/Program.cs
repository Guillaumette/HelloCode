// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int FindSumCiffres(int number)
{
    if (number == 0) return 0;
    return number % 10 + FindSumCiffres(number / 10);
}

int n = ReadInt("Введите число: ");
System.Console.WriteLine($"Сумма цифр числа {n} равна {FindSumCiffres(n)}");
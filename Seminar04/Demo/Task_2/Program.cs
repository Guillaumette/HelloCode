// Напишите программу, которая на вход получает число и выдает количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int ReadInt(string text)
{
    System.Console.Write(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int NumLength(int n)
{
    int count = 0;

    while (n > 0)
    {
        n /= 10;
        count++;
    }
    
    return count;
}

int number = ReadInt("Введите число: ");
System.Console.WriteLine($"Количество цифр в числе {number}: {NumLength(number)}");

number = ReadInt("Введите число: ");
System.Console.WriteLine($"Количество цифр в числе {number}: {NumLength(number)}");

number = ReadInt("Введите число: ");
System.Console.WriteLine($"Количество цифр в числе {number}: {NumLength(number)}");
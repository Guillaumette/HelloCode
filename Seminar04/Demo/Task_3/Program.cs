// Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Product(int n)
{   
    int res = 1;
    if (n < 0)
    {
        System.Console.WriteLine("Нельзя посчитать факториал отрицательного числа");
    }
    else if (n == 0)
    {
        res = 1;
    }
    else
    {
        for (int i = 2; i <= n; i++)
        {
            res *= i;
        }
    }
    return res;
}

int number = ReadInt("Введите число: ");
System.Console.WriteLine($"Произведением чисел от 1 до {number} является значение {Product(number)}");

number = ReadInt("Введите число: ");
System.Console.WriteLine($"Произведением чисел от 1 до {number} является значение {Product(number)}");
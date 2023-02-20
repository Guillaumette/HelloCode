// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int FindSum(int n)
{
    int res = 0;
    while (n > 0)
    {
        res += n % 10;
        n /= 10;
    }
    return res;
}

int number = ReadInt("Введите число: ");
System.Console.WriteLine($"Сумма всех чисел в {number} равна {FindSum(number)}");
// Напишите программу, которая на вход принимает два числа A и B и возводит A в степень B.

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int RecursionPower(int m, int n)
{
    if (n == 0) return 1;
    return m * RecursionPower(m, n - 1);
}

int a = ReadInt("Введите чисто А: ");
int b = ReadInt("Введите число В: ");
System.Console.WriteLine(RecursionPower(a, b));
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void WriteNumbers(int m, int n)
{
    if (n == m - 1) return;
    WriteNumbers(m, n - 1);
    System.Console.Write(n + " ");
}

int SumNumbers(int m, int n)
{
    int sum = 0;
    int start = m;
    int finish = n;
    if (m > n)
    {
        start = n;
        finish = m;
    }
    sum = (finish + start) * (finish - start + 1) / 2;
    return sum;
}

int m = ReadInt("Введите число M: ");
int n = ReadInt("Введите число N: ");
if (m < n)
{
     WriteNumbers(m, n);
}
else
{
     WriteNumbers(n, m);
}
System.Console.WriteLine();
System.Console.WriteLine($"Сумма чисел от {m} до {n} равна {SumNumbers(m,n)}");
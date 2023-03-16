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
    if(n == 0) return 0;
    return n + SumNumbers(m, n - 1);
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
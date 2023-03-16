// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void WriteNumbers(int number1, int number2)
{
    if (number2 == number1 - 1) return;
    WriteNumbers(number1, number2 - 1);
    System.Console.Write(number2 + " ");
}


int m = ReadInt("Введите число M: ");
int n = ReadInt("Введите число N: ");
WriteNumbers(m,n);
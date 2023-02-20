// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Power(int num1, int num2)
{
    int result = 1;
    for (int i = 0; i < num2; i++)
    {
        result *= num1;
    }
    return result;
}

bool checkNum2(int num2)
{
    if (num2 < 0)
{
    System.Console.WriteLine("Число для возведения в степень не должно быть меньше нуля");
    return false;
}
return true;
}


int a = ReadInt("Введите число А: ");
int b = ReadInt("Введите число B: ");

if (checkNum2(b))
{
    System.Console.WriteLine($"Результатом возведения числа {a} в степень числа {b} будет {Power(a, b)}");
}
// Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Fibonacci(int num)
{
    System.Console.Write("0 1 ");
    int result = 0;
    int a = 0, b = 1;
    for (int i = 2; i < num; i++)
    {
        result = a + b;
        a = b;
        b = result;
        System.Console.Write(result + " ");
    }
}

int N = ReadInt("Введите число: ");
Fibonacci(N);
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Akkerman(int x, int y)
{
    if (x == 0) return y + 1;
    else if (x > 0 && y == 0) return Akkerman(x - 1, 1);
    else return Akkerman( x - 1, Akkerman(x, y - 1));
}

int m = ReadInt("Введите число M: ");
int n = ReadInt("Введите число N: ");
System.Console.WriteLine(Akkerman(m, n));
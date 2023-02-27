// Напишите программу, которая преобразовывает десятичное число в двоичное.

// считываем введенное число
int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void GetBinaryView(int num)
{
    if (num == 0) return; // в void можно использовать return, если он означает, что мы хотим остановить нашу функцию
    GetBinaryView(num / 2);
    System.Console.Write(num % 2); // вывод остатков будет с конца, потому что сначала идет вызов функции, а потом вывод
}


int N = ReadInt("Введите число: ");
GetBinaryView(N);
// Напишите программу, которая преобразовывает десятичное число в двоичное.

// считываем введенное число
int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

// конвертируем десятичное число в двоичное
int[] ConvertToBinary(int value)
{
    int count = 0; // определяем, сколько итераций деления будет, чтобы выделить нужное кол-во ячеек памяти для нового массива
    int value2 = value;
    while (value2 > 0)
    {
        value2 /= 2;
        count++;
    }
    int[] result = new int[count]; // создаем массив из остатков деления на 2
    for (int i = 0; i < count; i++)
    {
        result[i] = value % 2;
        value /= 2;
    }
    Array.Reverse(result); // переворачиваем его
    return result;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine(String.Join("", array)); // без сплита, потому что нам нужно вывести в виде числа, а не массива
}
int num = ReadInt("Введите число: ");
int[] binaryNum = ConvertToBinary(num);
PrintArray(binaryNum);
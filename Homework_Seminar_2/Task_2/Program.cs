// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int thirdDig = 0;
if (number >= 100)
{
    while (number > 999)
    {
        number /= 10;
    }
    thirdDig = number % 10;
    Console.WriteLine(thirdDig);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}

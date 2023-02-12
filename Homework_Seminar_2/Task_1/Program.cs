//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

marker:
    Console.Write("Введите трехзначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number / 100 < 1)
    {
        Console.WriteLine("Число должно быть трехзначным");
        goto marker;
    }

    int secondNum = number / 10 % 10;
    Console.WriteLine(secondNum);




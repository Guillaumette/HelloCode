﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 7 || number < 1)
{
    Console.WriteLine("Не является днем недели");
}
else if (number <= 7 && number > 5)
{
    Console.WriteLine("Да");
}
else{
    Console.WriteLine("Нет");
}
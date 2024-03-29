﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Решение через строку

Console.Write("Введите число: ");
string? number = Console.ReadLine();

if (number!.Length < 3)
{
    System.Console.WriteLine("Третьей цифры нет");
}
else
{
    // Запишем третью цифру в переменную и конвертируем ее. Сначала она char, то есть таблица соответствия символа и его номера в таблице,
    // char не может напрямую конвертироваться в int, поэтому сначала конвертируем ее в строку, а потом только в цифру.
    int thirdNum = Convert.ToInt32(Convert.ToString(number[2]));

    System.Console.WriteLine(thirdNum);   
}

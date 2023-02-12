// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine(number);
// int left = number / 100;
// int right = number % 10;
// Console.WriteLine(left + "" + right);

int left = number / 100 * 10;
int right = number % 10;
int sum = left + right;
Console.WriteLine(sum);

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.Write("Введите число: ");
string number = Console.ReadLine();

if (number.Length != 5)
{
    System.Console.WriteLine("Число не является пятизначным");
}
else if (number[0] == number[4] && number[1] == number[3])
{
    System.Console.WriteLine("Это палиндром");
}
else
{
    System.Console.WriteLine("Это не палиндром");
}
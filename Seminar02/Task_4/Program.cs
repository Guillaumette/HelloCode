// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число проверки на кратность: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число проверки на кратность: ");
int numberC = Convert.ToInt32(Console.ReadLine());

if (numberA % numberB == 0 && numberA % numberC == 0)
{
    Console.WriteLine($"Число {numberA} кратно {numberB} и {numberC}");
}
else
{
    Console.WriteLine($"Число {numberA} не кратно {numberB} и {numberC}");
}
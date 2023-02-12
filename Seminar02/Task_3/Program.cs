// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно


Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA % numberB != 0)
{
    Console.WriteLine($"{numberB} не кратно {numberA}, остаток {numberA % numberB}");
}
else
{
    Console.WriteLine($"{numberB} кратно {numberA}");
}
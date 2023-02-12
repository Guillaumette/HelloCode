// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

Random rand = new Random();
int randNumber = rand.Next(10, 100); // правая граница - на 1 больше
Console.WriteLine(randNumber);
int leftNumber = randNumber / 10;
int rightNumber = randNumber % 10;

if (leftNumber > rightNumber)
{
    Console.WriteLine($"{leftNumber} больше {rightNumber}");
}
else if (leftNumber < rightNumber)
{
    Console.WriteLine($"{rightNumber} больше {leftNumber}");
}
else
{
    Console.WriteLine("Числа равны");
}

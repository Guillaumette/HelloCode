// Напишите программу, которая по заданному номеру четверти показывает диапазон возможных координат точек x и y в этой четверти.

System.Console.Write("Введите значение четверти: ");
int quart = Convert.ToInt32(Console.ReadLine());
string[] strArray = {"x > 0, y > 0", "x < 0, y > 0", "x < 0, y < 0", "x > 0, y < 0", "Введено некорректное значение четверти"};

if (quart > 0 && quart < 5)
{
    System.Console.WriteLine(strArray[quart - 1]);
}
else
{
    System.Console.WriteLine("Введено некорректное значение");
}
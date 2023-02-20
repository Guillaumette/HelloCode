// Напишите программу, которая по заданному номеру четверти показывает диапазон возможных координат точек x и y в этой четверти.

System.Console.Write("Введите значение четверти: ");
int quart = Convert.ToInt32(Console.ReadLine());

if (quart == 1) System.Console.WriteLine("x > 0, y > 0");
else if (quart == 2) System.Console.WriteLine("x < 0, y > 0");
else if (quart == 3) System.Console.WriteLine("x < 0, y < 0");
else if (quart == 4) System.Console.WriteLine("x > 0, y < 0");
else System.Console.WriteLine("Введено некорректное значение четверти");
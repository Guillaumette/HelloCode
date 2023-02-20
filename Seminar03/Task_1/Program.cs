// Напишите программу, которая по заданному номеру четверти показывает диапазон возможных координат точек x и y в этой четверти.

System.Console.Write("Введите значение четверти: ");
int quart = Convert.ToInt32(Console.ReadLine());
string[] strArray = {"x > 0, y > 0", "x < 0, y > 0", "x < 0, y < 0", "x > 0, y < 0", "Введено некорректное значение четверти"};

if (quart == 1) System.Console.WriteLine(strArray[0]);
else if (quart == 2) System.Console.WriteLine(strArray[1]);
else if (quart == 3) System.Console.WriteLine(strArray[2]);
else if (quart == 4) System.Console.WriteLine(strArray[3]);
else System.Console.WriteLine(strArray[4]);
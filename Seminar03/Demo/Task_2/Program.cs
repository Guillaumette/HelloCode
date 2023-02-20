// Напишите программу, которая на вход принимает координаты точки X и Y, причем они оба не равны нулю,
// и выдает номер четверти плоскости, в которой лежит эта точка.

Console.Write("Введите значение X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0) System.Console.WriteLine("1 четверть");
else if (x < 0 && y > 0) System.Console.WriteLine("2 четверть");
else if (x < 0 && y < 0) System.Console.WriteLine("3 четверть");
else if (x > 0 && y < 0) System.Console.WriteLine("4 четверть");
else System.Console.WriteLine("Координата лежит на осях");
    


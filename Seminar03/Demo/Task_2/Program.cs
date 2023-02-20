// Напишите программу, которая на вход принимает координаты точки X и Y, причем они оба не равны нулю,
// и выдает номер четверти плоскости, в которой лежит эта точка.

// Вводим массив и выделяем ему две ячеки памяти, т.к. нам надо всего две координаты
int[] coords = new int[2];
Console.Write("Введите значение X: ");
coords[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение Y: ");
coords[1] = Convert.ToInt32(Console.ReadLine());

if (coords[0] > 0 && coords[1] > 0) System.Console.WriteLine("1 четверть");
else if (coords[0] < 0 && coords[1] > 0) System.Console.WriteLine("2 четверть");
else if (coords[0] < 0 && coords[1] < 0) System.Console.WriteLine("3 четверть");
else if (coords[0] > 0 && coords[1] < 0) System.Console.WriteLine("4 четверть");
else System.Console.WriteLine("Координата лежит на осях");
   

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координаты X точки А: ");
int[] coordsA = new int[3];
coordsA[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты Y точки А: ");
coordsA[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты Z точки А: ");
coordsA[2] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты X точки B: ");
int[] coordsB = new int[3];
coordsB[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты Y точки B: ");
coordsB[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты Z точки B: ");
coordsB[2] = Convert.ToInt32(Console.ReadLine());

// (квадрат разности иксов, степень)
// (int): приведение типов, так как Pow возвращает double, а мы приводим в int
int distanceX = (int) Math.Pow(coordsA[0] - coordsB[0], 2);
// (квадрат разности игреков, степень)
int distanceY = (int) Math.Pow(coordsA[1] - coordsB[1], 2);
// (квадрат разности зедов, степень)
int distanceZ = (int) Math.Pow(coordsA[2] - coordsB[2], 2);
double result = Math.Sqrt(distanceX + distanceY + distanceZ);

System.Console.WriteLine(Math.Round(result, 3));
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,5); B (1,-1) -> 7,21

// Нужно взять квадратный корень от суммы квадратов разности координат: корень из (x1-x2)2 + (y1 - y2)2

// Импортируем библиотеку математики
// Math.Sqrt(9) -> 3
// Math.Round(Math.Sqrt(7), 3) -> 2,646

// Функция, которая запишет в массив числа, которые я введу через пробел через терминал, то есть я ввожу массив со строки.
// Сначала он воспринимает это как строку, а потом с помощью int.Parse конвертирует элементы массив в целые числа.
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

Console.Write("Введите координаты X точки А: ");
int[] coordsA = new int[2];
coordsA[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты Y точки А: ");
coordsA[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты X точки B: ");
int[] coordsB = new int[2];
coordsB[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты Y точки B: ");
coordsB[1] = Convert.ToInt32(Console.ReadLine());

// (квадрат разности иксов, степень)
// (int): приведение типов, та как Pow возвращает double, а мы приводим в int
int distanceX = (int) Math.Pow(coordsA[0] - coordsB[0], 2);
// (квадрат разности игреков, степень)
int distanceY = (int) Math.Pow(coordsA[1] - coordsB[1], 2);
double result = Math.Sqrt(distanceX + distanceY);

System.Console.WriteLine(Math.Round(result, 3));
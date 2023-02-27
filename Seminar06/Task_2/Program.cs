// Напишите программу, которая принимает на вход три числа и проверяет, можнт ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона меньше суммы двух других сторон.

void IfTriangle(int num1, int num2, int num3)
{
    if (num1 + num2 > num3 && num1 + num3 > num2 && num2 + num3 > num1)
    {
        System.Console.WriteLine($"Треугольник со сторонами, равными {num1}, {num2}, {num3} может существовать");
    }
    else
    {
        System.Console.WriteLine($"Треугольник со сторонами, равными {num1}, {num2}, {num3} не может существовать");
    }
}

System.Console.Write("Введите значение первой стороны: ");
int side1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите значение второй стороны: ");
int side2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите значение третьей стороны: ");
int side3 = Convert.ToInt32(Console.ReadLine());
IfTriangle(side1, side2, side3);
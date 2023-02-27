// Напишите программу, которая принимает на вход три числа и проверяет, можнт ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона меньше суммы двух других сторон.

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

void IfTriangle(int[] array)
{
    if (array[0] + array[1] > array[2] && array[0] + array[2] > array[1] && array[1] + array[2] > array[0])
    {
        System.Console.WriteLine($"Треугольник со сторонами, равными {array[0]}, {array[1]}, {array[2]}, может существовать");
    }
    else
    {
        System.Console.WriteLine($"Треугольник со сторонами, равными {array[0]}, {array[1]}, {array[2]}, не может существовать");
    }
}

// функция, которая будет возвращать массив
int[] InputArray(string text)
{
    // Вводим массив через строку
    System.Console.Write(text);
    // метод класса Array, позволяющий ввести массив через строку, сплит по пробелу:
    // 1. Вводим строку, метод ConvertAll принимает на вход строковый массив
    // 2. int.Parse: конвертирует строковый массив в массив целочисленных чисел
    // 3. Split() - разделение по пробелу
    return Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
}

int[] triangle = InputArray("Введите 3 числа: ");
PrintArray(triangle);
IfTriangle(triangle);
// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных.

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int x, int y)
{
    int[,] matrix = new int[x, y];
    Random rand = new Random();
    for(int i = 0; i < x; i++)
    {
        for(int j = 0; j < y; j++)
        {
            matrix[i,j] = rand.Next(1,10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++) // 0 - итерация по строкам
    {
        for(int j = 0; j < matrix.GetLength(1); j++) // 1 - итерации по столбцам
        {
            System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int[] CountElems(int[,] matrix)
{
    int[] countDict = new int[9];
    for(int i = 0; i < matrix.GetLength(0); i++) // 0 - итерация по строкам
    {
        for(int j = 0; j < matrix.GetLength(1); j++) // 1 - итерации по столбцам
        {
            countDict[matrix[i,j] - 1]++;
        }
    }
    return countDict;
}

void PrintDict(int[] array, string func)
{
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] != 0)
        {
            System.Console.WriteLine($"{i+1} встречается {array[i]} раз(а)");
        }
    }
}


int m = ReadInt("Введите количество строк матрицы: ");
int n = ReadInt("Введите количество столбцов матрицы: ");
var myMatrix = GenerateMatrix(m, n);
PrintMatrix(myMatrix);
System.Console.WriteLine();
PrintDict(CountElems(myMatrix));
﻿// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintMatrix (int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (matrix[i,j] / 10 <= 0)
      Console.Write($" {matrix[i,j]} ");

      else Console.Write($"{matrix[i,j]} ");
    }
    Console.WriteLine();
  }
}


int n = 4;
int[,] squareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= squareMatrix.GetLength(0) * squareMatrix.GetLength(1))
{
  squareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < squareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= squareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > squareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

PrintMatrix(squareMatrix);
// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using System;
using static System.Console;
Clear();

WriteLine("Задайте размеры двумерного массива через пробел. \nПервое - строка, второе - столбец");

string[] sizes = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int rows = int.Parse(sizes[0]);
int columns = int.Parse(sizes[1]);
PrintArray(GetRandomArray(rows, columns));

double[,] GetRandomArray(int row, int column)
{
    double[,] result = new double[row, column];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
    return result;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]:F1} ");
        }
        WriteLine();
    }
}
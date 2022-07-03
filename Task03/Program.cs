// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System;
using static System.Console;
Clear();

WriteLine("Программа, которая находит среднее арифметическое элементов в каждом столбце");
WriteLine("Задайте размеры двумерного массива через пробел. \nПервое - строка, второе - столбец");

string[] sizes = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int rows = int.Parse(sizes[0]);
int columns = int.Parse(sizes[1]);
SearchArithmeticMean(GetRandomArray(rows, columns));

int[,] GetRandomArray(int row, int column)
{
    int[,] result = new int[row, column];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}

void SearchArithmeticMean(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double arithmeticmean = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            arithmeticmean = (arithmeticmean + array[j, i]);
        }
        arithmeticmean = arithmeticmean / rows;
        Write($"{arithmeticmean:F2}; ");
    }
}
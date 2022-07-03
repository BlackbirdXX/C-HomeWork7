// Задача 50. Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using System;
using static System.Console;
Clear();
WriteLine("Программа,которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет. ");
WriteLine("Задайте координаты элемента двумерного массива через пробел. \nПервое - строка, второе - столбец");
string[] element = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int rows = int.Parse(element[0]);
int columns = int.Parse(element[1]);

int[,] array = new int[3, 4];
PrintArray(FillArray(array));

if (rows > array.GetLength(0) || columns > array.GetLength(1))
{
    Console.WriteLine("Такого элемента в массиве нет");
}
else
{
    Console.WriteLine($"Значение элемента {rows} строки и {columns} столбца равно {array[rows - 1, columns - 1]}");
}

int[,] FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
    return arr;
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Write($"{arr[i, j]} ");
        }
        WriteLine();
    }
}
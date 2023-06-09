﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();

int row = Prompt("Введите количество строк в массиве: ");
int column = Prompt("Введите количество столбцов в массиве: ");
int min = Prompt("Введите минимальное значение в массиве: ");
int max = Prompt("Введите максимальное значение в массиве: ");
int[,] array = FillArray(row, column, min, max);
PrintArray(array);
Console.WriteLine();
PrintArray(GetStreamline(array));

int Prompt(string text)
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] FillArray(int rowArray, int columnArray, int min, int max)
{
    int[,] resultArray = new int[rowArray, columnArray];
    Random rnd = new Random();
    for (int i = 0; i < rowArray; i++)
    {
        for (int j = 0; j < columnArray; j++)
        {
            resultArray[i, j] = rnd.Next(min, max + 1);
        }
    }
    return resultArray;
}

void PrintArray(int[,] arr)
{
    Console.WriteLine("----------------------------");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + $"  ");
        }
        Console.WriteLine();
    }
}

int[,] GetStreamline(int[,] InputArray)
{
    for (int i = 0; i < InputArray.GetLength(0); i++)
    {
        for (int j = 0; j < InputArray.GetLength(1); j++)
        {
            for (int k = 0; k < InputArray.GetLength(1)-1; k++)
            {
            if (InputArray[i, k] < InputArray[i, k+1])
            {
                int temp = InputArray[i, k];
                InputArray[i, k] = InputArray[i, k + 1];
                InputArray[i, k + 1] = temp;
            }
            }
        }
    }
    return InputArray;
}

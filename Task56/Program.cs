// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

int row = Prompt("Введите количество строк в массиве: ");
int column = Prompt("Введите количество столбцов в массиве: ");
int min = Prompt("Введите минимальное значение в массиве: ");
int max = Prompt("Введите максимальное значение в массиве: ");
int[,] array = FillArray(row, column, min, max);
PrintArray(array);
Console.WriteLine();
GetSumma(array);



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
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void GetSumma(int[,] inputArray)
{
    int t = int.MaxValue;
    int count = 0;
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        int summa = 0;
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            summa += inputArray[i, j];
        }
        Console.WriteLine($"Сумма элементов в {i + 1} строке равна " + summa);
        if (t > summa)
        {
            t = summa;
            count = i + 1;
        }
    }
    Console.WriteLine($"наименьшая сумма элементов в  строке " + count);
}

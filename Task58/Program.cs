// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

int[,] arrayFirst = FillArray(2, 3, 1, 9);
int[,] arraySecond = FillArray(3, 2, 1, 9);
PrintArray(arrayFirst);
PrintArray(arraySecond);
PrintArray(GetProductTwoMatrices(arrayFirst, arraySecond));

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

int[,] GetProductTwoMatrices(int[,] arrayA, int[,] arrayB)
{
    int aRows = arrayA.GetLength(0); int aCols = arrayA.GetLength(1);
    int bRows = arrayB.GetLength(0); int bCols = arrayB.GetLength(1);
    if (aCols != bRows)
    new Exception("Матрицы не соответствуют");
    int[,] result = new int[aRows, bCols];
    for (int i = 0; i < aRows; i++)
    {
        for (int j = 0; j < bCols; j++)
        {
            for (int k = 0; k < aCols; ++k)
            result[i, j] += arrayA[i, k] * arrayB[k, j];
        }
    }
    return result;
}

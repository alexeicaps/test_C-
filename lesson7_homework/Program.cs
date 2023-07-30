// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!);
// double[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);


// double[,] GetArray(int m, int n, int min, int max)
// {
//     double[,] array = new double[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = Math.Round(new Random().NextDouble() * 10, 2);
//         }
//     }
//     return array;
// }

// void PrintArray(double[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }


// -------------------------------------------------------

// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.


// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!);
// int[,] array = GetArray(rows, columns);
// PrintArray(array);
// double[] averageColumns = GetResultArray(array);
// Console.WriteLine($"Среднее арифметическое каждого столбца = {String.Join("; ", averageColumns)}");

// int[,] GetArray(int m, int n)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] =new Random().Next(0, 10);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// double[] GetResultArray(int[,] array)
// {
//     double[] result = new double[array.GetLength(1)];
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         double sum = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             sum += array[i, j];
//         }
//         result[j] = Math.Round(sum / array.GetLength(0), 2);
//     }
//     return result;
// }

// -------------------------------------------------

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату строки массива: ");
int coordrow = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату колонки массива: ");
int coordcolumn = int.Parse(Console.ReadLine()!);
int[,] array = GetArray2(rows, columns);
GetNumber(array, coordrow, coordcolumn);


int[,] GetArray2(int row, int column)
{
    int[,] arr = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(0, 100);
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    return arr;
}

void GetNumber(int[,] arr, int coordrow, int coordcolumn)
{
    if (coordrow > arr.GetLength(0) || coordcolumn > arr.GetLength(1)) 
    {
        Console.Write($"{coordrow}{coordcolumn} -> такого числа в массиве нет");
    }
    else
    {
        Console.WriteLine(array[coordrow, coordcolumn]);
    }
}

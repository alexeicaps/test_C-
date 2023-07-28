﻿Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
double[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
double[] averageColumns = GetResultArray(array);
Console.WriteLine($"Среднее арифметическое каждого столбца = {String.Join("; ", averageColumns)}");

double[,] GetArray(int m, int n, int min, int max)
{
    double[,] result = new double[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = Math.Round(rnd.NextDouble() * 100, 2);
        }

    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[] GetResultArray(double[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        result[j] = Math.Round(sum / array.GetLength(0), 2);
    }
    return result;
}
Console.Clear();


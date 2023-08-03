// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!);
// int[,] array = GetArray(rows, columns);
// Console.WriteLine();
// SortDecreaseRows(array);


// int[,] GetArray(int row, int column)
// {
//     int[,] arr = new int[row, column];
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < column; j++)
//         {
//             arr[i, j] = new Random().Next(10, 50);
//             Console.Write($"{arr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     return arr;
// }

// void SortDecreaseRows(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             for (int k = j + 1; k < arr.GetLength(1); k++)
//             {
//                 if (arr[i, j] < arr[i, k])
//                 {
//                     int temp = arr[i, j];
//                     arr[i, j] = arr[i, k];
//                     arr[i, k] = temp;
//                 }

//             }
//             Console.Write($"{arr[i, j]} ");
//         }
//         Console.WriteLine();
//     }

// }


// -------------------------------------------------------------------------------------------------------


// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.


// int[,] array = GetArray(4, 4);
// PrintArray(array);


// int[,] GetArray(int m, int n)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }


// void GetRowsNumber(int[,] array)
// {
//     int row = 0;
//     int sum = 0;
//     int minSum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum = sum + array[i, j];
//             {
//                 if (i == 0)
//                 minSum = sum;
//             }
//         }
//         Console.Write($"{sum} ");
//         if (sum < minSum)
//         {
//             minSum = sum;
//             row = i + 1;

//         }
//     }
//     Console.WriteLine();
//     Console.WriteLine($"{minSum} -> {row}");
// }

// GetRowsNumber(array);






// -----------------------------------------------------------------

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



Console.Write("Введите размерность m массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность n массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] randomArray1 = GetArray(m, n);
int[,] randomArray2 = GetArray(m, n);
Console.WriteLine("\nДаны 2 матрицы: ");
PrintArray(randomArray1);
Console.WriteLine();
PrintArray(randomArray2);
int[,] resultArray = GetMultiplyMatrix(randomArray1, randomArray2);
Console.WriteLine("\nПроизведение двух матриц: ");
PrintArray(resultArray);


int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 5);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] GetMultiplyMatrix(int[,] array1, int[,] array2)
{
    int[,] resultArr = new int[array1.GetLength(0), array1.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                resultArr[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return resultArr;
}






// Задача 54(2): Задайте двумерный массив. Напишите программу, 
// которая упорядочит по возрастанию элементы каждого столбца двумерного массива.
// Например, задан массив:
// 9 4 7 2
// 5 9 6 7
// 8 4 2 4
// В итоге получается вот такой массив:
// 5 4 2 2
// 8 4 6 4
// 9 9 7 7


// Console.Write("Type numbers of rows: \t");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Type numbers of columns: ");
// int columns = int.Parse(Console.ReadLine()!);
// int[,] array = FillArray(rows, columns);
// Console.WriteLine();
// SortIncreaseColumn(array);


// int[,] FillArray(int row, int column)
// {
//     int[,] arr = new int[row, column];
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < column; j++)
//         {
//             arr[i, j] = new Random().Next(10, 90);
//             Console.Write(arr[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     return arr;
// }


// void SortIncreaseColumn(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             for (int k = i + 1; k < arr.GetLength(1); k++)
//             {
//                 if (arr[i, j] > arr[k, j])
//                 {
//                     int temp = arr[i, j];
//                     arr[i, j] = arr[k, j];
//                     arr[k, j] = temp;
//                 }

//             }
//             Console.Write($"{arr[i, j]} ");
//         }
//         Console.WriteLine();
//     }

// }
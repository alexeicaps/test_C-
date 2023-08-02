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


// int[,] array = GetArray(4, 6);
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

// int GetSumEveryRows(int[,] array, int i)
// {
//     int row = 0;
//     int minSum = 0;

//     {
//         int[,] arraySum = new int[array.GetLength(1), 0];
//         for (int i = 0; i < array.GetLength(1); i++)
//         {
//             int result = 0;
//             for (int j = 0; j < array.GetLength(0); j++)
//             {
//                 result = result + array.Length[j];
//             }
//             return result;
//         }
//         return arraySum;
//     }
// }

// GetSumEveryRows(array);



// --------------------------------------------------------------------------

Console.Write("Введите размерность m массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность n массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[m, n];

void mas(int m, int n)
{
    int i, j;
    Random rand = new Random();
    for (i = 0; i < m; i++)
    {
        for (j = 0; j < n; j++)
        {
            randomArray[i, j] = rand.Next(1, 9);
        }
    }
}

void printm(int[,] array)
{
    int i, j;
    for (i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        // Console.WriteLine();
    }
}

mas(m, n);
Console.WriteLine("\nИсходный массив: ");
printm(randomArray);

// Функция, считающая сумму элементов в строке
int SumLine(int[,] array, int i)
{
    int sum = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    return sum;
}

int minSum = 1;
int sum = SumLine(randomArray, 0);
for (int i = 1; i < randomArray.GetLength(0); i++)
{
    if (sum > SumLine(randomArray, i))
    {
        sum = SumLine(randomArray, i);
        minSum = i + 1;
    }
}

Console.WriteLine($"\nСтрока c наименьшей суммой элементов: {minSum}");





// -----------------------------------------------------------------

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18










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
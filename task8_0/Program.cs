// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.


// int[,] GetArray(int m, int n)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(10, 100);
//         }

//     }
//     return result;
// }

// int[,] ChangeLines(int[,] array)
// {
//     int[] temp = new int[array.GetLength(1)];
//     for (int i = 0; i < temp.Length; i++)
//     {
//         temp[i] = array[0, i];
//         array[0, i] = array[array.GetLength(0) - 1, i];
//         array[array.GetLength(0) - 1, i] = temp[i];

//     }
//     return array;
// }

// void PrintArray(int [,] array){
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         Console.Write($"{ array[i, j] } ");
//     }
//     System.Console.WriteLine();
// }
// }

// int[,] array = GetArray(5, 6);
// PrintArray(array);
// array = ChangeLines(array);
// System.Console.WriteLine();
// PrintArray(array);



// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// int[,] array = GetArray(5, 6);
// PrintArray(array);
// array = Change(array);
// System.Console.WriteLine();
// PrintArray(array);

// int[,] GetArray(int m, int n)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(10, 100);
//         }

//     }
//     return result;
// }

// int[,] Change(int[,] array)
// {
//     int[,] result = new int[array.GetLength(1), array.GetLength(0)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             result[j, i] = array[i, j];
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         System.Console.WriteLine();
//     }
// }



// ------------------------------------------------------------------------------------------------------------------------------

// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns, -10, 10);
PrintArray(array);
Console.WriteLine();
int[] rowAr = GetRowArray(array);
SortArray(rowAr);
Console.WriteLine(String.Join(" ", rowAr));
PrintData(rowAr);

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
}
int[] GetRowArray(int[,] inArray)
{
    int[] result = new int[inArray.GetLength(0) * inArray.GetLength(1)];
    int index = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            result[index] = inArray[i, j];
            index++;
        }
    }
    return result;
}
void SortArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        for (int j = i + 1; j < inArray.Length; j++)
        {
            if (inArray[i] > inArray[j])
            {
                int k = inArray[i];
                inArray[i] = inArray[j];
                inArray[j] = k;
            }
        }
    }
}
void PrintArray(int[,] inArray)
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

void PrintData(int[] inArray)
{
    int el = inArray[0];
    int count = 1;
    for (int i = 1; i < inArray.Length; i++)
    {
        if (inArray[i] != el)
        {
            Console.WriteLine($"{el} встречается {count}");
            el = inArray[i];
            count = 1;
        }
        else
        {
            count++;
        }
    }
    Console.WriteLine($"{el} встречается {count}");
}
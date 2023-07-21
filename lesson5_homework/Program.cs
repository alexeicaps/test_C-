﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// int a = Prompt("type number of array: ");
// int[] randomArray = new int[a];

// int Prompt(string message)
// {
//     Console.Write(message);
//     int num = int.Parse(Console.ReadLine()!);
//     return num;    
// }

// void GetArray(int array)
// {
//     for (int i = 0; i < array; i++)
//     {
//         if(i == 0)
//         {
//             Console.Write("[");
//         }
//         randomArray[i] = new Random().Next(100, 1000);
//         Console.Write(randomArray[i]);
//         if (i == array - 1)
//         {
//             Console.Write("]");
//         }
//         if (i != array - 1)
//         {
//             Console.Write(", ");
//         }
//     }
// }

// int evenNumbers(int[] ran)
// {
//     int countNum = 0;
//     for (int i = 0; i < ran.Length; i++)
//     {
//         if (i % 2 == 0)
//         countNum += 1;   
//     }
//     return countNum;
// }

// GetArray(a);
// int countNumbers = evenNumbers(randomArray);
// Console.WriteLine(" -> " + countNumbers);



//---------------------------------------------------------------------------------------------

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] array = GetArray(12, -9, 10);

int[] GetArray(int size, int minValue, int maxValue)
{
    int[]result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue);
        Console.Write($"{result[i]} ");
    }
    return result;
}



// int Prompt(string message)
// {
//     Console.Write(message);
//     int num = int.Parse(Console.ReadLine()!);
//     return num;
// }


// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
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

// int sizeArray = Prompt("Введите длину массива: ");
// int min = Prompt("Введите минимальное значение диапазона для элементов массива: ");
// int max = Prompt("Введите максимальное значение диапазона для элементов массива: ");

// int[] array = GetArray(sizeArray, min, max);


// int Prompt(string message)
// {
//     Console.Write(message);
//     int num = int.Parse(Console.ReadLine()!);
//     return num;
// }


// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue);
//         Console.Write($"{result[i]} ");
//     }
//     return result;
// }

// int oddNumbers(int[] arr)
// {
//     int sumElements = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i % 2 != 0)
//         sumElements = sumElements + arr[i];
//     }
//     return sumElements;
// }

// int result = oddNumbers(array);
// Console.WriteLine(" -> " + result);


// ==============================================

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}



int a = Prompt("Введите количество элементов: ");
GetArray(a);



void GetArray(double[] arr)
{
    double[] rand = new double[0];
    for (int i = 0; i < arr.Length; i++)
    {
        rand[i] = new Random().NextDouble();
        Console.Write($"{rand[i]}");
    }
}



double[] Difference(double[] ran)
{
    double minValue = 0;
    double maxValue = 0;
    int i = 1;
    while (i < ran.Length )
    {
        if (minValue )
    }
}



// ----------------------------------------

// Console.Write("Введите количество элементов массива: ");
// int a = Convert.ToInt32(Console.ReadLine());
// double[] randomArray = new double[a];

// void mas(int a)
// {
// Random rand = new Random();
// for (int i = 0; i < a; i++)
// {
// randomArray[i] = rand.NextDouble();
// Console.Write($"{randomArray[i]:F2} ");
// }

// }

// double raz(double[] randomArray)
// {
// double min = randomArray[0];
// double max = randomArray[0];
// int i = 1;
// while (i < randomArray.Length)
// {
// if (max<randomArray[i])
// max = randomArray[i];
// if (min>randomArray[i])
// min = randomArray[i];
// i = i + 1;
// }
// return max-min;
// }

// mas(a);
// Console.Write($"\nРазница между максимальным и минимальным элементов массива: {raz(randomArray):F2}");
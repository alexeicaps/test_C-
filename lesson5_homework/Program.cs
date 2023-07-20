// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int sizeArray = GetNum("Type the size: ");

int[] result = GetArray(sizeArray);
PrintArray(result);

Console.Write($"\n чётных чисел в массиве: {EvenNumbers(result)}");



int GetNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(100, 1000);
        // Console.Write($"{result[i]} ");
    }
    return result;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{result[i]} ");
    }
}

int[] EvenNumbers(int[] arr1)
{
    for (int i = 0; i < arr1.Length; i++)
    {
        int evenCount = 0;
        if (arr1[i] % 2 == 0)
        evenCount += 1;
        return evenCount;
    }
}


//---------------------------------------------------------------

// Console.Write("Введите количество элементов массива: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int[] randomArray = new int[a];

// void mas(int a)
// {
//     for (int i = 0; i < a; i++)
//     {
//         randomArray[i] = new Random().Next(99, 999);
//         Console.Write(randomArray[i] + " ");
//     }

// }

// int kol(int[] randomArray)
// {
//     int kol = 0;
//     for (int i = 0; i < randomArray.Length; i++)
//     {
//         if (randomArray[i] % 2 == 0)
//             kol = kol + 1;
//     }
//     return kol;
// }

// mas(a);
// Console.Write($"\nКоличество чётных чисел в массиве: {kol(randomArray)}");













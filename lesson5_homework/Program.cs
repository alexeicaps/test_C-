// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int sizeArray = GetNum("Type the size: ");



int[] result = GetArray(sizeArray);
PrintArray(result);

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

// int[] evenNumbersCount(int size)
// {
//     int count = 0;
//     while (i < size)
//     {
//         if 
//         {
//             count = count
//         } 
//     }
// }







void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{result[i]} ");
    }
}








// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int a = Prompt("type the size of array: ");
int[] array = FillArray(a);
PrintArray(a);


int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;    
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}


int[] FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 200);
        Console.Write($"{arr[i]} ");
    }
    return arr;
}

int rangeDigits(int[] arr)
{
    int countNumbers = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (i > 10 && i < 99) countNumbers += i;
    }
    return countNumbers;
}


FillArray(array);
int res = rangeDigits(array);
Console.WriteLine(" -> " + res);
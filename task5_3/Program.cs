// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


int[] array = new int[123];

int[] FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 200);
        Console.Write($"{arr[i]} ");
    }
    return arr;
}

int[] rangeDigits(int[] arr)
{
    int[] resultArray = new int[123];
    foreach (int el in arr)
    {
        if (el > 10 || el < 99) resultArray[] += el;
    }
    return resultArray;
}


FillArray(array);
int[] res = rangeDigits(FillArray(array));
Console.WriteLine(res);
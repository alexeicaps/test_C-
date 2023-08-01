﻿// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


int k = 0;
void FillNumbers(int n)
{

    if (n > 0)
    {
        FillNumbers(n - 1);
        k++;
        Console.Write($" {k}");
    }
}

FillNumbers(55);

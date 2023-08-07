// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Write("Type numbers of N elements: ");
// int N = int.Parse(Console.ReadLine()!);
// PrintArray(N);


// void PrintArray(int n)
// {
//     if (n > 0)
//     {
//         Console.Write($"{n}, ");
//         PrintArray(n - 1);
//     }
// }



// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Type numbers of M elements: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Type numbers of N elements: ");
int N = int.Parse(Console.ReadLine()!);
GetSumNumbers(M, N);

int GetSumNumbers(int m, int n)
{
    int[] = new arr[m, n];
    if (m < n)
    {
        int sum = 0;
        return m + GetSumNumbers(m + 1 + sum, n);
    }
    else
    {
        return "";
    }
}


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
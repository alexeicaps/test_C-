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

// Console.Write("Задайте значения M: ");
// int M = int.Parse(Console.ReadLine()!);
// Console.Write("Задайте значения N: ");
// int N = int.Parse(Console.ReadLine()!);
// Console.Write($"M = {M}; N = {N} -> {GetSumNumbers(M, N)}");


// int GetSumNumbers(int m, int n)
// {
//     if (m < n)
//     {
//         return m + GetSumNumbers(m + 1, n);
//     }
//     else
//     {
//         return n;
//     }
// }


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите неотрицательное число m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите неотрицательное число n: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write($"m = {m}, n = {n} -> A(m, n) = {GetAkkerman(m, n)} ");


int GetAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return GetAkkerman(m - 1, 1);
    else return GetAkkerman(m - 1, GetAkkerman(m, n - 1));
}



// --------------------------------------------------------------------------------------------------------------------------------------



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.Write("type m: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.Write("type n: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write($"m = {m}, n = {n} -> A(m, n) = {GetAkkerman(m, n)} ");


// int GetAkkerman(int m, int n)
// {
//     if (m == 0) return n + 1;
//     else if (m > 0 && n == 0) return GetAkkerman(m - 1, 1);
//     else return GetAkkerman(m - 1, GetAkkerman(m, n - 1));
// }

// int akkerman(int m, int n)
// {
// if (m == 0) return n + 1;
// else if (n == 0) return akkerman(m - 1, 1);
// else (m > 0 && n > 0) return akkerman(m - 1, akkerman(m, n - 1)); ??? 
// }

// Console.Write($"-> {akkerman(m, n)} ");
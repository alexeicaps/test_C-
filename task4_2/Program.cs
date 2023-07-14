// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120


int GetNumber(string message)
{
    Console.Write(message);                     // печатается на консоль
    return int.Parse(Console.ReadLine()!);      // возврат
}

void SummNumber(int arg)                       // Определяет длину числа
{
    int a = 1;
    for (int i = 1; i <= arg; i++)
    {
        a *= i;
    }
    Console.WriteLine($"Произведение чисел от 1 до {arg} равно {a}");
}

int number = GetNumber("Введите число => ");
SummNumber(number);
// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

// Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine());
// int number1 = int.Parse(Console.ReadLine());
//     if (number1 * number1 == number)
//     {
//         Console.WriteLine("Да");
//     }
//     else
//     {
//         Console.WriteLine("Нет");
//     }




// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница


Console.WriteLine("введите число: ");
int number = int.Parse(Console.ReadLine()!);
string day1 = "понедельник";
string day2 = "вторник";
string day3 = "среда";
string day4 = "четверг";
string day5 = "пятница";
string day6 = "суббота";
string day7 = "воскресенье";
    if (1 == number)
    {
        Console.WriteLine(day1);
    }
    else if (2 == number)
    {
        Console.WriteLine(day2);
    }
    else if (3 == number)
    {
        Console.WriteLine(day3);
    }
    else if (4 == number)
    {
        Console.WriteLine(day4);
    }
    else if (5 == number)
    {
        Console.WriteLine(day5);
    }
    else if (6 == number)
    {
        Console.WriteLine(day6);
    }
    else if (7 == number)
    {
        Console.WriteLine(day7);
    }
    else
    {
        Console.WriteLine("Неверное число");
    }
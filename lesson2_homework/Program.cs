// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


// Console.Write("Введите трёхзначное число: ");
// int number = int.Parse(Console.ReadLine()!);

// void GetSecondDigit(int number1)
// {
//     if (number1 >= 100 && number1 < 1000)
//     {
//         int second = (number1 % 100 - number1 % 10) / 10;
//         Console.WriteLine(second);
//     }
//     else
//     {
//         Console.WriteLine("Это число не трехзначное");
//     }
// }

// GetSecondDigit(number);


// ---------------------------------------------------------------------------------------------------------------------------------------

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);

// int ThirdDigit(int number1)
// {
//     // int result = -1;
//     int result = int.Parse("Третьей цифры нет");
//     if (number1 >= 100)
//     {
//         while (number1 > 999)
//         {
//             number1 = number1 / 10;
//         }
//         result = number1 % 10;
//     }
//     return result; 
//     // else
//     // {
//     //     Console.WriteLine("Третьей цифры нет");
//     // }
// }
// int num = ThirdDigit(number);
// Console.WriteLine(num);


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// string mess = "Введите число: ";
// int number1 = Prompt(mess);
// int number2 = Prompt("Введите пятизначное число");

// int result1 = FindThirdNumber(number1);
// int result2 = FindThirdNumber(number2);

// GetResult(result1);
// GetResult(result2);



// void GetResult(int res)
// {
//     if (res == -1)
//     {
//         Console.WriteLine("Такой цифры нет! ");
//     }
//     else
//     {
//         Console.WriteLine($"Третья цифра числа {res}");
//     }
// }



// int Prompt(string message)
// {
//     Console.Clear();
//     Console.WriteLine(message);
//     int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
//     return num;
// }

// int FindThirdNumber(int num)
// {
//     if (num < 100)
//     {
//         return -1;

//     }
//     else
//     {
//         while (num >= 1000)
//         {
//             num = num / 10;
//         }
//         int thirdNumber = num % 10;
//         return thirdNumber;
//     }
// }

// ---------------------------------------------------------------------------------------------------------------------------------------
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


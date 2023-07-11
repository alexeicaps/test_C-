// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98


// int GetRandomNumber()
// {
//     int number = new Random().Next(100, 1000);
//     return number;
// }

// int GetFirstDigit(int number1)
// {
//     // number1 = number1 / 100;
//     return number1 / 100;
// }

// int GetLastDigit(int number1)
// {
//     return number1 % 10;
// }

// int random = GetRandomNumber();
// int firstDigit = GetFirstDigit(random);
// int lastDigit = GetLastDigit(random);
// Console.WriteLine(random);
// Console.Write(firstDigit);
// Console.WriteLine(lastDigit);

// ------------------------------------------------------

// int NewRandom(){
//     int number = new Random().Next(100, 1000);
//     return number;
// }
// int RemoveSecondDigit(int random)
//     {
//         int firstDigit = random / 100;     
//         int thirdDigit = random % 10;       

//         int mNumber = firstDigit * 10 + thirdDigit;    
//         return mNumber;
//     }
// int random = NewRandom();
// Console.WriteLine($"число: {random}");
// int mNumber = RemoveSecondDigit(random);
// Console.WriteLine($"Новое число: {mNumber}");

// ------------------------------------------------------------------------------------------------------------

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// Console.WriteLine("Введите первое число: ");
// int a = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");
// int b = int.Parse(Console.ReadLine());

// if (a % b == 0)
// {
//     Console.WriteLine("1 число кратно второму");
// }
// else
// {
//     Console.WriteLine("второе число не кратно первому " + (a % b));
// }


// ------------------------------------------------------------------------------

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

void Multiply(int number1)
{
    if (number1 % 7 == 0 && number1 % 23 == 0)
    {
        Console.WriteLine("Данное число кратно и 7, и 23 одновременно");
    }
    else
    {
        Console.WriteLine("Данное число не кратно и 7, и 23 одновременно");
    }
}

Multiply(number);




// --------------------------------------------------------------------------------

// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет
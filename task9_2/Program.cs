// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int digitsSum(int number)
{
    if(number==0) return 0;
    return number % 10 + digitsSum(number/10) * 2;
}

int sum = digitsSum(453);
Console.WriteLine(sum);
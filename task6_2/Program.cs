// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int num1 = Prompt("Введите десятичное число: ");

string collect = "";
int result = num1;

while (result > 0)
{
    
    collect = result % 2 + collect;

    result = result / 2;
}

// int collection = int.Parse(collect);
// int[] array = new int[collection];

// void ReverseArray1(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
//     }
// }

Console.WriteLine(collect);

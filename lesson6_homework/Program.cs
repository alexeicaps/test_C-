// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int length = Prompt("Введите колличество элементов: ");
int[] array;
array = GetArray(length);
PrintArray(array);
Console.WriteLine($" -> {GetPositiveNumbers(array)}");


int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int[] GetArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt($"Введите {i + 1}-й элемент: ");
    }
    return array;
}

int GetPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count = count + 1;
    }
    return count;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) 
        Console.Write($"{array[i]}");
        else
        Console.Write($"{array[i]}, ");    
    }
    
}
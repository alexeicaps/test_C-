// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

void Main(string[] args)
    {
        int[] array = { 6, 7, 19, 345, 3 };
        int targetNumber;

        Console.Write("Введите число для поиска: ");
        if (int.TryParse(Console.ReadLine(), out targetNumber))
        {
            if (ArrayContainsNumber(array, targetNumber))
                Console.WriteLine("Да, число {0} присутствует в массиве.", targetNumber);
            else
                Console.WriteLine("Нет, число {0} отсутствует в массиве.", targetNumber);
        }
        else
        {
            Console.WriteLine("Введено некорректное число.");
        }
    }

    static bool ArrayContainsNumber(int[] array, int target)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == target)
                return true;
        }
        return false;
    }

    Main(args);
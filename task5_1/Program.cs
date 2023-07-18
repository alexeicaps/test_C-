// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

{
    static void Main(string[] args)
    {
        int[] array = { -4, -8, 8, 2 };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
                array[i] = -array[i];
            else if (array[i] < 0)
                array[i] = -array[i];
        }

        Console.WriteLine("Измененный массив:");
        PrintArray(array);
    }

    static void PrintArray(int[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1)
                Console.Write(", ");
        }
        Console.WriteLine("]");
    }
}
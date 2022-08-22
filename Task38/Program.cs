// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


    Console.WriteLine();
    Console.Write("Введите количество чисел в массиве: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[n];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
        Console.Write(array[i] + " ");
    }

    int max = array[0];
    int min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
        if (array[i] < min) min = array[i];

    }
    Console.WriteLine(" ");
    Console.WriteLine("max = " + max + " min = " + min);
    Console.WriteLine("Разница между максимальным и минимальным элементом массива: " + (max - min));

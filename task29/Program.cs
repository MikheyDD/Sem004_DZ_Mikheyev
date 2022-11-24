// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Сделал 2 массива, один строго из 8 элементов, а во втором количество элементов задается рандомно. Вроде оба отображаются верно.

int[] array1 = new int[new Random().Next(2, 10)];
int[] array2 = new int [8];
PrintArray(array1);
Console.WriteLine();
FillArray(array1);
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
FillArray(array2);
PrintArray(array2);

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 99);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}
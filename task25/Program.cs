// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Через ввод числа с клавиатуры

Console.WriteLine("Введите число 1 ");
var num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2 ");
var num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetPow(num1, num2));

int GetPow(int num1, int num2)
{
    int result = 1;
    for (int i = 1; i <= num2; i++)
    {
        result = result * num1;
    }
    return result;
}

// Через  рандом

int num3 = new Random().Next(0, 10);
Console.WriteLine($"число 3 =  {num3}");
int num4 = new Random().Next(0, 10);
Console.WriteLine($"число 4 =  {num3}");
Console.WriteLine(GetPow(num3, num4));
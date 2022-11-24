// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Через рандом
int num = new Random().Next(10, 1000000);
Console.WriteLine($"число  =  {num}");
Console.WriteLine(GetSum(num));
int GetSum(int num)
{
    int result = 0;
    int div = 0;
    while (num != 0)
    {
        div = num % 10;
        result = result + div;
        num = num / 10;
    }
    return result;
}
// Через ввод с клавиатуры
Console.WriteLine("Введите число ");
var num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetSum(num1));
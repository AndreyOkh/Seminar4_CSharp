// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите число: ");
string num = Console.ReadLine()!;
int numLength = num.Length;

Console.WriteLine($"В числе {num} {numLength} символов.");
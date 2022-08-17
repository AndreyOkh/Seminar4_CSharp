// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int a = ReadLine("Введите первое число: ");
int b = ReadLine("Введите второе число: ");

Console.WriteLine(Degre(a, b));

int ReadLine(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Degre(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result *= a;
    }
    return result;
}
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

string number = ReadLine("Введите число: ");
Console.WriteLine(GetSum(number));

string ReadLine(string message)
{
    Console.Write(message);
    return Console.ReadLine()!;
}

int GetSum(string number)
{
    int sum = 0;
    for (int i = 0; i < number.Length; i++)
    {
        sum += Convert.ToInt32(number[i]) - 48;
        
    }
    return sum;
}
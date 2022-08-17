// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
// 5 -> [1, 2, 5, 7, 19]
// 3 -> [6, 1, 33]

int arrayLegth = ReadLine("Введите размер массива: ");
int[] array = new int[arrayLegth];
FillArray(array);
PrintArray(array);

int ReadLine(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        int random = new Random().Next(0, 10);
        array[i] = random;
    }
}

void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}
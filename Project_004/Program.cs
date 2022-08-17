// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] a = new int[8];
FillArray(a);
PrintArray(a);

void FillArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        int random = new Random().Next(0, 2);
        array[i] = random;
    }
}

void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        Console.Write(item + " ");
    }
}
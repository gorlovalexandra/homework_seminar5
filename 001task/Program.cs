/* 1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве. */

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(100, 1000);
        Console.Write(array[index] + " ");
        index++;
    }
}

void EvenNumbers(int[] array)
{
    int N = 0;
    int index = 0;
    int len = array.Length;

    while (index < len)
    {
        if (array[index] % 2 == 0)
        {
            N = N + 1;
        }
        index++;
    }
    Console.WriteLine(N);
}

int[] array = new int[5];
FillArray(array);
Console.WriteLine();

EvenNumbers(array);
Console.WriteLine();
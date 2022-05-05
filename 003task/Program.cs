/* Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива. */

void FillArray(double[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(-99, 100) + new Random().NextDouble();
        Console.Write((Math.Round(array[index], 2)) + " ");
        index++;
    }
}

void MaxMinNumber(double[] array)
{

    int len = array.Length;
    int index = 0;
    double max = 0;
    double min = 0;

    while (index < len)
    {
        if (array[index] > max)
        {
            max = array[index];
        }
        index++;
    }

    int index1 = 0;
    
    while (index1 < len)
    {
        if (array[index1] < min)
        {
            min = array[index1];
        }
        index1++;
    }

    double maxmin = max - min;
    Console.WriteLine(Math.Round(maxmin, 2));
}

double[] array = new double[5];
FillArray(array);
Console.WriteLine();

MaxMinNumber(array);
Console.WriteLine();

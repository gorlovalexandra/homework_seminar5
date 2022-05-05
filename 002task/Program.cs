/* Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях. */

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(-999, 1000);
        Console.Write(array[index] + " ");
        index++;
    }
}

// если позиция - это индекс, то так:
void SumOfOddIndexes(int[] array)
{
    int Sum = 0;
    int index = 1;
    int length = array.Length;

    while(index < length)
    {
        Sum = Sum + array[index];
        index = index + 2;
    }
    Console.WriteLine(Sum);
}

int[] array = new int[10];
FillArray(array);
Console.WriteLine();

SumOfOddIndexes(array);
Console.WriteLine();
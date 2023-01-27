/*
Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на чётных позициях.

[3, 7, 23, 12] -> 19,

[-4, -6, 89, 6] -> 0
*/

int[] CreateAndFillArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) Console.Write($"{array[i]} ");

        else Console.Write($"{array[i]}, ");
    }
    Console.Write("]");
}

int SumOfEvenPositionedNumbers(int[] array)
{
    int sumOfEvenPosNums = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((i + 1) % 2 == 0) sumOfEvenPosNums = sumOfEvenPosNums + array[i];
    }
    return sumOfEvenPosNums;
}

Console.Write("Enter length of an array ");
int length = int.Parse(Console.ReadLine()!);

Console.Write("Enter minimum value of random numbers ");
int minValue = int.Parse(Console.ReadLine()!);

Console.Write("Enter maximum value of random numbers ");
int maxValue = int.Parse(Console.ReadLine()!);

int[] arr = new int[length];
CreateAndFillArray(length, minValue, maxValue).CopyTo(arr, 0);

PrintArray(arr);

Console.WriteLine();

Console.Write($"Sum of even positioned numbers is {SumOfEvenPositionedNumbers(arr)}");

/*
Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на чётных позициях.

[3, 7, 23, 12] -> 19,

[-4, -6, 89, 6] -> 0
*/

int[] CreateAndFillArray(int length, int firstBound, int secondBound)
{   
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(firstBound, secondBound);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
    {   
        if(i == array.Length - 1)
        {
            Console.Write($"{array[i]} ");
        }
        else
        {
            Console.Write($"{array[i]}, ");
        }
    }
    Console.Write("]");
}

int SumOfEvenPositionedNumbers(int[] array)
{
    int sumOfEvenPosNums = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if((i+1) % 2 == 0) sumOfEvenPosNums = sumOfEvenPosNums + array[i];
    }
    return sumOfEvenPosNums;
}

Console.Write("Enter length of an array ");
    int len = int.Parse(Console.ReadLine()!);

Console.Write("Enter start limit of random numbers range ");
    int fstBound = int.Parse(Console.ReadLine()!);

Console.Write("Enter end limit of random numbers range ");
    int sndBound = int.Parse(Console.ReadLine()!);

int[] arr = new int[len];
CreateAndFillArray(len, fstBound, sndBound).CopyTo(arr, 0);

PrintArray(arr);

    Console.WriteLine();

Console.Write($"Sum of even positioned numbers is {SumOfEvenPositionedNumbers(arr)}");

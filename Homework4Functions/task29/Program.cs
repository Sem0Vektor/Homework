/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

int[] CreateAndFillArray(int length, int minValue = -100, int maxValue = 100)
{   
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
    {   
        if(i == array.Length - 1) Console.Write($"{array[i]} ");
        else Console.Write($"{array[i]}, ");
    }
    Console.Write("]");
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

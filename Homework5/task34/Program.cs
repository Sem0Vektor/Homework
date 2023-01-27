/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
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

int FindEvenNumber(int[] array)
{
    int countOfEvenNumvers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) countOfEvenNumvers++;
    }
    return countOfEvenNumvers;
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

Console.Write($"Amount of even numbers in the array is {FindEvenNumber(arr)}");

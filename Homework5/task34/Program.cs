/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

int[] CreateAndFillArray(int length)
{   
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100, 1000);
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

int FindEvenNumber(int[] array)
{
    int countOfEvenNumvers = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) countOfEvenNumvers++;
    }
    return countOfEvenNumvers;
}

Console.Write("Enter length of an array ");
int len = int.Parse(Console.ReadLine()!);

PrintArray(CreateAndFillArray(len));

    Console.WriteLine();

Console.Write($"Amount of even numbers in the array is {FindEvenNumber(CreateAndFillArray(len))}");

/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

double[] CreateAndFillArray(int length, double minValue, double maxValue)
{   
    double[] array = new double[length];
    for(int i = 0; i < length; i++)
    {
        double d = new Random().NextDouble();
        double rD = d * (maxValue - minValue) + minValue;
        array[i] = rD;
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
    {   
        if(i == array.Length - 1) Console.Write($"{array[i]} ");

        else Console.Write($"{array[i]}, ");
    }
    Console.Write("]");
}

double DifBetweenMaxNumAndMinNum(double[] array)
{
    double min = 0;
    double max = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < min) min = array[i];
        else
        if(array[i] > max) max = array[i];
    }
    double dif = max - min;
    return dif;
}

Console.Write("Enter length of an array ");
int length = int.Parse(Console.ReadLine()!);

Console.Write("Enter minimum value of random numbers ");
double minValue = double.Parse(Console.ReadLine()!);

Console.Write("Enter maximum value of random numbers ");
double maxValue = double.Parse(Console.ReadLine()!);

double[] arr = new double[length];
CreateAndFillArray(length, minValue, maxValue).CopyTo(arr, 0);

PrintArray(arr);

Console.WriteLine();

Console.Write($"Difference between maximum number and minimum number is {DifBetweenMaxNumAndMinNum(arr)}");

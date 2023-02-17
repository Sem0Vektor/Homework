/*

Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

*/

int[,] CreateNFillArrayV3(int rows, int columns, int minValue = -10, int maxValue = 10)
{
    int[,] array = new int[rows, columns];

    var rnd = new Random();
    for (int r = 0; r < rows; r++)
    {
        for (int c = 0; c < columns; c++)
        {
            array[r, c] = rnd.Next(minValue, maxValue);
        }
    }
    return array;
}

void PrintArrayV3(int[,] array)
{
    for (int r = 0; r < array.GetLength(0); r++)
    {
        for (int c = 0; c < array.GetLength(1); c++)
        {
            Console.Write($"{array[r, c],3}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int SmallestSum(int[,] array)
{
    int[] sums = new int[array.GetLength(0)];
    for (int r = 0; r < array.GetLength(0); r++)
    {
        for (int c = 0; c < array.GetLength(1); c++)
        {
            sums[r] += array[r,c];
        }
    }
    int rowOfMinSum = 0;
    for(int i = 0; i < sums.Length; i++)
    {
        if(sums[i] < sums[rowOfMinSum]) rowOfMinSum = i;
    }
    return rowOfMinSum++;
}

Console.Write("Enter rows of an array ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Enter columns of the array ");
int columns = int.Parse(Console.ReadLine()!);

Console.Write("Enter minimum value of elements ");
int minValue = int.Parse(Console.ReadLine()!);
Console.Write("Enter maximum value of elements ");
int maxValue = int.Parse(Console.ReadLine()!);

int[,] array = CreateNFillArrayV3(rows, columns, minValue, maxValue);
PrintArrayV3(array);
Console.Write($"Number of smallest row is {SmallestSum(array)}");

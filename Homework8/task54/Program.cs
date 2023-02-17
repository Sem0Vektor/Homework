/*

Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2

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

int[,] SelectionSort(int[,] array)
{
    for (int r = 0; r < array.GetLength(0); r++)
    {
        int length = array.GetLength(1);
        for (int c = 0; c < length - 1; c++)
        {
            int minPosition = c;

            for (int j = c + 1; j < length; j++)
            {
                if (array[r, j] > array[r, minPosition]) minPosition = j;
            }
            int temporary = array[r, c];
            array[r, c] = array[r, minPosition];
            array[r, minPosition] = temporary;
        }
    }
    return array;
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
Console.WriteLine("Sorted array");
PrintArrayV3(SelectionSort(array));

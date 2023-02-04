/*

Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1, 7 -> такого числа в массиве нет

*/

double[,] CreateNFillArrayV3(int rows, int columns, double minValue = -10, double maxValue = 10)
{
    double[,] array = new double[rows, columns];

    var rnd = new Random();
    for (int r = 0; r < array.GetLength(0); r++)
    {
        for (int c = 0; c < array.GetLength(1); c++)
        {
            array[r, c] = Math.Round((rnd.NextDouble() * (maxValue - minValue) + minValue), 2);
        }
    }
    return array;
}

void PrintArrayV3(double[,] array)
{
    for (int r = 0; r < array.GetLength(0); r++)
    {
        for (int c = 0; c < array.GetLength(1); c++)
        {
            Console.Write($"{array[r, c],6}");
        }
        Console.WriteLine();
    }
}

void FindElement(double[,] array, int rows, int columns)
{
    Console.Write("Enter Row position ");
    int r = int.Parse(Console.ReadLine()!);

    Console.Write("Enter Column position ");
    int c = int.Parse(Console.ReadLine()!);

    if(r > rows || r < 0 | c > columns || c < 0)
    {
        Console.WriteLine("Maybe you made a mistake with request ;( ");
    }
    else
    {
        Console.WriteLine($"This is the element you were looking for -> {array[r,c]}");
    }
}

Console.Write("Enter rows of an array ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Enter columns of an array ");
int columns = int.Parse(Console.ReadLine()!);

Console.Write("Enter minimum value of elements ");
double minValue = double.Parse(Console.ReadLine()!);

Console.Write("Enter maximum value of elements ");
double maxValue = double.Parse(Console.ReadLine()!);

double[,] array = CreateNFillArrayV3(rows, columns, minValue, maxValue);
PrintArrayV3(array);

FindElement(array, rows, columns);

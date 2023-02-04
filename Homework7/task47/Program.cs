/*

Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9

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
            Console.Write($"{array[r, c], 6}");
        }
        Console.WriteLine();
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
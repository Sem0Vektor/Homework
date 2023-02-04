/*

Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
            Console.Write($"{array[r, c], 3}");
        }
        Console.WriteLine();
    }
}

void ArithmeticMean(int[,] array)
{
    Console.Write("Ar-tic mean of a row, or of a column? ");
    string rowOrCol = Console.ReadLine()!;
    if (rowOrCol == "row")
    {
        Console.Write("Enter number of row ");
        int r = int.Parse(Console.ReadLine()!);
        if (r < 0 | r > array.GetLength(0)) Console.WriteLine("Maybe you made a mistake in your request ;(");
        else
        {
            int sum = 0;
            for (int c = 0; c < array.GetLength(1); c++)
            {
                sum += array[r, c];
            }
            int result = sum / array.GetLength(0);
            Console.WriteLine($"Arithmetic mean of the row is {result}");
        }
    }
    else if (rowOrCol == "column")
    {
        Console.Write("Enter number of column ");
        int c = int.Parse(Console.ReadLine()!);
        if (c < 0 | c > array.GetLength(1)) Console.WriteLine("Maybe you made a mistake in your request ;(");
        else
        {
            int sum = 0;
            for (int r = 0; r < array.GetLength(0); r++)
            {
                sum += array[r, c];
            }
            int result = sum / array.GetLength(1);
            Console.WriteLine($"Arithmetic mean of the column is {result}");
        }
    }
    else Console.WriteLine("Maybe you made a mistake in your request ;(");
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

ArithmeticMean(array);

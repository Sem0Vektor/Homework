/*

Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

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
            Console.Write($"{array[r, c],7}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] resulting = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    int temp = 0;
    for (int r = 0; r < matrix1.GetLength(0); r++)
    {
        for (int c = 0; c < matrix2.GetLength(1); c++)
        {
            temp = 0;
            for (int c2 = 0; c2 < matrix1.GetLength(1); c2++)
            {
                temp += matrix1[r, c2] * matrix2[c2, c];
            }
            resulting[r, c] = temp;
        }
    }
    return resulting;
}

Console.Write("Enter rows of matrix ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Enter columns of matrix ");
int columns = int.Parse(Console.ReadLine()!);

Console.Write("Enter minimum value of elements ");
int minValue = int.Parse(Console.ReadLine()!);
Console.Write("Enter maximum value of elements ");
int maxValue = int.Parse(Console.ReadLine()!);

int[,] matrix1 = CreateNFillArrayV3(rows, columns, minValue, maxValue);
PrintArrayV3(matrix1);

int[,] matrix2 = CreateNFillArrayV3(columns, rows, minValue, maxValue);
PrintArrayV3(matrix2);
Console.WriteLine("Resulting matrix: ");
PrintArrayV3(MatrixMultiplication(matrix1, matrix2));

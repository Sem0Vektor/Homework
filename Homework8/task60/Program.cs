/*

Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)


*/

int[,,] CreateNFillArrayV3(int x, int y, int z)
{
    int[,,] array = new int[x, y, z];
    if (x * y * x > 199) Console.WriteLine("These options are not suitable for this programm ;(");
    else
    {
        int n = -99;
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                for (int k = 0; k < z; k++)
                {
                    array[i, j, k] = n++;
                }
            }
        }

    }
    return array;
}


void PrintArrayV3(int[,,] array)
{
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                Console.Write($"{array[x, y, z],7}({x}, {y}, {z})");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Enter 1st D ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Enter 2nd D ");
int y = int.Parse(Console.ReadLine()!);
Console.Write("Enter 3rd D ");
int z = int.Parse(Console.ReadLine()!);

int[,,] array = CreateNFillArrayV3(x, y, z);
PrintArrayV3(array);

//По сути, числа не повторяются, и они двухзначные. В задаче не сказано чтобы они были при этом случайные.
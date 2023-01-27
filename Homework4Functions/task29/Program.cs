/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

int[] CreateAndFillArray()
{   
    int[] array = new int[8];
    for(int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(1, 9);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < 8; i++)
    {   
        if(i == 7)
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

PrintArray(CreateAndFillArray());

/*

Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3

*/
int[] CreateArrayV3(int length)
{
    int[] array = new int[length];
    Console.WriteLine("Enter numbers ");
    for (int i = 0; i < length; i++)
    {
        Console.Write($"number {i + 1} = ");
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}

void PrintArrayV2(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) Console.WriteLine($"{array[i]} ");
        else Console.Write($"{array[i]}, ");
    }
}

void AmountOfNumbersAfterNull(int [] array)
{
    int amount = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) amount++;
    }
    Console.Write($"Amount of numbers after null is {amount}");
}

Console.Write("Enter number of numbers ");
int length = int.Parse(Console.ReadLine()!);

int[] array = new int[length];
array = CreateArrayV3(length);

PrintArrayV2(array);

AmountOfNumbersAfterNull(array);

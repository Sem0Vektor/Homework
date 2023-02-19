/*

Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

*/

void ShowNumberFromMtoN(int m, int n, int sum = 0)
{
    if (m > n)
    {
        Console.WriteLine(sum);
        return;
    }
    else
    {
        sum = sum + m;
        ShowNumberFromMtoN(m + 1, n, sum);
    }
}

Console.Write("Enter M ");
int m = int.Parse(Console.ReadLine()!);
if (m < 0)
{
    Console.WriteLine("This option is not suitable for this programm ;( ");
}
else
{
    Console.Write("Enter N ");
    int n = int.Parse(Console.ReadLine()!);
    if (n < 0 | n < m)
    {
        Console.WriteLine("This option is not suitable for this programm ;( ");
    }
    else
    {
        Console.Write("Sum of natural elements between M and N equels ");
        ShowNumberFromMtoN(m, n);
    }
}


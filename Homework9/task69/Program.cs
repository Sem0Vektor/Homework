/*

Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29

*/

int AkkermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m != 0) && (n == 0))
    {
        return AkkermanFunction(m - 1, 1);
    }
    else
    {
        return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    }
}

Console.WriteLine("This programm only works with natural numbers of very small value!");
Console.Write("Enter M ");
int m = int.Parse(Console.ReadLine()!);
if (m > 3 | m < 0)
{
    Console.WriteLine("This option is not suitable for this programm ;(");
}
else
{
    Console.Write("Enter N ");
    int n = int.Parse(Console.ReadLine()!);
    if(n > 3 | n < 0)
    {
        Console.WriteLine("This option is not suitable for this programm ;(");
    }
    else
    {
        Console.Write("The result of this Akkerman Function is ");
        Console.Write(AkkermanFunction(m, n));
    }
}

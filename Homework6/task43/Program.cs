/*

Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

*/

void FindIntersectionPoint(double k1, double b1, double k2, double b2)
{
    if (k1 == k2)
    {
        if (b1 == b2) Console.Write("These lines located at same coordinates");
        else Console.Write("These lines are parallel");
    }
    else
    {
        double k = (k1 - k2) * (-1);
        double b = (b1 - b2);
        double x = b / k;
        double y = (k1 * x + b1);
        Console.Write($"Intersection point located at coordinates ({x};{y})");
    }
}

Console.Write("Enter k1 ");
double k1 = double.Parse(Console.ReadLine()!);

Console.Write("Enter b1 ");
double b1 = double.Parse(Console.ReadLine()!);

Console.Write("Enter k2 ");
double k2 = double.Parse(Console.ReadLine()!);

Console.Write("Enter b2 ");
double b2 = double.Parse(Console.ReadLine()!);

FindIntersectionPoint(k1, b1, k2, b2);

int SumOfDigits(int number)
{   
    int sum = 0;
    if (number > 0)
    {
        while(number > 0)
        {
            sum = sum + number % 10;
            number = number / 10;
        }
        return sum;
    }
    else
    {
        number = number*(-1);
        while(number > 0)
        {
            sum = sum + number % 10;
            number = number / 10;
        }
        return sum;
    }
}

Console.Write("Enter number ");
int n = int.Parse(Console.ReadLine()!);

    Console.WriteLine();

Console.Write($"Sum of digits is {SumOfDigits(n)}");



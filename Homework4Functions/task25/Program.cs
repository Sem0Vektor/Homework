int PowerOneNumberWithAnother(int numberToPower, int numberThatPowers)
{
    int result = numberToPower;
    for(int i = 1; i < numberThatPowers; i++ )
    {
        result = result * numberToPower;
    }
    return result;
}

Console.Write("Enter number to power ");
int firstNumber = int.Parse(Console.ReadLine()!);

Console.WriteLine();

Console.Write("Enter power number ");
int secondNumber = int.Parse(Console.ReadLine()!);

Console.WriteLine();

Console.Write($"The result is {PowerOneNumberWithAnother(firstNumber, secondNumber)}");

int PowerOneNumberWithAnother(int numberToPower, int numberThatPowers)
{
    return Convert.ToInt32(Math.Pow(numberToPower, numberThatPowers));
}

Console.Write("Enter number to power ");
int firstNumber = int.Parse(Console.ReadLine()!);

    Console.WriteLine();

Console.Write("Enter power number ");
int secondNumber = int.Parse(Console.ReadLine()!);

    Console.WriteLine();

Console.Write($"The result is {PowerOneNumberWithAnother(firstNumber, secondNumber)}");

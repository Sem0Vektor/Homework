int SumOfDigits(int number)
{   
    if(number < 0)
    {   
        number = number*(-1);
        string str;
        str = number.ToString();
        return str.Length;
    }
    else
    {
        string str;
        str = number.ToString();
        return str.Length;
    }
}

Console.Write("Enter number ");
int n = int.Parse(Console.ReadLine()!);

    Console.WriteLine();

Console.Write($"Sum of digits is {SumOfDigits(n)}");

//string s; 
//int n = 432;
//s = n.ToString();
//Console.WriteLine(s.Length);
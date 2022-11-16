// See https://aka.ms/new-console-template for more information


class Calculator
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter number");
        string number1str = Console.ReadLine();
        Console.WriteLine("Enter the second number");
        string number2str = Console.ReadLine();
        int number1 = Int32.Parse(number1str);
        int number2 = Int32.Parse(number2str);
        int sumresult = number1 + number2;
        Console.WriteLine(number1 + "+" + number2 + "=" + sumresult);
        int difresult = number1 - number2;
        Console.WriteLine(number1 + "-" + number2 + "=" + difresult);
        int multresult = number1 * number2;
        Console.WriteLine(number1 + "*" + number2 + "=" + multresult);
        double divresult = ((double)number1 / number2);
        Console.WriteLine(number1 + "/" + number2 + "=" + divresult);
    }

}



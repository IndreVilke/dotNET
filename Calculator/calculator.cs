
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
        Console.WriteLine(number1 + "+" + number2 + "=" + result);
        int difresult = number1 - number2;
        Console.WriteLine(number1 + "-" + number2 + "=" + difresult);
        int multresult = number1 * number2;
        Console.WriteLine(number1 + "*" + number2 + "=" + multresult);
        if number2 != 0:
            int divresult = number1 / number2;
            Console.WriteLine(number1 + "%" + number2 + "=" + divresult);
        else:
                skip;


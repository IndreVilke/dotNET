using System.Text.RegularExpressions;

class PhoneNumber
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Enter phone number:");
        string number = Console.ReadLine();
        bool match = Regex.Match(number, @"^(\+370|\+371|8) ( ){0,1}[0-9]{3}( ){0,1}[0-9]{5}$").Success;
        if (match)
        {
            Console.WriteLine("You provided a correct number");
        }
        else
        {
            Console.WriteLine("Phone number is not correct");
        }
    }
}
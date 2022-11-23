using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            string number1str = Console.ReadLine();
            Console.WriteLine("Enter the second number");
            string number2str = Console.ReadLine();
            int number1 = Int32.Parse(number1str);
            int number2 = Int32.Parse(number2str);

            Console.WriteLine("Enter the Math operation (* / % + -) you would like to perform");
            string MathOperator = Console.ReadLine();
            
            
            if (MathOperator == "+")
            {
                int sumresult = number1 + number2;
                Console.WriteLine(number1 + "+" + number2 + "=" + sumresult);
            }

            if (MathOperator == "-")
            {
                int difresult = number1 - number2;
                Console.WriteLine(number1 + "-" + number2 + "=" + difresult);
            }

            if (MathOperator == "*")
            {
                int multresult = number1 * number2;
                Console.WriteLine(number1 + "*" + number2 + "=" + multresult);
            }

            if (MathOperator == "/")
                if (number2 == 0)
                    Console.WriteLine("Devision from zero is invalid");
                else
                {
                    int divresult = number1 / number2;
                    Console.WriteLine(number1 + "/" + number2 + "=" + divresult);
                }

            if (MathOperator == "%")
                if (number2 == 0)
                    Console.WriteLine("Devision from zero is invalid");
                else
                {
                    int divresult = number1 % number2;
                    Console.WriteLine(number1 + "%" + number2 + "=" + divresult);
                }





        }
    }
}



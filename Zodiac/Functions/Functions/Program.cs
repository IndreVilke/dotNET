using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string numberStr;
            double number;

            do
            {
                Console.WriteLine("enter the number");
                numberStr = Console.ReadLine();
            }

            while (!double.TryParse(numberStr, out number));

            Console.WriteLine(Factorial(number));
        }

        public static double Factorial(double n) 
        {
            if (n == 1)
                return 1;
            else
                return n * Program.Factorial(n - 1);
        
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numberStr;
            double number;

            Console.WriteLine('How long the array should be?');
            int size = Program.Get_Int()
            Console.WriteLine("Please enter" + size + "numbers");
            
            for (int i = 0; i < size; i++)

            {
                array[i]=Program.Get_Int()
                
            }

            Console.WriteLine(array);

            public static int Get_Int()
            {
                string numb = Console.ReadLine();
                if (int.TryParse(numb, out number))
                    return number;
                
                else
                    Console.WriteLine("Please enter integer");

            }
            

        }
    }
}

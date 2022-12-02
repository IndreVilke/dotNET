using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How long the array should be?");
            int size = UserInput.Get_Int();
            int[] array = new int[size];
            Console.WriteLine("Please enter" + size + "numbers");

            for (int i = 0; i < size; i++)

            {
                array[i] = UserInput.Get_Int();

            }

            Console.WriteLine(array);
        }
    }
}
    //class Input
    //{ 
      //      public static int Get_Int()
        //    {
          //    int number = 0;
                string numb = Console.ReadLine();
                if (int.TryParse(numb, out number))
                       return number;
                
              //  else
              //      Console.WriteLine("Please enter integer");

           // }
            

       // }

class UserInput
{
    public static int Get_Int()
    {
        int input = 0;
        while (true)
        {
            try
            {
                input = Int32.Parse(Console.ReadLine());
                break;
            }

            catch
            {
                Console.WriteLine("The provided input is not valid. Try again.");
            }
        }
        return input;
    }
}
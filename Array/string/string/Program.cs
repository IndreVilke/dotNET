
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class String
    {
        static void Main()
        {
            Console.WriteLine("Enter 5 integers in a line?");
            string [] array = new string [5];
            array = Console.ReadLine().Split(" ");

            int[] arr = new int[5];
            for (int i=0; i<5; i++)
                {
                try
                {
                    arr[i] = int.Parse(array[i]);
                    Console.Write(array[i]);
                }
                catch
                {
                    Console.WriteLine(" You provided not integer");
                    return;
                }
                }
        }
    }
}


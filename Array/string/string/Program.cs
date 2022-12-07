
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Array
{
    class String
    {
        static void Main()
        {
            Console.WriteLine("Enter  any number of integers in a line");
            string [] array = Console.ReadLine().Split(" ");
            
            int asize = array.Length;
            
            int[] arr = new int[asize];
            for (int i=0; i<asize; i++)
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


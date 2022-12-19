using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person myObj = new Person();

            Stud myUni = new Stud();

            Console.WriteLine("What is your name?");
            myObj.Name = Console.ReadLine();
            Console.WriteLine("What is your Surname?");
            myObj.Lastname = Console.ReadLine();

            
            Console.WriteLine(myObj.Name + ", where did you studied?");
            myUni.uni = Console.ReadLine();
            Console.WriteLine(myObj.Name + " " + myObj.Lastname + " studied in " + myUni.uni);
        }
    }
}

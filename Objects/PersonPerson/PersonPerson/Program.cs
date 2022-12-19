using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace PersonPerson 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person myObj = new Person();

            Console.WriteLine("What is your name?");
            myObj.Name = Console.ReadLine();
            Console.WriteLine("What is your Surname?");
            myObj.Lastname = Console.ReadLine();
            Console.WriteLine(myObj.Name + ", what is your birthday? Please use the format dd/mm/yyyy");
            myObj.BirthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(myObj.Name + myObj.Lastname + " has a birthday on " + my.Obj.BirthDate);
            System.DateTime _Now = DateTime.Now;
            Console.WriteLine("Today is " + _Now.Date);
        }
    }
}
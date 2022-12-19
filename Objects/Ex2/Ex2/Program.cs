using System;

namespace MyApplication
{
    class Car
    {
        string color = "red";

        static void Main(string[] args)
        {
            Car myObj1 = new Car();
            Car myObj2 = new Car();
            Console.WriteLine("What is the color of your car?");
            myObj1.color = Console.ReadLine();
            
            Console.WriteLine("What is the color of your father's car?");
            myObj2.color = Console.ReadLine();
            Console.WriteLine("The color of my car is " + myObj1.color);
            Console.WriteLine("The color of my father's car is " + myObj2.color);
        }
    }
}
using System;
using System.Collections.Generic;

namespace OfficerT
    {
       

        class Program
        {
            public static void Main(string[] args)
            {
                List<Officer> district99 = new List<Officer>();
                district99.Add(new Officer("Peters", "Ulmanis", 7068, "99", 7));
                district99.Add(new Officer("John", "Turmanis", 7069, "99", 22));
                district99.Add(new Officer("Algirdas", "Simonis", 7098, "99", 13));
                district99.Add(new Officer("Peters", "Varmanis", 7088, "99", 15));

                foreach (var officer in district99)
                    Console.WriteLine(officer);

                int k = Officer.Level1Count(district99);
                Console.WriteLine("There is " + k + " Level 1 Officers");
                k = Officer.Level23Count(district99);
                Console.WriteLine("There is " + k + " higher then Level 1 Officers");

                bool x = Officer.ExistName(district99, "John");
                if (x == true)
                    Console.WriteLine("There is Officer called John");
                else
                    Console.WriteLine("There is no Officer called John");

            }
        }
    }

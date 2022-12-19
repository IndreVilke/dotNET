using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficerOfficer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Officer[] district99 = new Officer[5];
            int i = 0;
            while (true)

            {
                Console.WriteLine("Enter officer's details");
                Console.WriteLine("Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Surname:");
                string surname = Console.ReadLine();
                Console.WriteLine("OfficerID:");
                string officerID = Console.ReadLine();
                Console.WriteLine("Working district:");
                string wDistrict = Console.ReadLine();
                Console.WriteLine("Number of crimes solved:");
                int crimesSolved = Int32.Parse(Console.ReadLine());
                Officer district99[i] = new Officer(name, surname, officerID, wDistrict, crimesSolved);
                Console.WriteLine("Would you like to enter another officer? y/n");

                if ("n" == Console.ReadLine())
                {
                    int n = i;
                    Console.WriteLine("You have entered" + n + "Officers");
                    for (int j = 0; j < n;)
                        Console.WriteLine(district99[j].Name + district99[j].Surname);
                    break;

                }

                else
                {
                    i = i + 1;
                    Console.WriteLine();
                }

                Console.WriteLine(district99[0].Name);
                Console.WriteLine(district99[1].Name);
                Console.WriteLine(district99.Length);
            }

        }
        
    }
}


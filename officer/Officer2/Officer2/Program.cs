using Officer2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Officer2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Officer[] district99 = new Officer[5];
            int i = 0;
            while (i < 10)

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
                Officer officer = new Officer(name, surname, officerID, wDistrict, crimesSolved);
                district99[i] = officer;

                Console.WriteLine("Would you like to enter another officer? y/n");
                string answer = Console.ReadLine();
                if (answer == "n")
                {
                    int number = i + 1;
                    Console.WriteLine("You have entered " + number + " Officers");
                    break;

                }

                else
                {
                    i++;
                    Console.WriteLine(i);
                    Console.WriteLine();
                }


            }


            Console.WriteLine("Officer(s) details");
            for (int k = 0; k < district99.Length; k++)
            {
                Console.WriteLine("Officer " + (k + 1) + ": " + district99[k].ToString());
            }
            Console.WriteLine("Number of level 1 officers: " + Officer.Level1(district99));
            Console.WriteLine("Number of officers with higher level: " + Officer.Levelhigher(district99));

           // if (Officer.IsJohn(district99))
           // {
           //     Console.WriteLine("There is officer called John");
           // }
           // else
           // {
           //     Console.WriteLine("There is NO John");
           // }

        }
    }
}

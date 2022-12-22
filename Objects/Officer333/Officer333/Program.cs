using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Officer333
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                Console.WriteLine("Enter the total number of officers:");
                int arrSize = Int32.Parse(Console.ReadLine());
                Officer[] distric99 = new Officer[arrSize];
                int numberOFofficers = 0;
                for (int i = 0; i < arrSize; i++)
                {
                    Console.WriteLine("Enter officer's details:");
                    Console.WriteLine("Name: ");
                    string name = Console.ReadLine();

                    Console.WriteLine("Surname:");
                    string surname = Console.ReadLine();

                    Console.WriteLine("OfficerID:");
                    int officerID = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Working district:");
                    string workingDistrict = Console.ReadLine();

                    Console.WriteLine("Number of crimes solved:");
                    int crimesSolved = Int32.Parse(Console.ReadLine());
                    numberOFofficers++;
                    Console.WriteLine(); 
                    
                    Officer officer = new Officer(name, surname, officerID, workingDistrict, crimesSolved);
                    distric99[i] = officer;
                    
                    Console.WriteLine("Would you like to enter th details of another officer? y/n");
                    string answer = Console.ReadLine(); 
                    if (answer == "n")
                        { break; }
                    
    
                }
                Console.WriteLine("Submitted officer(s) details");
                Console.WriteLine(distric99.Length + "  " + numberOFofficers);
                for (int i = 0; i < (numberOFofficers); i++)
                {
                    Console.WriteLine("Officer " + (i + 1) + ": ");
                    Console.WriteLine((distric99[i].Name) + (distric99[i].Surname) + "VardasirPavarde");
                }
                Console.WriteLine("Number of level 1 officers: " + Officer.Lvl1Number(distric99));

                
                Console.WriteLine("Number of officers with higher level: " + Officer.Lvl23Number(distric99));

                
                Console.WriteLine(Officer.IsJohn(distric99));
                

            }
        }



    }
}
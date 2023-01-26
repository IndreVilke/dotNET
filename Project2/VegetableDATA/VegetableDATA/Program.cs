using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableDATA
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string line;
            

            List <Vegies> listOfVegetables = new List <Vegies> ();

                        // Read the file and display it line by line.
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"c:\Indre_test\Project2\VegetableDATA\Vegetables.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split(';');
                listOfVegetables.Add(new Vegies(words[0], words[1], words[2]));
                                
            }

            file.Close();


            foreach (var vegies in listOfVegetables)
                Console.WriteLine(vegies);

            Console.WriteLine(listOfVegetables[0].name + " originates " + listOfVegetables[0].habitat);
            Console.WriteLine(listOfVegetables[1].name + " originates " + listOfVegetables[1].habitat);

        }
    }
}

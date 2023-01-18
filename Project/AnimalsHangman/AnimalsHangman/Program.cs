using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsHangman
{
    internal class Program
    {
        static void Main(string[] args)

        {
            List<Animals> animallist = new List<Animals>();
            animallist.Add(new Animals("Elephant", "Africa", "big ears"));
            animallist.Add(new Animals("Cow", "home", "it has horns and hooven"));
            animallist.Add(new Animals("Wolf", "forest", "it eats redhood"));
            animallist.Add(new Animals("Tiger", "Asia", "it is very big and dangerous cat"));
            animallist.Add(new Animals("Monkey", "Africa", "climbs in trees"));
            animallist.Add(new Animals("Fish", "Ocean", "it has flosses"));
            animallist.Add(new Animals("Rat", "fields", "eats grain"));
            animallist.Add(new Animals("Hen", "home", "lays eggs"));
            animallist.Add(new Animals("Dog", "home", "it barks"));
            animallist.Add(new Animals("Hamster", "home", "has huge cheeks"));


            foreach (var animals in animallist)
                Console.WriteLine(animals);

            int rnd= new Random().Next(0, 9);
            Console.WriteLine(rnd);
            Console.WriteLine(animallist[rnd]);
            Console.WriteLine(animallist[rnd].name);
            string animalN = animallist[rnd].name;
            int letters = animalN.Length;
            Console.WriteLine(letters);
            for (int i = 0; i < letters; i++)
                Console.Write("_ ");
            Console.WriteLine();
            List<char> letter = new List<char>();
            Console.WriteLine("Guess the letter:");
            char lette = Console.ReadLine()[0];
            letter.Add(lette);


            Console.WriteLine(animalN[0]);
            Console.WriteLine(animalN[1]);
            Console.WriteLine(animalN[2]);
            int mistk = 0;
            int letterf = 0;
            for (int i = 0; i < letters; i++)
                if (letter[0] == animalN[i])
                {
                    Console.Write(letter[0]);
                    letterf = letterf++;
                }
                else
                    Console.Write("_ ");
            Console.WriteLine();
            if (letterf == 0)
                mistk = mistk + 1;
            Console.WriteLine("You made " + mistk + " mistakes");
            Console.WriteLine("Have another guess");

        }
    }
}

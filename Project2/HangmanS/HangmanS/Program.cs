using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanS
{
    internal class Program
    {
        static void Main(string[] args)

        {
            List<AnimalS> animallist = new List<AnimalS>();
            animallist.Add(new AnimalS("Elephant", "Africa", "big ears"));
            animallist.Add(new AnimalS("Cow", "home", "it has horns and hooven"));
            animallist.Add(new AnimalS("Wolf", "forest", "it eats redhood"));
            animallist.Add(new AnimalS("Tiger", "Asia", "it is very big and dangerous cat"));
            animallist.Add(new AnimalS("Monkey", "Africa", "climbs in trees"));
            animallist.Add(new AnimalS("Fish", "Ocean", "it has flosses"));
            animallist.Add(new AnimalS("Rat", "fields", "eats grain"));
            animallist.Add(new AnimalS("Hen", "home", "lays eggs"));
            animallist.Add(new AnimalS("Dog", "home", "it barks"));
            animallist.Add(new AnimalS("Hamster", "home", "has huge cheeks"));


            foreach (var animals in animallist)
                Console.WriteLine(animals);

            int rnd = new Random().Next(0, 9);
            Console.WriteLine(rnd);
            Console.WriteLine(animallist[rnd]);
            Console.WriteLine(animallist[rnd].name);
            string animalN = animallist[rnd].name;
            int letters = animalN.Length;

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" +
                      "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n" +
                      "\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine("Word contains " + letters + " " + " letters");

            for (int i = 0; i < letters; i++)
                Console.Write("_ ");

            Console.WriteLine();
            List<char> letter = new List<char>();
            Console.WriteLine("Guess the letter:");
            char lette = Console.ReadLine()[0];
            letter.Add(lette);


            //Console.WriteLine(animalN[0]);
            //Console.WriteLine(animalN[1]);
            //Console.WriteLine(animalN[2]);


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

            mistk = mistk + 1;
            Console.WriteLine("You made " + mistk + " mistakes");
            Console.WriteLine("Have another guess");





            char lette1 = Console.ReadLine()[0];
            letter.Add(lette1);

            for (int i = 0; i < letters; i++)


                if (letter[0] == animalN[i])
                {
                    Console.Write(letter[0]);
                    letterf = letterf++;
                }
                else
                    Console.Write("_ ");
            Console.WriteLine();

            mistk = mistk + 1;
            Console.WriteLine("You made " + mistk + " mistakes");
            Console.WriteLine("Have another guess");






            char lette2 = Console.ReadLine()[0];
            letter.Add(lette2);

            for (int i = 0; i < letters; i++)


                if (letter[0] == animalN[i])
                {
                    Console.Write(letter[0]);
                    letterf = letterf++;
                }
                else
                    Console.Write("_ ");
            Console.WriteLine();

            mistk = mistk + 1;
            Console.WriteLine("You made " + mistk + " mistakes");
            Console.WriteLine("Have another guess");

        }

    }
}


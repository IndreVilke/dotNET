﻿using System;
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
            int lettersNmb = animalN.Length;
            Console.WriteLine(letters);
                        
            char[] guessarray = new char[lettersNmb];
            Console.Write("Please enter your guess: ");

            for (int p = 0; p < lettersNmb; p++)
                guessarray[p] = '-';
            int mistakes = 0;
            while (mistakes < 6)
            {
                string playerGuessStr = Console.ReadLine();
                string playerGuessStrL = playerGuessStr.ToLower();
                Console.WriteLine("To Lower: " + playerGuessStrL);

                char playerGuess = char.Parse(playerGuessStrL);
                int positv = 0;
                for (int j = 0; j < lettersNmb; j++)
                {
                    if (playerGuess == animalN[j])
                    {
                        guessarray[j] = playerGuess;
                        positv = positv + 1;

                    }
                }
                if (positv == 0)
                {
                    Console.WriteLine(positv);
                    mistakes = mistakes + 1;
                    Console.WriteLine(" Your made " + mistakes + " mistakes");
                }

                string strguess = string.Concat(guessarray);
                Console.WriteLine("as a string" + strguess);
                if (strguess.Contains("-"))
                {
                    Console.WriteLine("There is still missing letters");
                }
                else
                {
                    Console.WriteLine("Congratulations, you won");
                    break;
                }


            }
            if (mistakes == 6)
            {
                Console.WriteLine("YOU LOST");
                Console.WriteLine("The mystery word was: " + mysteryWord);
            }




        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman3
{
    internal class Program
    {

        static void Main(string[] args)

        {
            List<Animals3> animallist = new List<Animals3>();
            animallist.Add(new Animals3("elephant", "Africa", "big ears"));
            animallist.Add(new Animals3("cow", "home", "has horns and hooven"));
            animallist.Add(new Animals3("wolf", "forest", "eats redhood"));
            animallist.Add(new Animals3("tiger", "Asia", "is very big and dangerous cat"));
            animallist.Add(new Animals3("monkey", "Africa", "climbs in trees"));
            animallist.Add(new Animals3("fish", "Ocean", "has flosses"));
            animallist.Add(new Animals3("rat", "fields", "eats grain"));
            animallist.Add(new Animals3("hen", "home", "lays eggs"));
            animallist.Add(new Animals3("dog", "home", "barks"));
            animallist.Add(new Animals3("hamster", "home", "has huge cheeks"));


            foreach (var animals in animallist)
                Console.WriteLine(animals);

            int rnd = new Random().Next(0, 9);
            
            string animalN = animallist[rnd].name;
            int lettersNmb = animalN.Length;
            

            char[] guessarray = new char[lettersNmb];
            Console.WriteLine("Please guess an animal that lives in: " + animallist[rnd].habitat);
            Console.WriteLine("Please enter your guess: ");

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
                Console.WriteLine(strguess);
                if (strguess.Contains("-"))
                {
                    Console.WriteLine("There is still missing letters");
                    if (mistakes == 3)
                    {
                        Console.WriteLine("The animal " + animallist[rnd].hint);
                    }
                }
                else
                {
                    Console.WriteLine("CONGRATULATIONS, YOU WON");
                    break;
                }


            }
            if (mistakes == 6)
            {
                Console.WriteLine("YOU LOST");
                Console.WriteLine("The secret word was: " + animalN);
            }




        }
    }
}
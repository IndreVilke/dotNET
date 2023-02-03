using Hangman4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_I
{
    internal class Guessing
    {
        public static void WordGuess(string[] args)

        {

            string mysteryName;
            string mysteryHabit;
            string mysteryHint;

            Item Mystery = GetItem.GetOneItem();
            mysteryName = Mystery.name;
            mysteryHabit = Mystery.habitat;
            mysteryHint = Mystery.hint;

            int lettersNmb = mysteryName.Length;


            char[] guessarray = new char[lettersNmb];

            Console.WriteLine("Mystery word origins or habitat:  " + mysteryHabit);
            Console.WriteLine("Please enter your guess: ");

            for (int p = 0; p < lettersNmb; p++)
                guessarray[p] = '-';
            int mistakes = 0;
            while (mistakes < 10)                          //The player can make only 6 mistakes
            {
                string playerGuessStr = Console.ReadLine();
                string playerGuessStrL = playerGuessStr.ToLower(); //the players guess I force to lower case, because
                                                                   //all the checking is being done in only for lower letters

                char playerGuess = char.Parse(playerGuessStrL);    // I convert string to char, because I want to have the array of chars
                int positv = 0;
                for (int j = 0; j < lettersNmb; j++)
                {
                    if (playerGuess == mysteryName[j])
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
                    Drawing.Gallows(mistakes);


                }

                string strguess = string.Concat(guessarray);
                Console.WriteLine(strguess);
                if (strguess.Contains("-"))
                {
                    Console.WriteLine("There is still missing letters");
                    if (mistakes == 3)
                    {
                        Console.WriteLine("Hint for mystery word: " + mysteryHint);
                    }
                }
                else
                {
                    Console.WriteLine("CONGRATULATIONS, YOU WON");
                    break;
                }



                if (mistakes == 10)
                {
                    Console.WriteLine("YOU LOST");
                    Console.WriteLine("The secret word was: " + mysteryName);
                }




            }
        }
    }
}
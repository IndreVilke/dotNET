using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.AccessControl;

namespace Hangman3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Hangman!!!!!!!!!!");
            string[] listwords = new string[10];
            listwords[0] = "sheep";
            listwords[1] = "goat";
            listwords[2] = "computer";
            listwords[3] = "america";
            listwords[4] = "watermelon";
            listwords[5] = "icecream";
            listwords[6] = "jasmine";
            listwords[7] = "pineapple";
            listwords[8] = "orange";
            listwords[9] = "mango";
            Random randGen = new Random();
            var idx = randGen.Next(0, 9);
            string mysteryWord = listwords[idx];
            char[] guessarray = new char[mysteryWord.Length];
            Console.Write("Please enter your guess: ");

            for (int p = 0; p < mysteryWord.Length; p++)
                guessarray[p] = '-';
            int mistakes = 0;
            while (mistakes < 6)
            {
                string playerGuessStr = Console.ReadLine();
                string playerGuessStrL = playerGuessStr.ToLower(); 
                Console.WriteLine("To Lower: " + playerGuessStrL);

                char playerGuess = char.Parse(playerGuessStrL);
                int positv = 0;
                for (int j = 0; j < mysteryWord.Length; j++)
                {
                    if (playerGuess == mysteryWord[j])
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
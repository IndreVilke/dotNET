using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        { 

	        Random random = new Random();

            int winNum = random.Next(1, 20);
            int guess = 0;
            int numGuesses = 0;

            Console.WriteLine("I am thinking of a number between 1-20.  Can you guess what it is?");

            while (guess != winNum)
            {
                guess = Convert.ToInt32(Console.ReadLine());
                

                
                numGuesses++;
                    if (guess < winNum)
                    {
                        Console.WriteLine("No, the number I am thinking of is higher than " + guess + " .  Can you guess what it is?");
                    }
                    if (guess > winNum)
                    {
                        Console.WriteLine("No, the number I am thinking of is lower than " + guess + " .  Can you guess what it is");
                    }
             
            }
            Console.WriteLine("Well done! The answer was " + winNum + ".\nYou took " + numGuesses + " guesses.");
        }


    }
}

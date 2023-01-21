using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsHangman
{
    internal class GuessLetters
    {
        public GLetters()
            {
            List<char> letter = new List<char>();

            Console.WriteLine("Guess the letter:");
            char lette = Console.ReadLine()[0];
            letter.Add(lette);
            Console.WriteLine("You already had" + letter.Count + "guesses.");
            Console.WriteLine("You guessed letters" + letter);
            }
    }
}

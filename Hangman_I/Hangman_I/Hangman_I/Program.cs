using Hangman_I;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("START. Guess a word. Do you want to guess an ANIMAL(A), FRUIT(F) or VEGETABLE(V) ?");

            Guessing.WordGuess(args);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_I
{
     class Drawing
    {
        public static void Gallows(int mist) //if the guessed letter is not in the word one draws gallows according to
                                             //number of mistakes
        {
            if (mist == 1)
            {
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
            }

            if (mist == 2)
            {
                Console.WriteLine("|             |");
                Console.WriteLine("|             |");
                Console.WriteLine("|             |");
                Console.WriteLine("|             |");
                Console.WriteLine("|             |");
                Console.WriteLine("|             |");
            }
            if (mist == 3)
            {
                Console.WriteLine("|-------------|");
                Console.WriteLine("|             |");
                Console.WriteLine("|             |");
                Console.WriteLine("|             |");
                Console.WriteLine("|             |");
                Console.WriteLine("|             |");
            }

            if (mist == 4)
            {
                Console.WriteLine("|------|-------|");
                Console.WriteLine("|      |       |");
                Console.WriteLine("|              |");
                Console.WriteLine("|              |");
                Console.WriteLine("|              |");
                Console.WriteLine("|              |");
            }
            if (mist == 5)
            {
                Console.WriteLine("|------|-------|");
                Console.WriteLine("|      |       |");
                Console.WriteLine("|      o       |");
                Console.WriteLine("|              |");
                Console.WriteLine("|              |");
                Console.WriteLine("|              |");
            }
            if (mist == 6)
            {
                Console.WriteLine("|------|-------|");
                Console.WriteLine("|      |       |");
                Console.WriteLine("|      o       |");
                Console.WriteLine("|      |       |");
                Console.WriteLine("|              |");
                Console.WriteLine("|              |");
            }   
            if (mist == 7)
            {
                Console.WriteLine("|------|-------|");
                Console.WriteLine("|      |       |");
                Console.WriteLine("|      o       |");
                Console.WriteLine("|     -|       |");
                Console.WriteLine("|              |");
                Console.WriteLine("|              |");
            }
            if (mist == 8)
            {   
                Console.WriteLine("|------|-------|");
                Console.WriteLine("|      |       |");
                Console.WriteLine("|      o       |");
                Console.WriteLine("|     -|-      |");
                Console.WriteLine("|              |");
                Console.WriteLine("|              |");
            }
            if (mist == 9)
            {
                Console.WriteLine("|------|-------|");
                Console.WriteLine("|      |       |");
                Console.WriteLine("|      o       |");
                Console.WriteLine("|     -|-      |");
                Console.WriteLine("|      L       |");
                Console.WriteLine("|              |");
            }
            if (mist == 10)
            {
                Console.WriteLine("|------|-------|");
                Console.WriteLine("|      |       |");
                Console.WriteLine("|      o       |");
                Console.WriteLine("|     -|-      |");
                Console.WriteLine("|      LL      |");
                Console.WriteLine("|              |");
            }
        }
    }
}


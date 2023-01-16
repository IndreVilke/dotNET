
using System;

namespace Drawing
{
    internal class Program
    {
        static void Main(string[] args)
        { int mistakes = 6;


            if (mistakes == 2)

                { for (int i = 0; i < 11; i++)
                    Console.WriteLine("    ||");
                Console.WriteLine("-----------------------");
                }
            if (mistakes == 3)
            {
                Console.WriteLine("    ||");
                Console.WriteLine("    ----------");
                for (int i = 0; i < 9; i++)
                    Console.WriteLine("    ||");
                Console.WriteLine("-----------------------");

            }

            if (mistakes == 4)
            {
                Console.WriteLine("    ||");
                Console.WriteLine("    ----------");
                Console.WriteLine("    ||       |");
                for (int i = 0; i < 8; i++)
                    Console.WriteLine("    ||");
                Console.WriteLine("-----------------------");

            }

            if (mistakes == 5)
            {
                Console.WriteLine("    ||");
                Console.WriteLine("    ----------");
                Console.WriteLine("    ||       |");
                Console.WriteLine("    ||       O");
                for (int i = 0; i < 7; i++)
                    Console.WriteLine("    ||");
                Console.WriteLine("-----------------------");

            }

            if (mistakes == 6)
            {
                Console.WriteLine("    ||");
                Console.WriteLine("    ----------");
                Console.WriteLine("    ||       |");
                Console.WriteLine("    ||       O");
                Console.WriteLine("    ||      /|");
                for (int i = 0; i < 6; i++)
                    Console.WriteLine("    ||");
                Console.WriteLine("-----------------------");

            }
        }
    }
}

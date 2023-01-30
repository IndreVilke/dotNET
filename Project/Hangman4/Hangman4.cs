using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman4
{
    internal class Program
    {

        static Item GetOneItem()
        {

            Console.WriteLine("Guess a word. Do you want to guess an ANIMAL(a) or FRUIT(f) or VEGETABLE(v) ?");
            string choice = Console.ReadLine();
            string fileName = "";

            int rnd = new Random().Next(0, 5);
            Console.WriteLine(rnd);

            List<Item> listOfItems = new List<Item>();
                        
            if (choice.Contains("f"))
            {
                fileName = "Fruits.txt";
            }
            else if (choice.Contains("v"))
            {
                fileName = "Vegetable.txt";
            }
            else 
                Console.WriteLine("There is not such group");



            // Read the file and display it line by line.
            System.IO.StreamReader file =
                new System.IO.StreamReader(fileName);

            string line;

            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split(';');

                listOfItems.Add(new Item(words[0], words[1], words[2]));

            }

            file.Close();

            foreach (var item in listOfItems)
                Console.WriteLine(item);

            return listOfItems[rnd];
        }

        static void Gallows(int mist)
        {
            if (mist == 1)
            {
                Console.WriteLine("|             |");
                Console.WriteLine("|             |");
                Console.WriteLine("|             |");
                Console.WriteLine("|             |");
                Console.WriteLine("|             |");
                Console.WriteLine("|             |");
            }

            if (mist == 2)
            {
                Console.WriteLine("|-------------|");
                Console.WriteLine("|             |");
                Console.WriteLine("|             |");
                Console.WriteLine("|             |");
                Console.WriteLine("|             |");
                Console.WriteLine("|             |");
            }
            if (mist == 3)
            {
                Console.WriteLine("|------|-------|");
                Console.WriteLine("|      |       |");
                Console.WriteLine("|      o       |");
                Console.WriteLine("|              |");
                Console.WriteLine("|              |");
                Console.WriteLine("|              |");
            }

            if (mist == 4)
            {
                Console.WriteLine("|------|-------|");
                Console.WriteLine("|      |       |");
                Console.WriteLine("|      o       |");
                Console.WriteLine("|      |       |");
                Console.WriteLine("|              |");
                Console.WriteLine("|              |");
            }
            if (mist == 5)
            {
                Console.WriteLine("|------|-------|");
                Console.WriteLine("|      |       |");
                Console.WriteLine("|      o       |");
                Console.WriteLine("|     -|-      |");
                Console.WriteLine("|              |");
                Console.WriteLine("|              |");
            }
            if (mist == 6)
            {
                Console.WriteLine("|------|-------|");
                Console.WriteLine("|      |       |");
                Console.WriteLine("|      o       |");
                Console.WriteLine("|     -|-      |");
                Console.WriteLine("|      ^       |");
                Console.WriteLine("|              |");
            }   
        }

static void Main(string[] args)

        {

            string mysteryName = "labas";
            string mysteryHabit = "Lietuva";
            string mysteryHint = "is beautiful";

            Item Mystery =  GetOneItem();
            mysteryName = Mystery.name;
            mysteryHabit = Mystery.habitat;
            mysteryHint = Mystery.hint;

            int lettersNmb = mysteryName.Length;


            char[] guessarray = new char[lettersNmb];
                
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
                        Gallows(mistakes);
                        

                    }

                    string strguess = string.Concat(guessarray);
                    Console.WriteLine(strguess);
                    if (strguess.Contains("-"))
                    {
                        Console.WriteLine("There is still missing letters");
                        if (mistakes == 3)
                        {
                            Console.WriteLine("The secret word " + mysteryHint);
                        }
                    }
                    else
                    {
                        Console.WriteLine("CONGRATULATIONS, YOU WON");
                        break;
                    }



                    if (mistakes == 6)
                    {
                        Console.WriteLine("YOU LOST");
                        Console.WriteLine("The secret word was: " + mysteryName);
                    }


                        

                }
            }
        }
    }

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
            Console.WriteLine("Guess a word.Do you want to guess an ANIMAL(a) or FRUIT(f) or VEGETABLE(v) ?");
            string choice = Console.ReadLine();

            int rnd = new Random().Next(0, 5);
            Console.WriteLine(rnd);
            string mysteryName = "labas";
            string mysteryHabit = "Lietuva";
            string mysteryHint = "it is beautiful";

            if (choice.Contains("a"))
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

                mysteryName = animallist[rnd].name;
                mysteryHabit = animallist[rnd].habitat;
                mysteryHint = animallist[rnd].hint;

                Console.WriteLine(mysteryName);
                Console.WriteLine(mysteryHabit);
                Console.WriteLine(mysteryHint);

                Console.WriteLine("Please guess an animal that lives in: " + mysteryHabit);
            }
            string line;

            if (choice.Contains("f"))
            {

                List<Fruits> listOfFruits = new List<Fruits>();

                // Read the file and display it line by line.
                System.IO.StreamReader file =
                    new System.IO.StreamReader(@"c:\Indre_test\Project\Hangman3\Fruit.txt");
                while ((line = file.ReadLine()) != null)
                {
                    string[] words = line.Split(';');

                    listOfFruits.Add(new Fruits(words[0], words[1], words[2]));

                }

                file.Close();

                foreach (var fruits in listOfFruits)
                    Console.WriteLine(fruits);

                mysteryName = listOfFruits[rnd].name;
                mysteryHabit = listOfFruits[rnd].habitat;
                mysteryHint = listOfFruits[rnd].hint;

                Console.WriteLine(mysteryName);
                Console.WriteLine(mysteryHabit);
                Console.WriteLine(mysteryHint);

                Console.WriteLine("Please guess a fruit that originates " + mysteryHabit);


            }





            if (choice.Contains("v"))
            {


                List<Vegies> listOfVegetables = new List<Vegies>();

                // Read the file and display it line by line.
                System.IO.StreamReader file =
                    new System.IO.StreamReader(@"c:\Indre_test\Project\Hangman3\Vegetables.txt");
                while ((line = file.ReadLine()) != null)
                {
                    string[] words = line.Split(';');
                    listOfVegetables.Add(new Vegies(words[0], words[1], words[2]));

                }

                file.Close();

                foreach (var vegies in listOfVegetables)
                    Console.WriteLine(vegies);

                mysteryName = listOfVegetables[rnd].name;
                mysteryHabit = listOfVegetables[rnd].habitat;
                mysteryHint = listOfVegetables[rnd].hint;

                Console.WriteLine(mysteryName);
                Console.WriteLine(mysteryHabit);
                Console.WriteLine(mysteryHint);

                Console.WriteLine("Please guess a vegetable that originates in: " + mysteryHabit);

            }

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
                        if (mistakes == 1)
                        {
                            Console.WriteLine("|             |");
                            Console.WriteLine("|             |");
                            Console.WriteLine("|             |");
                            Console.WriteLine("|             |");
                            Console.WriteLine("|             |");
                            Console.WriteLine("|             |");
                        }

                        if (mistakes == 2)
                        {
                            Console.WriteLine("|-------------|");
                            Console.WriteLine("|             |");
                            Console.WriteLine("|             |");
                            Console.WriteLine("|             |");
                            Console.WriteLine("|             |");
                            Console.WriteLine("|             |");
                        }
                        if (mistakes == 3)
                        {
                            Console.WriteLine("|------|-------|");
                            Console.WriteLine("|      |       |");
                            Console.WriteLine("|      o       |");
                            Console.WriteLine("|              |");
                            Console.WriteLine("|              |");
                            Console.WriteLine("|              |");
                        }

                        if (mistakes == 4)
                        {
                            Console.WriteLine("|------|-------|");
                            Console.WriteLine("|      |       |");
                            Console.WriteLine("|      o       |");
                            Console.WriteLine("|      |       |");
                            Console.WriteLine("|              |");
                            Console.WriteLine("|              |");
                        }
                        if (mistakes == 5)
                        {
                            Console.WriteLine("|------|-------|");
                            Console.WriteLine("|      |       |");
                            Console.WriteLine("|      o       |");
                            Console.WriteLine("|     -|-      |");
                            Console.WriteLine("|              |");
                            Console.WriteLine("|              |");
                        }
                        if (mistakes == 6)
                        {
                            Console.WriteLine("|------|-------|");
                            Console.WriteLine("|      |       |");
                            Console.WriteLine("|      o       |");
                            Console.WriteLine("|     -|-      |");
                            Console.WriteLine("|      ^       |");
                            Console.WriteLine("|              |");
                        }

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

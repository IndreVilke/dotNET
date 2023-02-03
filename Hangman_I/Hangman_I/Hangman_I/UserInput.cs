using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hangman_I
{
    class UserInput
    {
        public static string UserChoise()
        {
            string A = "A";
            string F = "F";
            string V = "V";
  
            string choiceInp = Console.ReadLine();
            choiceInp = choiceInp.ToUpper();
            //bool wordValidation = choiceInp.All(Char.IsLetter);
            for (; ; ) { 
            if (choiceInp == A)
            {
                return choiceInp;
            }

            if (choiceInp == F)
            {
                return choiceInp;
            }

            if (choiceInp == V)
            {
                return choiceInp;
            }
            else if ((choiceInp != A) || (choiceInp != F) || (choiceInp != V))
                {

                    Console.WriteLine("Input not valid! Please check if you entered one letter(ANIMAL(A), FRUIT(F) or VEGETABLE(V))!");

                    Console.WriteLine("Please try again:");

                    choiceInp = Console.ReadLine();
                    choiceInp = choiceInp.ToUpper();

                }
               

            }

            return choiceInp;




 

        }
    }
}


            

          
        
       
    



    


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Zodiac1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the month: ");
            string month = Console.ReadLine();
            Console.WriteLine("Enter the day");
            string daystr = Console.ReadLine();
            int day = Int32.Parse(daystr);


            //string[] month_of_year = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            //List<string> month_list = new List<string>(month_of_year);

            //if (month is not in month_list)
            //      Console.WriteLine("There is no such month in a calendar");
            //      break;

            if (day > 31)
                Console.WriteLine("There is no such day in Calender");

            if (month=="January")
                if (day > 19)
                    Console.WriteLine("This day is in Aquarius(Water Bearer)");
                else
                    Console.WriteLine("This day is in Capricornus(Goat)");

            if (month == "February")
                if (day > 18)
                    Console.WriteLine("This day is in Pisces(Fish)");
                else
                    Console.WriteLine("This day is in Aquarius(Water Bearer)");

            if (month == "March")
                if (day > 20)
                    Console.WriteLine("This day is in Aries(Ram)");
                else
                    Console.WriteLine("This day is in Pisces(Fish)");

            if (month == "April")
                if (day > 19)
                    Console.WriteLine("This day is in Taurus(Bull)");
                else
                    Console.WriteLine("This day is in Aries(Ram)");

            if (month == "May")
                if (day > 20)
                    Console.WriteLine("This day is in Gemini(Twins)");
                else
                    Console.WriteLine("This day is in Taurus(Bull)");

            if (month == "June")
                if (day > 21)
                    Console.WriteLine("This day is in Cancer(Crab)");
                else
                    Console.WriteLine("This day is in Leo(Lion)");

            if (month == "July")
                if (day > 22)
                    Console.WriteLine("This day is in Leo(Lion)");
                else
                    Console.WriteLine("This day is in Cancer(Crab)");

            if (month == "August")
                if (day > 22)
                    Console.WriteLine("This day is in Virgo(Virgin)");
                else
                    Console.WriteLine("This day is in Leo(Lion)");

            if (month == "September")
                if (day > 22)
                    Console.WriteLine("This day is in Libra(Balance)");
                else
                    Console.WriteLine("This day is in Virgo(Virgin)");


            if (month == "October")
                if (day > 23)
                        Console.WriteLine("This day is in Scorpius(Scorpion)");
                else
                    Console.WriteLine("This day is in Libra(Balance)");


            if (month == "Noverber")
                if (day > 22)
                    Console.WriteLine("This day is in Sagittarius(Archer)");
                else
                    Console.WriteLine("Scorpius(Scorpion)");

            if (month == "December")
                if (day > 22)
                    Console.WriteLine("This day is in Capricornus(Goat)");
                else
                    Console.WriteLine("This day is in Sagittarius(Archer)");

        }
    }
}

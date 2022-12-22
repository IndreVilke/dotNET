using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOfficer
{
    internal class Officer
    {

        private string name;
        private string surname;
        private string officerID;
        private string wDistrict;
        private int crimesSolved;
        public Officer(string nameOf, string surnameOf, string officerIDOf, string wDistrictOf, int crimesSolvedOf)
        {
            this.name = nameOf;
            this.surname = surnameOf;
            this.officerID = officerIDOf;
            this.wDistrict = wDistrictOf;
            this.crimesSolved = crimesSolvedOf;
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Surname
        {
            get { return this.surname; }
            set { this.surname = value; }
        }

        public string OfficerId
        {
            get { return this.officerID; }
            set { this.officerID = value; }
        }

        public string WDistrict
        {
            get { return this.wDistrict; }
            set { wDistrict = value; }
        }

        public int CrimesSolved
        {
            get { return this.crimesSolved; }
            set { this.crimesSolved = value; }
        }

        public int CalculatedLevel()
        {
            if (this.crimesSolved < 20)
            {
                return 1;
            }
            else if (this.crimesSolved > 40)
            {
                return 3;
            }
            else
            {
                return 2;
            }
        }

        public static int Level1(Officer[] district99)
        {
            int level1n = 0;
            for (int i = 0; i < district99.Length; i++)
            {
                if (district99[i].CalculatedLevel() == 1)
                {
                    level1n++;
                }
            }
            return level1n;
        }

        public static int Levelhigher(Officer[] district99)
        {
            int levelhigher = 0;
            for (int i = 0; i < district99.Length; i++)
            {
                if (district99[i].CalculatedLevel() > 1)
                {
                    levelhigher++;
                }
            }
            return levelhigher;
        }

        public static bool IsJohn(Officer[] district99)
        {
            int numb = 0;
            for (int i = 0; i < district99.Length; i++)
            {
                if (district99[i].name == "John")
                {
                    return true;

                }
                else if (numb == (district99.Length - 1))
                {
                    return false;
                }
            }


        }

    }
}

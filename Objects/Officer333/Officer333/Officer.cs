using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Officer333
{
    class Officer
    {
        private string name;
        private string surname;
        private int officerId;
        private string workingDistrict;
        private int crimesSolved;
        public Officer(string objName, string objSurname, int objOfficerId, string objWorkingDistrict, int objCrimesSolved)
        {
            this.name = objName;
            this.surname = objSurname;
            this.officerId = objOfficerId;
            this.workingDistrict = objWorkingDistrict;
            this.crimesSolved = objCrimesSolved;
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
        public int OfficerId
        {
            get { return this.officerId; }
            set { this.officerId = value; }
        }
        public string WorkingDistrict
        {
            get { return this.workingDistrict; }
            set { this.workingDistrict = value; }
        }
        public int CrimesSolved
        {
            get { return this.crimesSolved; }
            set { this.crimesSolved = value; }
        }
        public int CalculatedLevel()
        {
            Console.WriteLine("Kiek isprende bylu: " + this.Name + "   " + this.crimesSolved);
            if (this.crimesSolved < 20)
            {
                return 1;
            }
            else if (this.crimesSolved > 20 && this.crimesSolved < 40)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }
        public override string ToString()
        {
            string details = "Name: " + name + " ; " + "Surname: " + surname + " ; " + "OfficerID: " + officerId + " ; " + "Working district: " + workingDistrict + " ; " + " Crimes solved:" + crimesSolved;
            return details;
        }

        public static int Lvl1Number(Officer[] distric99)
        {
            int lvl1nm = 0;
            Console.WriteLine("Kiek pareigunu yra " + distric99.Length);
            for (int i = 0; i < distric99.Length; i++)
            {

                Console.WriteLine("Kiek issprende bylu Lvl1Number" + distric99[i].CalculatedLevel());
                if (distric99[i].CalculatedLevel() == 1)
                {
                    lvl1nm++;
                }
            }
            return lvl1nm;
        }

        public static int Lvl23Number(Officer[] distric99)
        {
            int lvl23nm = 0;
            Console.WriteLine("Kiek isprende bylu level23" + distric99.Length);
            for (int i = 0; i < distric99.Length; i++)
            {
                if (distric99[i].CalculatedLevel() > 1)
                {
                    lvl23nm++;
                }
            }
            return lvl23nm;
        }


        public static bool IsJohn(Officer[] distric99)
        {

            for (int i = 0; i < distric99.Length; i++)
            {
                if (distric99[i].name == "John")
                {
                    Console.WriteLine("There is John");
                    return true;

                }
                else if (i == (distric99.Length - 1))
                {
                    Console.WriteLine("There is no John");
                    return false;
                }
                else
                    continue;
            }



        }

    }

}

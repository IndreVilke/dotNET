using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OfficerOfficer
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

    }
}
  


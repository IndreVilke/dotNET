using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficerT
{
    internal class Officer
    {
            public string name { get; }
            public string surname { get; }
            public int officerId { get; }
            public string workingDistrict { get; }
            public int crimesSolved { get; }

            public Officer(string objName, string objSurname, int objOfficerId,
                           string objWorkingDistrict, int objCrimesSolved)
            {
                this.name = objName;
                this.surname = objSurname;
                this.officerId = objOfficerId;
                this.workingDistrict = objWorkingDistrict;
                this.crimesSolved = objCrimesSolved;
            }
            public int CalculatedLevel()
            {
                if (crimesSolved < 20)
                {
                    return 1;

                }
                else if (crimesSolved < 40)
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
                return $"Name: {name,-8} Surname: {surname,-10} OfficerID: {officerId} " +
                   $"Working district: {workingDistrict}  Crimes solved: {crimesSolved}";
            }
            public static int Level1Count(List<Officer> distr)
            {
                int count = 0;
                foreach (var officer in distr)
                    if (officer.CalculatedLevel() == 1)
                        count++;
                return count;
            }
            public static int Level23Count(List<Officer> distr)
            {
                int count = 0;
                foreach (var officer in distr)
                    if (officer.CalculatedLevel() > 1)
                        count++;
                return count;
            }
            public static bool ExistName(List<Officer> distr, string name)
            {
                foreach (var officer in distr)
                    if (officer.name == name)
                        return true;
                return false;
            }
        }



    }


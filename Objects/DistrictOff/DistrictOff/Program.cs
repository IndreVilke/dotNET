using System;
using System.Collections.Generic;

namespace DistrictOff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Officer officer1 = new Officer("John", "Jonathan", 111, 7);
            Officer officer2 = new Officer("Adam", "Adamson", 112, 20);
            Officer officer3 = new Officer("Algis", "Algaitis", 113, 90);
            Officer officer4 = new Officer("Roma", "Romaite", 114, 38);
            Officer officer5 = new Officer("Silva", "Silvaite", 115, 76);
            Officer officer6 = new Officer("Toma", "Tomaite", 116, 12);
            Officer officer7 = new Officer("Monika", "Lapaite", 117, 8);

            

            Officer[] district1a = new Officer[3];
            district1a[0] = officer1;
            district1a[1] = officer2;
            district1a[2] = officer3;

            Officer[] district2a = new Officer[4];
            district2a[0] = officer4;
            district2a[1] = officer5;
            district2a[2] = officer6;
            district2a[3] = officer7;

            District district1 = new District("District 1", "Las Vegas", 101, district1a);
            District district2 = new District("District 2", "Vilnius", 102, district2a);


            Console.WriteLine(district1.ToString());
            Console.WriteLine(district2.ToString());


            district2.RemoveOfficer();
            Console.WriteLine("An Officer from district Vilnius was removed. Updated District 2:");
            Console.WriteLine(district2.ToString());

            Console.WriteLine("Las Vegas average level: " + district1.AverageLevel());
            Console.WriteLine("Vilnius average level: " + district2.AverageLevel());

            District[] arrOfDistricts = new District[2];
            arrOfDistricts[0] = district1;
            arrOfDistricts[1] = district2;

            float OfficersInBothDistrictsNm = district1a.Length + district2a.Length;
            Console.WriteLine("Total number of officers in both districts: " + OfficersInBothDistrictsNm);

            float averageOfBoth = district1.SumLevel() + district2.SumLevel() / OfficersInBothDistrictsNm;
            Console.WriteLine("Average level of both districts: " + averageOfBoth);


            if (district1.AverageLevel() > district2.AverageLevel())
            {
                Console.WriteLine("The officers of Las Vegas have higher level. Las Vegas district is better");
            }
            else
            {
                Console.WriteLine("Vilnius officers are better. Vilnius district is better");
            }


        }
    }
}
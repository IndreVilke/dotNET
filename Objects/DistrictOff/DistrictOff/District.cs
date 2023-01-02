using System;

namespace DistrictOff
{
    internal class District
    {
        private string title;
        private string city;
        private int districtId;
        private Officer[] officersInDistrict;

        public District() { }
        public District(string title, string city, int districtId, Officer[] officersInTheDistrict)
        {
            this.title = title;
            this.city = city;
            this.districtId = districtId;
            this.officersInDistrict = officersInDistrict;

        }
        public string Title { get; set; }

        public string City { get; set; }

        public string DistrictId { get; set; }

        public Officer[] OfficersInDistrict { get; set; }

        public override string ToString()
        {
            string details = "Title: " + title + "\n" + "City: " + city + "\n" + "DistrictID: " + districtId
                + "\n" + "Officers:\n";

            foreach (Officer officer in officersInDistrict)
            {
                if (officer == null)
                {
                    Console.WriteLine("Warum denn???");
                }
                else
                { 
                    details += officer.ToString();
                }
            return details;
        }

        public bool RemoveOfficer()
        {
            this.officersInDistrict[0] = null;
            return true;
        }

        public float SumLevel()
        {
            float lvlSum = 0;
            foreach (Officer officer in officersInDistrict)
            {
                if (officer != null)
                {
                    lvlSum += officer.CalculatedLevel();
                }
            }
            return lvlSum;
        }
        public float AverageLevel()
        {

            float averLvl = this.SumLevel() / officersInDistrict.Length;
            return averLvl;
        }
    }
}
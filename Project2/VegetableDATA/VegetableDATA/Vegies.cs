using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableDATA
{
    internal class Vegies
    {
        public string name { get; }
        public string habitat { get; }
        public string hint { get; }

        public Vegies(string objName, string objHabitat, string objHint)
        {
            this.name = objName;
            this.habitat = objHabitat;
            this.hint = objHint;

        }
        public override string ToString()
        {
            return $"Name: {name,-8} Habitat: {habitat,-14} It has: {hint} ";
        }


    }
}

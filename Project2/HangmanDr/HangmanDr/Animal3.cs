using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman3
{

    class Animals3
    {
        public string name { get; }
        public string habitat { get; }
        public string hint { get; }

        public Animals3(string objName, string objHabitat, string objHint)
        {
            this.name = objName;
            this.habitat = objHabitat;
            this.hint = objHint;

        }
        public override string ToString()
        {
            return $"Name: {name,-8} Habitat: {habitat,-10} It has: {hint} ";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonPerson
{
    class Person
    {
        private string name, lastname;
        private DateTime birthDate;
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Lastname
        { 
            get { return lastname; }
            set { lastname = value; }
        }

        public DateTime BirthDate

        {
            get { return birthDate; }
            set { birthDate = value; }
        }

    }
}


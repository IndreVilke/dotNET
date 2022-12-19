using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClassObject
{
    public class Person
    {
        private string name, lastname;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string LastName
        {
            get { return this.lastname; }
            set { this.lastname = value; }
        }

        public Person(string name, string lastname)
        {
            this.name = name;
            this.lastname = lastname;
            
        }

        public string FullName()
        {
            return this.name + " " + this.lastname;
        }


        public void Show()
        {
            Console.WriteLine("Name : " + this.Name);
            Console.WriteLine("Last Name : " + this.LastName);
            Console.WriteLine("Full Name : " + this.FullName);

        }

    }

}

using PersonClassObject;
using System.Xml.Linq;


namespace PersonClassObject
{
    class PersonClassObject
    {
        static void Main(string[] args)
        {

            Person person = new Person();
            Console.WriteLine("Enter First Name : ");
            person.Name = Console.ReadLine();

            Console.WriteLine("Enter Last Name : ");
            person.LastName = Console.ReadLine();

            
            person.Show();
        }
    }
}





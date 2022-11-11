using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Ovn3
{
    public class PersonHandler
    {

        public Person CreatePerson(int age, string fName, string lName, double height, double weight)
        {
            var newPerson = new Person();
            newPerson.Age = age;
            newPerson.FName = fName;
            newPerson.LName = lName;
            newPerson.Height = height;
            newPerson.Weight = weight;

            return newPerson;
        }


        public void SetAge(Person person, int age)
        {
            person.Age = age;
        }

        public void SetFname(Person person, string fName)
        {
            person.FName = fName;
        }

        public void SetLname(Person person, string lName)
        {
            person.LName = lName;
        }

        public void SetHeight(Person person, int height)
        {
            person.Height = height;
        }

        public void SetWeight(Person person, int weight)
        {
            person.Weight = weight;
        }
    }
}

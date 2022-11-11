using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn3
{
    public class Person
    {
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        public int Age
        {
            get => age;
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Age must be a positive integer.");
                }
                age = value;
            }
        }

        public string FName
        {
            get => fName;
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Name must be entered.");
                }
                if (value.Length < 2 || value.Length > 10)
                {
                    throw new ArgumentException("Name must be between 2 to 10 characters long.");
                }
                fName = value;

            }
        }

        public string LName
        {
            get => lName;
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Name must be entered.");
                }
                if (value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentException("Name must be between 3 to 15 characters long.");
                }
                lName = value;
            }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public Person()
        { }

    }
}


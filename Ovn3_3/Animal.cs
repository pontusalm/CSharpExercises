using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn3_3
{
    internal abstract class Animal
    {
        private string name;
        private int weight;
        private int age;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public virtual void DoSound()
        {Console.WriteLine("wow wow");}


    }

}

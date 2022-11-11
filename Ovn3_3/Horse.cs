using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ovn3_3
{
    internal class Horse : Animal
    {

        public Horse CreateHorse(string name, int weight, int age)
        {
            var newHorse = new Horse();
            newHorse.Name = name;
            newHorse.Weight = weight;
            newHorse.Age = age;

            return newHorse;
        }

        public override void DoSound()
        {
            Console.WriteLine("Gnägg gnägg");
        }

    }
}

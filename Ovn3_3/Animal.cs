﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn3_3
{
    internal abstract class Animal
    {
        private string name;
        private string weight;
        private int age;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

    }

}

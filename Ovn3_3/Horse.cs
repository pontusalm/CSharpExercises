using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ovn3_3
{
    internal abstract class Horse : Animal
    {
        public override void DoSound()
        {
            Console.WriteLine("Gnägg gnägg");
        }
    }
}

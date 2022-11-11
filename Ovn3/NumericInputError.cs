using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn3
{
    internal class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            throw new NotImplementedException("You tried to use anumeric input in a text only field. This fired an error!");
        }
    }

}

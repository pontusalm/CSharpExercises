using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn3
{
    internal class TextInputError : UserError
    {
        public override string UEMessage()
        {
            throw new NotImplementedException("You tried to use a textinput in a numeric only field. This fired an error");
        }
    }
}

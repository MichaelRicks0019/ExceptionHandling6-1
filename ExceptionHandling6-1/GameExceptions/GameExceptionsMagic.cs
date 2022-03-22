using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling6_1
{
    public class GameExceptionsDefaultMagic : Exception
    {
        public GameExceptionsDefaultMagic() : base("Default magic cannot be higher than 100 or less then 0")
        {

        }

        public GameExceptionsDefaultMagic(string messageValue) : base(messageValue)
        {

        }

        public GameExceptionsDefaultMagic(string messageValue, Exception inner) : base(messageValue, inner)
        {

        }
    }
}

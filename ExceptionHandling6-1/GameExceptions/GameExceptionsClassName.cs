using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling6_1
{
    class GameExceptionsClassName : Exception
    {
        public GameExceptionsClassName() : base("Must enter valid Class value")
        {

        }

        public GameExceptionsClassName(string messageValue) : base(messageValue)
        {

        }

        public GameExceptionsClassName(string messageValue, Exception inner) : base(messageValue, inner)
        {

        }
    }
}

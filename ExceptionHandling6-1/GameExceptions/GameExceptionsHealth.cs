using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling6_1
{
    public class GameExceptionDefaultHealth : Exception
    {
        public GameExceptionDefaultHealth() : base("Default health cannot be higher than 100 or less than 0")
        {

        }

        public GameExceptionDefaultHealth(string messageValue) : base(messageValue)
        {

        }

        public GameExceptionDefaultHealth(string messageValue, Exception inner) : base(messageValue, inner)
        {
            
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katabank.Exceptions
{
    public class InvalidDateException : Exception
    {
        public InvalidDateException(string message) : base(message)
        {

        }
    }
}

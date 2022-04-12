using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katabank.Exceptions
{
    public class InvalidDepositException : Exception
    {
        public InvalidDepositException(string message) : base(message)
        {

        }
    }
}

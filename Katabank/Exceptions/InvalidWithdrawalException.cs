using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katabank.Exceptions
{
    public class InvalidWithdrawalException : Exception
    {
        public InvalidWithdrawalException(string message) : base(message)
        {

        }
    }
}

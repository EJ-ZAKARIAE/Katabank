using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katabank.Model
{
    public class Client
    {
        public string Owner { get; set; }
        private static int accountNumberSeed = 1234567890;
        public string Number { get; }
        public Client(string name)
        {
            Number = accountNumberSeed.ToString();
            accountNumberSeed++;

            Owner = name;
        }
    }
}

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
        public int Number { get; }
        public Client(string name, int number)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("name");

            if (number == 0)
                throw new ArgumentException("number");

            Number = number;

            Owner = name;
        }
    }
}

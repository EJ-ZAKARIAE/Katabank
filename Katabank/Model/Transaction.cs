using Katabank.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katabank
{
    public class Transaction
    {
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Notes { get; }

        public Transaction(decimal amount, DateTime date, string note)
        {
            Amount = amount;
            Date = date;
            if (!Helper.DateTimeValidator.ValidateDate(date))
                throw new InvalidDateException("This date is not valide !");

            Notes = note;
        }

        public string ToString(decimal balance)
        {
            return $"{Date.ToShortDateString()}\t{Amount}\t{balance}\t{Notes}";
        }
        public override string ToString()
        {
            return $"{Date.ToShortDateString()}\t{Amount}\t{Notes}";
        }
    }
}

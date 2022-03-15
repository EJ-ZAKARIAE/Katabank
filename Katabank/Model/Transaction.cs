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
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }

            Amount = amount;

            try
            {
                IFormatProvider culture = new System.Globalization.CultureInfo("fr-FR", true);

                Date = System.Convert.ToDateTime(date, culture);
            }
            catch (Exception)
            {
                throw new InvalidOperationException("This date is not valide !");
            }

            Notes = note;
        }

        public Transaction(decimal amount, DateTime date, string note, decimal balance)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }

            Amount = - amount;

            try
            {
                IFormatProvider culture = new System.Globalization.CultureInfo("fr-FR", true);

                Date = System.Convert.ToDateTime(date, culture);
            }
            catch (Exception)
            {
                throw new InvalidOperationException("This date is not valide !");
            }

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

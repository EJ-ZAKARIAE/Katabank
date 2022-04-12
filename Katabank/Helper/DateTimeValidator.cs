using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katabank.Helper
{
    internal class DateTimeValidator
    {
        public static bool ValidateDate(DateTime date)
        {
            try
            {
                IFormatProvider culture = new System.Globalization.CultureInfo("fr-FR", true);

                date = System.Convert.ToDateTime(date, culture);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

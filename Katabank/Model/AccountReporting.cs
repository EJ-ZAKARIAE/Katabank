using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katabank.Model
{
    public class AccountReporting : IAccountReporting
    {
        public string GetAccountHistory(List<Transaction> allTransactions)
        {
            var report = new System.Text.StringBuilder();

            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\tBalance\tNote");
            foreach (var item in allTransactions)
            {
                balance += item.Amount;
                report.AppendLine($"{item.ToString(balance)}");
            }

            return report.ToString();
        }
    }
}

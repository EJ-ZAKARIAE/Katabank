using Katabank.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katabank
{
    public class BankAccount
    {
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }

                return balance;
            }
        }

        public AccountReporting accountReporting = new AccountReporting();
        public Client client { get; set; }

        private readonly List<Transaction> allTransactions = new List<Transaction>();

        public BankAccount(string name, decimal initialBalance)
        {
            client = new Client(name);
            MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        { 
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            var withdrawal = new Transaction(amount, date, note, Balance);
            allTransactions.Add(withdrawal);
        }

        public override String ToString()
        {
            return $"Account {client.Number} was created for {client.Owner} with {Balance} balance.";
        }
        public List<Transaction> GetAllTransactions()
        {
            return allTransactions;
        }
    }
}

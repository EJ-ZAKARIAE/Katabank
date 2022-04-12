using Katabank.Exceptions;
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
        public decimal Balance => allTransactions.Sum(x => x.Amount);

        public Client client { get; set; }

        private readonly List<Transaction> allTransactions = new List<Transaction>();

        public BankAccount(string name, decimal initialBalance)
        {
            client = new Client(name, Helper.ClientIdentity.GetAccountId());
            MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
                throw new InvalidDepositException("Can't make negative deposit");

            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount > 0)
                throw new InvalidWithdrawalException("Can't make positive withdrawal");

            if (Balance - (-1) * amount < 0)
                throw new InvalidWithdrawalException("Not enough balance!");

            var withdrawal = new Transaction(amount, date, note);
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

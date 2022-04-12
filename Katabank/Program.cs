using Katabank;
using Katabank.Model;

var account = new BankAccount("Zakariae EJJELTHI", 1000);
Console.WriteLine(account);

account.MakeWithdrawal(-500, DateTime.Now, "Rent payment");
account.MakeDeposit(100, DateTime.Now, "Friend paid me back");

IAccountReporting accounReporting = new AccountReporting();
Console.WriteLine(accounReporting.GetAccountHistory(account.GetAllTransactions()));
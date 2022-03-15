using Katabank;
using Katabank.Model;

var account = new BankAccount("<name>", 1000);
Console.WriteLine(account);

account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
Console.WriteLine(account.Balance);
account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
Console.WriteLine(account.Balance);

IAccountReporting accounReporting = new AccountReporting();
Console.WriteLine(accounReporting.GetAccountHistory(account.GetAllTransactions()));

// Test that the initial balances must be positive:
try
{
    var invalidAccount = new BankAccount("invalid", -55);
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine("Exception caught creating account with negative balance");
    //Console.WriteLine(e.ToString());
}

// Test for a negative balance
try
{
    account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
}
catch (InvalidOperationException e)
{
    Console.WriteLine("Exception caught trying to overdraw");
    //Console.WriteLine(e.ToString());
}
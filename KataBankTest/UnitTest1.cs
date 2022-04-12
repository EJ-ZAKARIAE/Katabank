using Katabank;
using Katabank.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KataBankTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShouldReturn1000WhenInitialBalance1000()
        {
            BankAccount bankAccount = new BankAccount("Zakariae EJJELTHI", 1000);
            Assert.AreEqual(1000, bankAccount.Balance);
        }

        [TestMethod]
        public void ShouldReturn600WhenWithdrawal400()
        {
            BankAccount bankAccount = new BankAccount("Zakariae EJJELTHI", 1000);
            bankAccount.MakeWithdrawal(-400, DateTime.Now, "Rent payment");
            Assert.AreEqual(600, bankAccount.Balance);
        }

        [TestMethod]
        public void ShouldReturn1200WhenDeposit200()
        {
            BankAccount bankAccount = new BankAccount("Zakariae EJJELTHI", 1000);
            bankAccount.MakeDeposit(200, DateTime.Now, "Friend paid me back");
            Assert.AreEqual(1200, bankAccount.Balance);
        }

        [TestMethod]
        public void Should_Throw_Exception_When_Initial_Balance_Is_Negative()
        {
            Assert.ThrowsException<InvalidDepositException>(() => new BankAccount("<Name>", -55));
        }

        [TestMethod]
        public void Should_Throw_Exception_When_Overdraw()
        {
            Assert.ThrowsException<InvalidWithdrawalException>(() => {
                var account = new BankAccount("Zakariae EJJELTHI", 1000);

                account.MakeWithdrawal(-500, DateTime.Now, "Rent payment");
                account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
                account.MakeWithdrawal(-750, DateTime.Now, "Attempt to overdraw");
            });
        }
    }
}
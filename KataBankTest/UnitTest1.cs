using Katabank;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KataBankTest
{
    [TestClass]
    public class UnitTest1
    {
        BankAccount bankAccount = new BankAccount("Zakariae EJJELTHI", 1000);

        [TestMethod]
        public void ShouldReturn1000WhenInitialBalance1000()
        {
            Assert.AreEqual(1000, bankAccount.Balance);
        }

        [TestMethod]
        public void ShouldReturn600WhenWithdrawal400()
        {
            bankAccount.MakeWithdrawal(400, DateTime.Now, "Rent payment");
            Assert.AreEqual(600, bankAccount.Balance);
        }

        [TestMethod]
        public void ShouldReturn1200WhenDeposit200()
        {
            bankAccount.MakeDeposit(200, DateTime.Now, "Friend paid me back");
            Assert.AreEqual(1200, bankAccount.Balance);
        }
    }
}
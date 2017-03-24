using AutomatedTellerMachine.Controllers;
using AutomatedTellerMachine.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomatedTellerMachine.Tests.Controllers
{
    [TestClass]
    public class TransactionControllerTest
    {
        [TestMethod]
        public void BalanceIsCorrectAfterDeposit()
        {
            //Arrange
            var fakeDb = new FakeApplicationDbContext();

            fakeDb.CheckingAccounts = new FakeDbSet<CheckingAccount>();
            fakeDb.Transactions = new FakeDbSet<Transaction>();
            var checkingAccount = new CheckingAccount
            {
                Id = 1,
                AccountNumber = "0000123TEST",
                Balance = 2000
            };

            fakeDb.CheckingAccounts.Add(checkingAccount);

            var transActionController = new TransactionController(fakeDb);

            //Act
            transActionController.Deposit(new Transaction { CheckingAccountId = 1, AmountDecimal = 1000 });

            //Assert
            //checkingAccount.Balance = 3000; //assert if the assert staement is valid or not
                                            //and passing test the simplest way, otherwise test
                                            //fails as balance is not updated yet
            Assert.AreEqual(3000, checkingAccount.Balance);
        }
    }
}

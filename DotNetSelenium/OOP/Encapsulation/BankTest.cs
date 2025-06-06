using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSelenium.OOP.Encapsulation
{
    public class BankTest
    {
        private Wallet wallet;

        [SetUp]
        public void Setup()
        {
            wallet = new Wallet(1000);
      
        }

        [Test]

        public void TestDeposit()
        {
            wallet.Deposit(500);
            // wallet.Withdraw(200);
            //Console.WriteLine(wallet.GetBalance());
            //Console.WriteLine(wallet.Balance); 
            Console.WriteLine(wallet.balance);
        }

        [Test]
        public void TestWithdraw()
        {
            wallet.Withdraw(200);
            //Console.WriteLine(wallet.GetBalance());
        }

    }
}

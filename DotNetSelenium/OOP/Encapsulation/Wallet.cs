using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSelenium.OOP.Encapsulation
{
    public class Wallet
    {
        //private decimal balance { get; set; }
        public decimal balance { get; set; }

        public Wallet(decimal initialAmount)
        {
            this.balance = initialAmount;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount.");
            }
        }




        //public decimal Balance
        //{
        //    get { return balance; }
             
        //}


        //public decimal GetBalance()
        //{
        //    return balance;
        //}

    }
}

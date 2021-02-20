using System;
using System.Collections.Generic;
using System.Text;
using OOPMarcus_AccountInfo.Interfaces;

namespace OOPMarcus_AccountInfo.Models
{
    internal class SavingAccount : IAccount
    {
        public string Name { get; set; }
        public decimal Balance { get; private set; }

        public SavingAccount()
        {

        }

        public SavingAccount(decimal initialBalance)
        {
            if (initialBalance <= 0)
            {
                throw new Exception("amount too small");
            }
            Balance = initialBalance;
        }

        public string AccountInfo()
        {
            return $"Account name:{Name}, Balance {Balance}:-";
        }

        public decimal Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new Exception("amount too small");
            }
            Balance += amount;
            return Balance;
        }

        public decimal Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new Exception("amount too small");
            }
            if (amount > Balance)
            {
                throw new Exception("not enough credit!");

            }
            Balance -= amount;
            return Balance;
        }
    }
}

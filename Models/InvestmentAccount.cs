using System;
using System.Collections.Generic;
using System.Text;
using OOPMarcus_AccountInfo.Interfaces;

namespace OOPMarcus_AccountInfo.Models
{
    internal class InvestmentAccount : IAccount
    {
        public string Name { get; set; }
        public decimal Balance { get; private set; }
        public InvestmentAccount()
        {
            
        }
        public InvestmentAccount(decimal initialBalance)
        {
            if (initialBalance <= 0) throw new System.Exception("amount too small");
            Balance = initialBalance;
        }

        public string AccountInfo()
        {
            return $"Account name: {Name}, Balance {Balance}:-";
        }

        public decimal Deposit(decimal amount)
        {
            if (amount <= 0) throw new System.Exception("amount too small");
            Balance += amount;
            return Balance;
        }

        public decimal Withdraw(decimal amount)
        {
            if (amount <= 0) throw new System.Exception("amount too small");
            if (amount > Balance) throw new System.Exception("not enough credit!");

            Balance -= amount;
            return Balance;
        }
    }
}

using System;
using System.Collections.Generic;
using OOPMarcus_AccountInfo.Models;
using OOPMarcus_AccountInfo.Interfaces;



namespace OOPMarcus_AccountInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bank = new List<IAccount>
            {
                new SavingAccount(10000){Name ="Salary"},
                new SavingAccount(15000){Name ="Bitcoin"},
                new InvestmentAccount(300000){Name="for house"},
                new Creditcard(0){Name= "XYZ", MaxCredit= 1500}

                };



            foreach (var account in bank)
            {
                Console.WriteLine(account.AccountInfo());
            }
           


            var card = new Creditcard(1400) { Name = "Credit extra", MaxCredit = 15000 };
            card.Withdraw(100);
            bank.Add(card);
            Console.WriteLine("List with the newly added credit card: ");
            foreach (var account in bank)
            {
                Console.WriteLine(account.AccountInfo());
            }

        }
    }
}

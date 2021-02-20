using System;
using System.Collections.Generic;
using System.Text;

namespace OOPMarcus_AccountInfo.Interfaces
{
    interface IAccount
    {
        string Name { get; set; }
        decimal Balance { get; }

        string AccountInfo();
        decimal Withdraw(decimal amount);
        decimal Deposit(decimal amount);

    }
}

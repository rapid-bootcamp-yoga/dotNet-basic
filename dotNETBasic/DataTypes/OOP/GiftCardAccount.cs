﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes.OOP
{
    public class GiftCardAccount : BankAccount
    {

        //constructor
        private readonly decimal _monthlyDeposit = 0m;

        public GiftCardAccount(string name, decimal initialBalance, decimal monthlyDeposit = 0) : base(name, initialBalance) 
            => _monthlyDeposit = monthlyDeposit;

        //nambah setoran bulanan
        public override void PerformMonthEndTransactions()
        {
           if (_monthlyDeposit != 0)
            {
                MakeDeposit(_monthlyDeposit, DateTime.Now, "Add monthly Deposit");
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes.OOP
{
    public class LineOfCreditAccount : BankAccount
    {

        //constructor
        public LineOfCreditAccount(string name, decimal initialBalance) : base(name, initialBalance)
        { 
        }

        public LineOfCreditAccount(string name, decimal initialBalance, decimal creditLimit) : base(name, initialBalance, -creditLimit)
        {
        }

        //kode meniadakan saldo
        public override void PerformMonthEndTransactions()
        {
            if (Balance < 0)
            {
                //Negate the balance to get a positive interest charge:
                decimal interest = -Balance * 0.07m;
                MakeWithdrawal(interest, DateTime.Now, "Charge monthly Interest");
            }
        }

        //
        protected override Transaction? CheckWithdrawalLimit(bool isOverdrawn) =>
            isOverdrawn
            ? new Transaction(-20, DateTime.Now, "Apply overdraft fee")
            : default;

    }


}

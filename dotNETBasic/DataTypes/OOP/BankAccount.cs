using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes.OOP
{
    public class BankAccount
    {
        private readonly decimal _minimumBalance;

        private static int s_accountNumberSeed = 1234567890;
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance {
            get
            {
                decimal balance = 0;
                foreach (var item in _allTransactions)
                {
                    balance += item.Amount;
                }

                return balance;
            }

        }

        
        //constructor

        public BankAccount()
        {

        }

        public BankAccount( string name, decimal initialBalance): this(name, initialBalance, 0) { }

        public BankAccount( string name, decimal initialBalance, decimal minimumBalance)
        {
            Number = s_accountNumberSeed.ToString();
            s_accountNumberSeed++;

            Owner = name;
            _minimumBalance = minimumBalance;
            if (initialBalance > 0)
                MakeDeposit(initialBalance, DateTime.Now, "Initial balance");

        }

        private List<Transaction> _allTransactions = new List<Transaction>();

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            _allTransactions.Add(deposit);
        }


        //refaktor makewithdrawal
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            Transaction? overdraftTransaction = CheckWithdrawalLimit(Balance - amount < _minimumBalance);
            Transaction? withdrawal = new(-amount, date, note);
            _allTransactions.Add(withdrawal);
            if (overdraftTransaction != null)
                _allTransactions.Add(overdraftTransaction);
        }

        protected virtual Transaction? CheckWithdrawalLimit(bool isOverdrawn)
        {
            if (isOverdrawn)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            else
            {
                return default;
            }
        }
        //refaktor makewithdrawal end


        //public void MakeWithdrawal(decimal amount, DateTime date, string note)
        //{
        //    if (amount <= 0)
        //    {
        //        throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
        //    }
        //    if (Balance - amount < _minimumBalance)
        //    {
        //        throw new InvalidOperationException("Not sufficient funds for this withdrawal");
        //    }
        //    var withdrawal = new Transaction(-amount, date, note);
        //    allTransactions.Add(withdrawal);
        //}

        public string GetAccountHistory()
        {
            var report = new StringBuilder();

            decimal balance = 0;
            //Header
            report.AppendLine("Date\t\tAmount\t\tBalance\t\tNote");
            foreach (var item in _allTransactions)
            {
                balance += item.Amount;
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
            }

            return report.ToString();
        }

        //virtual metode
        public virtual void PerformMonthEndTransactions() 
        {
        }
    }
}

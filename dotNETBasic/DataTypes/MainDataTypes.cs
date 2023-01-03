using DataTypes.CustomeType;
using DataTypes.OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataTypes
{
    public struct Coords
    {
        public int x, y;

        public Coords(int p1, int p2)
        {
            x = p1;
            y = p2;
        }

        public override string ToString()
        {
            return "Coord (" + x + ", " + y + ")";
        }
    }

    public class MainDataTypes
    {
        public static void Main()
        {
            TransactionBankAccount();

        }

        #region sample Transaction BankAccount
        public static void TransactionBankAccount()
        {
           
            var account = new BankAccount("Yoga", 11500500000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

            // Test for a negative balance.
            try
            {
                account.MakeWithdrawal(14750000, DateTime.Now, "Beli Sepeda Motor");
                //Console.WriteLine(account.Balance);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }

            try
            {
                account.MakeWithdrawal(650000000, DateTime.Now, "Rumah");
                //Console.WriteLine(account.Balance);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }

            //Nambah Deposit
            try
            {
                account.MakeDeposit(205000000, DateTime.Now, "Pemasukkan Januari");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Amount of deposit must be positive");
                Console.WriteLine(e.ToString());
            }

            //Cetak History
            Console.WriteLine(account.GetAccountHistory());


            // Test that the initial balances must be positive.
            BankAccount invalidAccount;
            try
            {
                invalidAccount = new BankAccount("invalid", -55000);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
                return;
            }
        }
        #endregion

        #region Sample Bank Account
        public static void BankAccountSample()
        {

            var account = new BankAccount("Yoga Julian", 100000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

            var account2 = new BankAccount("Yoga", 1555500000);
            Console.WriteLine($"Account {account2.Number} was created for {account2.Owner} with {account2.Balance} initial balance.");

            var account3 = new BankAccount("Yoga J", 100500000);
            Console.WriteLine($"Account {account3.Number} was created for {account3.Owner} with {account3.Balance} initial balance.");

            var account21 = new BankAccount("YJP", 2555500000);
            Console.WriteLine($"Account {account21.Number} was created for {account21.Owner} with {account21.Balance} initial balance.");
        } 
        #endregion

        #region Sample Class
        public static void SampleClass()
        {
            SampleClass sampleClass;

            sampleClass = new SampleClass();
            Console.WriteLine("Setelah panggil construktor");
            Console.WriteLine("Sample class value: {0}", sampleClass.ToString());

            sampleClass = new SampleClass(3, 6);
            Console.WriteLine("Setelah panggil construktor dengan params");
            Console.WriteLine("Sample class value: {0}", sampleClass.ToString());


        }
        #endregion

        #region Sample Enum
        public static void SampleEnum()
        {
            Type weekDays = typeof(EnumDays);
            foreach (var item in Enum.GetNames(weekDays))
            {
                Console.WriteLine("Hari : {0}", item);
            }

            Type fieldMode = typeof(EnumFileMode);
            foreach (var mode in Enum.GetNames(fieldMode))
            {
                Console.WriteLine("FieldMode {0}: ", mode);
            }

            Colors myColors = Colors.Red | Colors.Yellow | Colors.Green;
            Console.WriteLine();
            Console.WriteLine("myColors holds a combination of colors. Namely: {0}", myColors);
            Console.WriteLine("Coloer Red: {0}, GetName:{1}", Colors.Red, Enum.GetName(Colors.Red));
            Console.WriteLine("Status Approved: {0}, Names: {1}", ApprovalStep.Approved, Enum.GetName(ApprovalStep.Approved));
        }
        #endregion

        #region Sample Coord
        public static void SampleCoord()
        {
            Coords point1 = new Coords(2, 5);
            Console.WriteLine("Point 1: " + point1);

            Coords point2 = new Coords(7, 7);
            Console.WriteLine("Point 2: " + point2);
        }
        #endregion

        #region Sample DataTypes
        public static void SampleDataTypes()
        {
            // Declaration with initializers (4 examples):
            char firstLetter = 'C';
            var limit = 3;
            int[] source = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, };
            //ini merupakan linQ
            var query = from item in source
                        where item <= limit
                        select item;
            Console.WriteLine("Hasil query : " + query);
            foreach (var item in query)
            {
                Console.WriteLine("item value 1: " + item);
            }
            var query2 = from item in source
                         where item % 2 == 1
                         select item;
            Console.WriteLine("Hasil query2 bil ganjil");
            foreach (var item in query2)
            {
                Console.WriteLine("item value query2: " + item);
            }
        }
        #endregion

    }
}

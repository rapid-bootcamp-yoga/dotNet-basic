using DataTypes.CustomeType;
using DataTypes.InheritanceType;
using DataTypes.ObjectType;
using DataTypes.OOP;
using DataTypes.PolymorphismType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static DataTypes.PolymorphismType.Shape;
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
            //SampleDataTypes();
            // SampleGiftCardAccount();
            //SampleInterestEarningAccount();
            // SampleLineOfCreditAccount();
            //SampleObjectPerson();
            //SampleInheritance();
            //SamplePolymorphism();
            InterfaceImplement();

        }

        #region sample Interface
        public static void InterfaceImplement()
        {
            SampleClassImplement sample = new SampleClassImplement();
            IControl control = sample;
            ISurface surface = sample;

            // The following lines all call the same method.
            sample.Paint();
            sample.Create();
            sample.Draw();

            control.Paint();
            control.Create();

            surface.Paint();
            surface.Draw();

            // Output:
            // Paint method in SampleClass
            // Paint method in SampleClass
            // Paint method in SampleClass
        }
        #endregion

        #region Polymorphism
        public static void SamplePolymorphism()
        {
            // Polymorphism at work #1: a Rectangle, Triangle and Circle
            // can all be used wherever a Shape is expected. No cast is
            // required because an implicit conversion exists from a derived
            // class to its base class.
            var shapes = new List<Shape>
            {
                new Rectangle(),
                new Triangle(),
                new Circle()
            };

            // Polymorphism at work #2: the virtual method Draw is
            // invoked on each of the derived classes, not the base class.
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
            /* Output:
                Drawing a rectangle
                Performing base class drawing tasks
                Drawing a triangle
                Performing base class drawing tasks
                Drawing a circle
                Performing base class drawing tasks
            */
        }
        #endregion

        #region sample inheritance
        public static void SampleInheritance()
        {
            // Create an instance of WorkItem by using the constructor in the
            // base class that takes three arguments.
            WorkItem item = new WorkItem("Fix Bugs",
                                        "Fix all bugs in my code branch",
                                        new TimeSpan(3, 4, 0, 0));

            // Create an instance of ChangeRequest by using the constructor in
            // the derived class that takes four arguments.
            ChangeRequest change = new ChangeRequest("Change Base Class Design",
                                                    "Add members to the class",
                                                    new TimeSpan(4, 0, 0),
                                                    1);

            // Use the ToString method defined in WorkItem.
            Console.WriteLine(item.ToString());

            // Use the inherited Update method to change the title of the
            // ChangeRequest object.
            change.Update("Change the Design of the Base Class",
                new TimeSpan(4, 0, 0));

            // ChangeRequest inherits WorkItem's override of ToString.
            Console.WriteLine(change.ToString());
            /* Output:
                1 - Fix Bugs
                2 - Change the Design of the Base Class
            */
        }
        #endregion

        #region Sample Object
        public static void SampleObjectPerson()
        {
            Person person1 = new Person("Yoga", 26);
            Console.WriteLine("person1 Name = {0} Age = {1}", person1.Name, person1.Age);

            // Declare new person, assign person1 to it.
            Person person2 = person1;

            // Change the name of person2, and person1 also changes.
            person2.Name = "Sippy";
            person2.Age = 16;

            Console.WriteLine("person2 Name = {0} Age = {1}", person2.Name, person2.Age);
            Console.WriteLine("person1 Name = {0} Age = {1}", person1.Name, person1.Age);

            Person person3 = new Person("Tiyo", 29);
            Console.WriteLine("person3 Name = {0} Age = {1}", person3.Name, person3.Age);

        }
        #endregion

        #region sample GiftCart acount
        public static void SampleGiftCardAccount()
        {
            var giftCard = new GiftCardAccount("gift card", 100, 50);
            giftCard.MakeWithdrawal(20, DateTime.Now, "get expensive coffee");
            giftCard.MakeWithdrawal(50, DateTime.Now, "buy groceries");
            giftCard.PerformMonthEndTransactions();
            // can make additional deposits:
            giftCard.MakeDeposit(27.50m, DateTime.Now, "add some additional spending money");
            Console.WriteLine(giftCard.GetAccountHistory());
        }
        #endregion

        #region sample interestEarning account
        public static void SampleInterestEarningAccount()
        {
            var savings = new InterestEarningAccount("savings account", 10000);
            savings.MakeDeposit(750, DateTime.Now, "save some money");
            savings.MakeDeposit(1250, DateTime.Now, "Add more savings");
            savings.MakeWithdrawal(250, DateTime.Now, "Needed to pay monthly bills");
            savings.PerformMonthEndTransactions();
            Console.WriteLine(savings.GetAccountHistory());
        }
        #endregion

        #region sample lineOfcredit
        public static void SampleLineOfCreditAccount()
        {
            var lineOfCredit = new LineOfCreditAccount("line of credit", 0, 2000);
            //var lineOfCredit = new LineOfCreditAccount("line of credit", 0);

            // How much is too much to borrow?
            lineOfCredit.MakeWithdrawal(1000m, DateTime.Now, "Take out monthly advance");
            lineOfCredit.MakeDeposit(50m, DateTime.Now, "Pay back small amount");
            lineOfCredit.MakeWithdrawal(5000m, DateTime.Now, "Emergency funds for repairs");
            lineOfCredit.MakeDeposit(150m, DateTime.Now, "Partial restoration on repairs");
            lineOfCredit.PerformMonthEndTransactions();
            Console.WriteLine(lineOfCredit.GetAccountHistory());

         
        }
        #endregion

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

            var query3 = from item in source
                         where item % 2 == 0
                         select item;
            Console.WriteLine("Hasil query bil genap");
            foreach (var item in query2)
            {
                Console.WriteLine("item value query: " + item);
            }
        }
        #endregion

    }
}

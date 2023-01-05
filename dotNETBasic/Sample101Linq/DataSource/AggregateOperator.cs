﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample101Linq.DataSource
{
    public class AggregateOperator
    {

        public List<Customer> GetCustomerList() => Customers.CustomerList;
        public int CountSyntax()
        {
            #region sintak count
            int[] factorsOf3000 = { 2, 2, 5, 5, 6, 6, 6, 9,9,9,9,9,9 };

            //menghitung jumlah elemen unik
            int uniqueFactors = factorsOf3000.Distinct().Count();
            Console.WriteLine($"There are {uniqueFactors} unique factors of 3000");

            #endregion
            return 0;
        }

        public int CountConditional()
        {
            #region count condisional
            int[] numbers = { 3, 4, 5 };

            int oddNumbers = numbers.Count(n => n % 2 == 1);

            Console.WriteLine("There are {0} odd numbers in the list", oddNumbers);

            #endregion
            return 0;
        }

        public int CountNested()
        {
            #region nested count
         // List<Customer> customers = Customers.CustomerList;
            List<Customer> customers = Customers.GetCustomersList();

            var orderCounts = from c in customers
                              select (c.CustomerID, OrderCount: c.Orders.Count());

            foreach (var customer in orderCounts)
            {
                Console.WriteLine($"ID: {customer.CustomerID}, count: {customer.OrderCount}");
            }
            #endregion
            return 0;
        }
    }
}
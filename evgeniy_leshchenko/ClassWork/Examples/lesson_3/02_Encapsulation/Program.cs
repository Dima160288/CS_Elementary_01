using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Encapsulation
{
    class Transaction
    {
        public int DepartmentID;
        public double Profit;
    }

    class ReportData
    {
        public int DepartmentCount;
        public List<Transaction> Transactions;

        public void PrintProfits()
        {
            var profits = new double[DepartmentCount];

            foreach (var item in Transactions)
                profits[item.DepartmentID] += item.Profit;

            for (int i = 0; i < DepartmentCount; i++)
                Console.WriteLine("{0,-10}{1}", i, profits[i]);
        }
    }

    class Program
    {
        public static void Main()
        {
            var report = new ReportData
            {
                DepartmentCount = 2,
                Transactions = new List<Transaction> {
                new Transaction{ DepartmentID = 0, Profit = 10000 },
                new Transaction{ DepartmentID = 1, Profit = 20000},
                new Transaction{ DepartmentID = 1, Profit = 10000}
            }
            };

            //report.DepartmentCount = -1;

            report.PrintProfits();

            Console.ReadLine();
        }
    }
}

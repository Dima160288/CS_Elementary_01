using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Encapsulation
{
    class Transaction
    {
        public int DepartmentID { get; set; }
        public double Profit { get; set; } 
    }

    class ReportData
    {
        private int departmentCount;

        public List<Transaction> Transactions;

        public int SetDepartmentCount
        {
            get
            {
                return departmentCount;
            }
            set
            {
                if (value < 1)
                    throw new ArgumentException();
                departmentCount = value;
            }
        }

        public void PrintProfits()
        {
            var profits = new double[departmentCount];

            foreach (var item in Transactions)
                profits[item.DepartmentID] += item.Profit;

            for (int i = 0; i < departmentCount; i++)
                Console.WriteLine("{0,-10}{1}", i, profits[i]);
        }
    }

    class Program
    {
        public static void Main()
        {
            var report = new ReportData
            {
                SetDepartmentCount = 2,
                Transactions = new List<Transaction> {
                new Transaction{ DepartmentID = 0, Profit = 10000 },
                new Transaction{ DepartmentID = 1, Profit = 20000},
                new Transaction{ DepartmentID = 1, Profit = 10000},
                new Transaction{ DepartmentID = 2, Profit = 10000}
            }
            };
            report.SetDepartmentCount = 3;
            //report.DepartmentCount = -1;
            
            report.PrintProfits();

            Console.ReadLine();
        }
    }
}

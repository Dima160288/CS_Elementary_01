using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_customer
{
    class Customer
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string address;
        private ulong cardNum; // наверное лучше было бы string но я хз как регулярные выражения делать
        private ulong accountNum; // -//-

        public string FirstName { get => firstName; }
        public string MiddleName { get => middleName; }
        public string LastName { get => lastName; }
        public string Address { get => address; }
        public ulong CardNum
        {
            get => cardNum;
            set
            {
                if (value > 0 && value.ToString().Length == 16)
                {
                    cardNum = value;
                }
            }
        }
        public ulong AccountNum
        {
            get => accountNum;
            set
            {
                if (value > 0 && value.ToString().Length == 16)
                {
                    accountNum = value;
                }
            }
        }

        public Customer(string firstName, string middleName, string lastName, string address, ulong cardNum, ulong accountNum)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.address = address;
            CardNum = cardNum;
            AccountNum = accountNum;
        }

        public void Show()
        {
            Console.WriteLine("Customer: ");
            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Middle name: {middleName}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Address: {address}");
            if (cardNum == 0)
            {
                Console.WriteLine("Credit card number: not available");
            }
            else
            {
                Console.WriteLine($"Credit card number: {cardNum}");
            }
            if (accountNum == 0)
            {
                Console.WriteLine("Bank account number: not available");
            }
            else
            {
                Console.WriteLine($"Bank account number: {accountNum}");
            }
        }

        public static void AlphabetSort(ref List<Customer> customers)
        {
            customers = customers.OrderBy(x => x.lastName).ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _18_subscriber
{
    class Subscriber
    {
        private int subId;
        private string firstName;
        private string middleName;
        private string lastName;
        private string address;
        private string cardNum;
        private double credit;
        private double debit;
        private TimeSpan intercityCallsTime;
        private TimeSpan insidecityCallsTime;

        public int SubId { get => subId; }
        public string FirstName { get => firstName; }
        public string MiddleName { get => middleName; }
        public string LastName { get => lastName; }
        public string Address { get => address; }
        public string CardNum { get => cardNum; }
        public double Credit { get => credit; }
        public double Debit { get => debit; }
        public TimeSpan IntercityCallsTime { get => intercityCallsTime; }
        public TimeSpan InsidecityCallsTime { get => insidecityCallsTime; }

        public Subscriber(int subId, string firstName, string middleName, string lastName, string address, string cardNum, double credit, double debit, TimeSpan intercityCallsTime, TimeSpan insidecityCallsTime)
        {
            this.subId = subId;
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.address = address;
            if (CardNumIsDigitsOnly(cardNum))
            {
                this.cardNum = cardNum;
            }
            this.debit = debit;
            this.credit = credit;
            this.intercityCallsTime = intercityCallsTime;
            this.insidecityCallsTime = insidecityCallsTime;
        }

        public static bool CardNumIsDigitsOnly(string a)
        {
            string pattern = @"\d{16}";
            if (Regex.IsMatch(a, pattern, RegexOptions.IgnorePatternWhitespace))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Show()
        {
            Console.WriteLine("Subscriber: ");
            Console.WriteLine($"Subscriber ID: {subId}");
            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Middle name: {middleName}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Address: {address}");
            if (cardNum == null)
            {
                Console.WriteLine("Credit card number: not available");
            }
            else
            {
                Console.WriteLine($"Credit card number: {cardNum}");
            }
            Console.WriteLine($"Debit: {debit}");
            Console.WriteLine($"Credit: {credit}");
            Console.WriteLine($"Intercity call time: {intercityCallsTime}");
            Console.WriteLine($"Inside city call time: {insidecityCallsTime}");
        }

        public static void ShowCityCallsMoreThan(List<Subscriber> subscribers,TimeSpan time)
        {
            subscribers = subscribers.Where(x => x.insidecityCallsTime > time).ToList();
            foreach (var item in subscribers)
            {
                item.Show();
                Console.WriteLine("---------------------------------------------");
            }
        }

        public static void ShowNoIntercity(List<Subscriber> subscribers)
        {
            subscribers = subscribers.Where(x => x.intercityCallsTime == new TimeSpan(0, 0, 0)).ToList();
            foreach (var item in subscribers)
            {
                item.Show();
                Console.WriteLine("---------------------------------------------");
            }
        }

        public static void SortByAlphabet(List<Subscriber> subscribers)
        {
            subscribers = subscribers.OrderBy(x => x.lastName).ToList();
            foreach (var item in subscribers)
            {
                item.Show();
                Console.WriteLine("---------------------------------------------");
            }
        }
    }
}

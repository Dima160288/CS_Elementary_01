using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_customer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer("John", "Paul", "Swift", "225 Rocky Road Philadelphia, PA 19103", 01234567895874527, 01234567895874527));
            customers.Add(new Customer("Donald", "James", "Doe", "4924 Kinney Street Ludlow, MA 01056", 01234567895874569, 01234567895874527));
            customers.Add(new Customer("Eugene", "Matthew", "Johnson", "3803 Meadow View Drive Litchfield, CT 06759", 01234567895874528, 01234567895874527));
            foreach (var item in customers)
            {
                item.Show();
                Console.WriteLine("---------------------------------------------");
            }
            Customer.AlphabetSort(ref customers);
            Console.WriteLine("****************************************************");
            foreach (var item in customers)
            {
                item.Show();
                Console.WriteLine("---------------------------------------------");
            }

            foreach (var item in customers)
            {
                if (item.CardNum > 01234567895874526 && item.CardNum < 01234567895874566)
                {
                    item.Show();
                }
            }
        }
    }
}

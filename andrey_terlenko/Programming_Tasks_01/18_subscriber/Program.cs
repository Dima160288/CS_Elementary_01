using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_subscriber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Subscriber> subscribers = new List<Subscriber>();
            subscribers.Add(new Subscriber(1, "John", "Paul", "Doe", "225 Rocky Road Philadelphia, PA 19103", "0123456789012345", 53.5, 0, new TimeSpan(1, 10, 0), new TimeSpan(5, 12, 36)));
            subscribers.Add(new Subscriber(2, "Mike", "D.", "Jackson", "225 Rocky Road Philadelphia, PA 19103", "0123456789012345", 53.5, 0, new TimeSpan(0, 0, 0), new TimeSpan(7, 12, 36)));
            subscribers.Add(new Subscriber(3, "David", "S.", "Garcia", "225 Rocky Road Philadelphia, PA 19103", "0123456789012345", 53.5, 0, new TimeSpan(3, 10, 0), new TimeSpan(1, 12, 36)));
            subscribers.Add(new Subscriber(4, "Robert", "E.", "Lee", "225 Rocky Road Philadelphia, PA 19103", "0123456789012345", 53.5, 0, new TimeSpan(2, 10, 0), new TimeSpan(3, 12, 36)));
            subscribers.Add(new Subscriber(5, "Paul", "John", "Smith", "225 Rocky Road Philadelphia, PA 19103", "0123456789012345", 53.5, 0, new TimeSpan(0, 0, 0), new TimeSpan(9, 12, 36)));
            subscribers.Add(new Subscriber(6, "Victor", "P.", "Ramirez", "225 Rocky Road Philadelphia, PA 19103", "0123456789012345", 53.5, 0, new TimeSpan(0, 0, 0), new TimeSpan(4, 12, 36)));

            Subscriber.ShowCityCallsMoreThan(subscribers, new TimeSpan(7, 0, 0));
            Console.WriteLine("*********************************************");
            Subscriber.ShowNoIntercity(subscribers);
            Console.WriteLine("*********************************************");
            Subscriber.SortByAlphabet(subscribers);                        
        }
    }
}

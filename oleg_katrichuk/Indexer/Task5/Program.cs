using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store(3);
            
            store.AddArticle(new Article("Milk", "Masha", 23),0);
            store.AddArticle( new Article("Bread", "Rose", 12),1);
            store.AddArticle(new Article("Butter", "ATB", 34),2);

            Console.WriteLine(store["Milk"]);
            Console.WriteLine(new string('-',30));

            Console.WriteLine(store["Oil"]);
            Console.WriteLine(new string('-', 30));

            Console.WriteLine(store[2]);
            Console.WriteLine(new string('-', 30));

            store.Show();
            Console.WriteLine(new string('-', 30));

            store.Sort();
            store.Show();

            Console.ReadLine();

        }
    }

}

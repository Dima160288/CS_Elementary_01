using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_HW005_4
{
    public class Article
    {
        private string name;
        private string store;
        private double price;
        public string Store { get { return store; } }
        public Article(string n, string s, double p)
        {
            name = n;
            store = s;
            price = p;
        }
        public void Show()
        {
            Console.WriteLine(string.Format("{0} in {1} costs {2}", name, store, price));
        }
    }
}

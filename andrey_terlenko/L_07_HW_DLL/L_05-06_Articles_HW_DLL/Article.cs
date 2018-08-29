using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_05_06_Articles_HW_DLL
{
    class Article
    {
        private string productName;
        private string storeName;
        private double price;

        public string StoreName { get { return storeName; } }

        public Article(string productName, string storeName, double price)
        {
            this.productName = productName;
            this.storeName = storeName;
            this.price = price;
        }

        public void ShowArticle()
        {
            Console.WriteLine(string.Format($"Product {productName} in store {storeName} costs {price}"));
        }
    }
}

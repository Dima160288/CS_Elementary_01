using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Article
    {
        public string NameProduct { get; set; } = null;
        public string NameShop { get; set; } = null;
        public double Price { get; set; } = 0.0;

        public Article(string nameProduct,string nameShop,double price)
        {
            NameProduct = nameProduct;
            NameShop = nameShop;
            Price = price;
        }

        public string Info()
        {
            return string.Format("{0} from {1} price is : {2} ",NameProduct,NameShop,Price);
        }
        
    }
}

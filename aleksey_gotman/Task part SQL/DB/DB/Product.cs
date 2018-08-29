using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Product
    {
        private int id;
        private string name;
        private string category;
        private string description;
        private double price;
        private double rate;
        private int count;

        public int Id { get { return id; } }
        public string Name { get { return name; } }
        public string Category { get { return category; } }
        public string Description { get { return description; } }
        public double Price { get { return price; } }
        public double Rate { get { return rate; } }
        public int Count { get { return count; } }

        public Product(int id, string name, string category, object description, int price, int rate, int count)
        {
            this.id = id;
            this.name = name;
            this.category = category;
            this.description = description.ToString();
            this.price = price / 100;
            this.rate = rate / 100;
            this.count = count;
        }
    }
}

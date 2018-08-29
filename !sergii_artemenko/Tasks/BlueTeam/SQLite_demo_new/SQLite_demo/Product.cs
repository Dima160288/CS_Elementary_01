using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLite_demo
{
    public class Product
    {
        //Category, Name, Description, Price, Rating, Quantity
        public int ID { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double Rating { get; set; }
        public int Quantity { get; set; }

        public Product() { }

        public Product(int id, string category, string name, string description, double price, double rating, int quantity)
        {
            ID = id;
            Category = category;
            Name = name;
            Description = description;
            Price = price;
            Rating = rating;
            Quantity = quantity;

        }

    }
}

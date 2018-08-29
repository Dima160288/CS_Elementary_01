using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueTeam
{
    class Goods
    {
        public string Name  { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public double Price { get; set; }
        public double  Rating { get; set; }

        public Goods() { }
        public Goods(string name, string description, int id, double price)
        {
            Name = name;
            Description = description;
            Id = id;
            Price = price;
            
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    public class Book
    {
        private string name;
        private string author;
        private int year;
        public string Name { get { return name; } }
        public string Author { get { return author; } }
        public int Year { get { return year; } }
        public Book(string name, string author, int year)
        {
            this.name = name;
            this.author = author;
            this.year = year;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_library
{
    class Book
    {
        private string title;
        private string author;

        public string Title { get => title; }
        public string Author { get => author; }

        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
        }
    }
}

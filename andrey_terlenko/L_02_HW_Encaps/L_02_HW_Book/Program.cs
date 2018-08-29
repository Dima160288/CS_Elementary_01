using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_02_HW_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Book ACOK = new Book();
            ACOK.Author = new Author("GRRM");
            ACOK.Title = new Title("A Clash of Kings");
            ACOK.Content = new Content("*add content*");

            ACOK.Author.Show();
            ACOK.Title.Show();
            ACOK.Content.Show();
        }
    }
}

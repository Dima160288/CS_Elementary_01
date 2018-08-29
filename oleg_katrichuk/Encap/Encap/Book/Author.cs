using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    class Author
    {
        private string author1;

        public string Author1
        {
            get { return author1; }
            set { author1 = value; }
        }

        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Author is : {0}", Author1);
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}

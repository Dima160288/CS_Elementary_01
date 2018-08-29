using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    class Title
    {
        private string title1;

        public string Title1
        {
            get { return title1; }
            set { title1 = value; }
        }

        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Title is : {0}", Title1);
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}

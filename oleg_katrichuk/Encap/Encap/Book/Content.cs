using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    class Content
    {
        private string content1;

        public string Content1
        {
            get { return content1; }
            set { content1 = value; }
        }

        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Content is : {0}", Content1);
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}

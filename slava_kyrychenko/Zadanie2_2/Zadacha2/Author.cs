using System;
using System.Collections.Generic;
using System.Text;

namespace Zadacha2
{
   public class Author
    {
        private string autor;

        public Author(string autor)
        {
            this.autor = autor;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Автор : {0}", autor);
            Console.ResetColor();
        }
    }
}

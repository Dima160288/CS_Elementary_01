using System;
using System.Collections.Generic;
using System.Text;

namespace Zadacha2
{
   public class Content
    {
        private string content;

       public Content(string content)
        {
            this.content = content;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Содержание : {0}", content);
            Console.ResetColor();
        }
    }
}

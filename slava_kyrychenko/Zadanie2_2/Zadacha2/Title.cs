using System;
using System.Collections.Generic;
using System.Text;

namespace Zadacha2
{
   public class Title
    {
        private string title;

       public Title(string title)
        {
            this.title = title;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green; 
            Console.WriteLine(" Оглавление  : {0}", title);
            Console.ResetColor();
        }
    }
}

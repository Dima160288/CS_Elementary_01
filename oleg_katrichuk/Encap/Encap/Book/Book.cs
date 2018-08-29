using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    class Book
    {
        Author aut=new Author();
        Title title =new Title();
        Content content=new Content();
        public Book()
        {
            Console.Write("Enter title : ");
            title.Title1 = Console.ReadLine();

            Console.Write("Enter author : ");
            aut.Author1 = Console.ReadLine();

            Console.Write("Enter content : ");
            content.Content1 = Console.ReadLine();
        }

        public void Show()
        {
            title.Show();
            aut.Show();
            content.Show();
        }
    }
}

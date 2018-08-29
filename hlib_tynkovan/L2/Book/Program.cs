using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{

    class Author
    {
        private string author;

        public Author(string author)
        {
            this.author = author;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Author: " + author);
            Console.ResetColor();
        }

    }


    class Title
    {
        private string title;
        public Title (string title)
        {
            this.title = title;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Title: " + title);
            Console.ResetColor();
        }
    }


    class Content
    {
        private string content;
        public Content (string content)
        {
            this.content = content;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Content: " + content);
            Console.ResetColor();
        }
    }

    class Book
    {
        public Author Author
        { get; set; }

        public Title Title
        { get; set; }

        public Content Content
        { get; set; }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book
            {
                Author = new Author("Виктор Пелевин"),
                Title = new Title("Generation P"),
                Content = new Content("О рекламе")
            };

            book.Author.Show();
            book.Title.Show();
            book.Content.Show();
            Console.ReadLine();
        }
    }
}

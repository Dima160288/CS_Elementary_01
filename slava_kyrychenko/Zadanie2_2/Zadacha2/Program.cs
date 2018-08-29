using System;

namespace Zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Author = new Author("About author");
            book.Content = new Content("Content book");
            book.Title = new Title("Title Book");

            book.Author.Show();
            book.Content.Show();
            book.Title.Show();

        }
    }
}

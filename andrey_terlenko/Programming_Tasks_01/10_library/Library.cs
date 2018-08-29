using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_library
{
    class Library
    {
        public static void ShowLibrary(List<Book> library)
        {
            foreach (var item in library)
            {
                Console.WriteLine($"Book {item.Title} by {item.Author}");
            }
        }

        public static void AddBook(List<Book> library, string title, string author)
        {
            library.Add(new Book(title, author));
        }

        public static void RemoveBook(List<Book> library, string title)
        {
            try
            {
                foreach (var item in library.ToArray())//в foreach нельзя менять коллекцию -> в массив
                {
                    if (item.Title == title)
                    {
                        library.Remove(item);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }            
        }

        public static void SortByTitle(ref List<Book> library)
        {
            library = library.OrderBy(x => x.Title).ToList();
        }

        public static void SortByAuthor(ref List<Book> library)
        {
            library = library.OrderBy(x => x.Author).ToList();
        }

        public static void FindBook(List<Book> library, string title)
        {
            foreach (var item in library)
            {
                if (item.Title == title)
                {
                    Console.WriteLine($"Book {item.Title} by {item.Author}");
                }
            }
        }
    }
}

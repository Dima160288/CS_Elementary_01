using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_library
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> library = new List<Book>();
            Library.AddBook(library, "1984", "George Orwell");
            Library.AddBook(library, "A Game Of Thrones", "George R.R. Martin");
            Library.AddBook(library, "Art Of War", "Sun Tzu");
            Library.AddBook(library, "The Gulag Archipelago", "Aleksandr Solzhenitsyn");

            Library.ShowLibrary(library);
            Library.RemoveBook(library, "1984");
            Console.WriteLine("---------------------------------------------");
            Library.ShowLibrary(library);
            Console.WriteLine("---------------------------------------------");
            Library.AddBook(library, "1984", "George Orwell");
            Library.ShowLibrary(library);
            Console.WriteLine("---------------------------------------------");
            Library.SortByAuthor(ref library);
            Library.ShowLibrary(library);
            Console.WriteLine("---------------------------------------------");
            Library.SortByTitle(ref library);
            Library.ShowLibrary(library);
            Console.WriteLine("---------------------------------------------");
            Library.FindBook(library, "Art Of War");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    /*Описать класс «домашняя библиотека». Предусмотреть возможность работы с произвольным числом книг, поиска книги по какому-либо признаку (например, по автору или по году издания), добавления книг в библиотеку, удаления книг из нее, сортировки книг по разным полям.*/
    public class T10
    {
    }
    public class Library
    {
        
        public List<Book> lib = new List<Book>();
        public void Show()
        {
            foreach (Book b in lib)
                Console.WriteLine("Name {0}, Author is {1}, Year {2}", b.Name, b.Author, b.Year);
        }
        public void Add(string name, string author, int year)
        {
            lib.Add(new Book(name, author, year));
            Show();
        }
        public void Remove(string name)
        {
            lib = lib.Where(x => x.Name != name).ToList();
        } 
        public void SortName()
        {
            lib = lib.OrderBy(x => x.Name).ToList();
        }
        public void SortAuthor()
        {
            lib = lib.OrderBy(x => x.Author).ToList();
        }
        public void SortYear()
        {
            lib = lib.OrderBy(x => x.Year).ToList();
        }
    }


}

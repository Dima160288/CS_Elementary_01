using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_incapsulation
{

    class Book
    {
        public void Show()
        {
            Title title = new Title();
            title.Show();
            Author author = new Author();
            author.Show();
            Content content = new Content();
            content.Show();
        }
    }
    class Title
    {
        public static string BookTitle { get; set; }

        public void Show()
        {
            Console.Write("Title: ");
            Console.WriteLine(BookTitle);
        }
    }
    class Author
    {
        public static string BookAuthor { get; set; }
        public void Show()
        {
            Console.Write("Author: ");
            Console.WriteLine(BookAuthor);
        }
    }
    class Content
    {
        public static string BookContent { get; set; }
        public void Show()
        {
            Console.Write("Content: ");
            Console.WriteLine(BookContent);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ////cоздать класс с именем Rectangle.
            ////В теле класса создать два поля, описывающие длины сторон double side1, side2.
            ////Создать пользовательский конструктор Rectangle(double side1, double side2), в теле которого поля side1 и side2 инициализируются значениями аргументов.
            ////Создать два метода, вычисляющие площадь прямоугольника - double AreaCalculator() и периметр прямоугольника - double PerimeterCalculator().
            ////Создать два свойства double Area и double Perimeter с одним методом доступа get.
            ////Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит на экран периметр и площадь.
            ////Инкапсулировать данные
            double side1, side2;
            Console.Write("Введите первую сторону прямоугольника: ");
            side1 = Double.Parse(Console.ReadLine());
            Console.Write("Введитевторую сторону прямоугольника: ");
            side2 = Double.Parse(Console.ReadLine());
            Rectangle rect = new Rectangle(side1, side2);
            rect.Display();

            //2 - Создать класс Book. Создать классы Title, Author и Content, каждый из которых должен содержать одно строковое поле и метод void Show().
            //Реализуйте возможность добавления в книгу названия книги, имени автора и содержания.
            //Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и содержание.
            //Инкапсулировать данные.
            Console.Write("Add Title: ");
            Title.BookTitle = Console.ReadLine();
            Console.Write("Add Author: ");
            Author.BookAuthor = Console.ReadLine();
            Console.Write("Add Content: ");
            Content.BookContent = Console.ReadLine();
            Console.Clear();
            Book book = new Book();
            book.Show();
           

        }
    }
}


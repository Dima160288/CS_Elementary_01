using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_HW002
{
     public static class InOut
    {
        /*Определить класс с именем Tea содержащую следующие поля: страна производитель; сорт чая; вес в упаковке; цена чая за 100 гр.
        методы: ввод данных в массив из n элементов в типа Tea;
                упорядочить по убыванию цены;
                вывод информации об объекте, страна производитель которого введена пользователем.*/
        // Start program from this method

        static void Main()
        {
            Console.WriteLine("GeometryCalc");
            Console.WriteLine("Enter \"help\" to view commands");
            for (string str = null; str != "exit";)
            {
                str = Console.ReadLine();
                switch (str)
                {
                    case "new":
                        {
                            NewFigure();
                            break;
                        }
                    case "calc":
                        {
                            Calculate();
                            break;
                        }
                    case "help":
                        {
                            Help();
                            break;
                        }
                    case "clear":
                        {
                            Console.Clear();
                            break;
                        }
                }
            }
        }

        static Figure figure;

        public static Point AddPoint()
        {
            try
            {
                Console.WriteLine("Enter coordinate X");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter coordinate Y");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter point name");
                string name = Console.ReadLine();
                Point p = new Point(x, y, name);
                Console.WriteLine("Point " + name + " added\n");
                return p;
            }
            catch { Console.WriteLine("Enter correct data"); return AddPoint(); }
        }

        public static void NewFigure()
        {
            Console.WriteLine("Our calculator can contain 3-5 points!");
            Console.WriteLine("Enter points count");
            try
            {
                int c = Convert.ToInt32(Console.ReadLine());
                switch (c)
                {
                    case 3:
                        {
                            figure = new Figure(AddPoint(), AddPoint(), AddPoint());
                            break;
                        }
                    case 4:
                        {
                            figure = new Figure(AddPoint(), AddPoint(), AddPoint(), AddPoint());
                            break;
                        }
                    case 5:
                        {
                            figure = new Figure(AddPoint(), AddPoint(), AddPoint(), AddPoint(), AddPoint());
                            break;
                        }
                    default:
                        {
                            throw new Exception();
                        }
                }
                Console.WriteLine("Figure " + figure.Name + " added\n");
            }
            catch
            {
                Console.WriteLine("Wrong points count\n");
                NewFigure();
            }
        }

        public static void Calculate()
        {
            try
            {
                Console.WriteLine("Figure " + figure.Name);
                figure.PerimeterCalculator();
                Console.WriteLine();
            }
            catch
            {
                Console.WriteLine("Please add figure\n");
            }
        }

        public static void Help()
        {
            Console.WriteLine("Enter \"new\" to create new figure");
            Console.WriteLine("Enter \"calc\" to calculate perimetr");
            Console.WriteLine("Enter \"clear\" to clear workspace");
            Console.WriteLine("Enter \"exit\" to exit\n");
        }
        
    }

}

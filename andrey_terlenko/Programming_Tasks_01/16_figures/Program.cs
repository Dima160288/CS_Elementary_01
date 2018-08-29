using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_figures
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Figure[] figures = new Figure[3];
                figures[0] = new Rectangle(10, 20);
                figures[1] = new Circle(15);                
                figures[2] = new Triangle(15, 6, 11);
                foreach (var item in figures)
                {
                    item.Show();
                    Console.WriteLine("---------------------------------------------");
                }                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}

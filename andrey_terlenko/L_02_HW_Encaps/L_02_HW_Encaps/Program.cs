using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_02_HW_Encaps
{
    class Program
    {
        static void Main(string[] args)
        {
            double side_1, side_2;

            try
            { 
                Console.Write("Enter side 1: ");
                side_1 = double.Parse(Console.ReadLine());
                Console.Write("Enter side 2: ");
                side_2 = double.Parse(Console.ReadLine());

                Rectangle rect = new Rectangle(side_1, side_2);

                Console.WriteLine(rect.Area);
                Console.WriteLine(rect.Perimeter);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}

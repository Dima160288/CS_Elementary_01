using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Triangle ABC = new Triangle(new TriangleCoord(1, 1), new TriangleCoord(5, 8), new TriangleCoord(-4, -1));
                ABC.Show();
                Console.WriteLine("Perimeter: " + ABC.Perimeter());
                Console.WriteLine("Area: " + ABC.Area());

                TriangleCoord MedCrosPt = Triangle.MedianCrossingPt(ABC);
                Console.Write("Median crossing point: ");
                MedCrosPt.Show();

                //Triangle WTF = new Triangle(new TriangleCoord(1, 1), new TriangleCoord(1, 1), new TriangleCoord(1, 1));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_triangle
{
    class Triangle
    {
        private TriangleCoord A;
        private TriangleCoord B;
        private TriangleCoord C;

        private double AB;
        private double BC;
        private double AC;

        public Triangle(TriangleCoord A, TriangleCoord B, TriangleCoord C)
        {
            if (A == B && A == C)
            {
                throw new Exception("Error: at least 1 point must be different");
            }
            else
            {
                this.A = A;
                this.B = B;
                this.C = C;
                AB = Math.Round(Math.Sqrt(Math.Pow((B.X - A.X), 2) + Math.Pow((B.Y - A.Y), 2)), 1);
                BC = Math.Round(Math.Sqrt(Math.Pow((C.X - B.X), 2) + Math.Pow((C.Y - B.Y), 2)), 1);
                AC = Math.Round(Math.Sqrt(Math.Pow((C.X - A.X), 2) + Math.Pow((C.Y - A.Y), 2)), 1);
            }            
        }

        public void Show()
        {
            Console.Write("A: ");
            A.Show();
            Console.Write("B: ");
            B.Show();
            Console.Write("C: ");
            C.Show();
            Console.WriteLine($"AB = {AB}, BC = {BC}, AC = {AC}");
        }

        public double Perimeter()
        {
            return AB + BC + AC;
        }

        public double Area()
        {
            double p = Perimeter() / 2; //half of perimeter
            return Math.Round(Math.Sqrt(p * (p - AB) * (p - BC) * (p - AC)), 2);
        }

        public static TriangleCoord MedianCrossingPt(Triangle ABC)
        {
            return new TriangleCoord(Math.Round((ABC.A.X + ABC.B.X + ABC.C.X) / 3, 1), Math.Round((ABC.A.Y + ABC.B.Y + ABC.C.Y) / 3, 1));
        }
    }
}

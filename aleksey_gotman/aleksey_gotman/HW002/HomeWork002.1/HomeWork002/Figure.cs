using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork002
{
    class Figure
    {
        private Point A;
        private Point B;
        private Point C;
        private Point D;
        private Point E;
        private Point[] figure;
        private string name;
        public string Name
        {
            get
            {
                foreach (Point p in figure)
                {
                    name += p.Name;
                }
                return name;
            }
        }
        

        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
            this.E = E;
            figure = new Point[5] { A, B, C, D, E };
        }

        public Figure(Point A, Point B, Point C, Point D)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
            figure = new Point[4] { A, B, C, D };
        }

        public Figure(Point A, Point B, Point C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            figure = new Point[3] { A, B, C };
        }

        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((A.X - B.X), 2) + Math.Pow((A.Y - B.Y), 2));
        }

        public void PerimeterCalculator()
        {
            double perimetr = 0;
            for (int i = 0; i < figure.Length - 1; i++)
            {
                if (i == 0)
                {
                    perimetr += LengthSide(figure[figure.Length - 1], figure[0]);
                }
                perimetr += LengthSide(figure[i], figure[i + 1]);
            }
            Console.WriteLine("Perimetr is " + perimetr);
        }

    }
}

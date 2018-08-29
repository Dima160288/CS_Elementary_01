using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_triangle
{
    struct TriangleCoord
    {
        private double x;
        private double y;

        public double X { get => x; }
        public double Y { get => y; }

        public TriangleCoord(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void Show()
        {
            Console.WriteLine($"{x}, {y}");
        }

        public override bool Equals(object obj)//?
        {
            if (!(obj is TriangleCoord))
            {
                return false;
            }

            var coord = (TriangleCoord)obj;
            return x == coord.x &&
                   y == coord.y &&
                   X == coord.X &&
                   Y == coord.Y;
        }

        public override int GetHashCode()//??
        {
            var hashCode = -624234986;
            hashCode = hashCode * -1521134295 + x.GetHashCode();
            hashCode = hashCode * -1521134295 + y.GetHashCode();
            hashCode = hashCode * -1521134295 + X.GetHashCode();
            hashCode = hashCode * -1521134295 + Y.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(TriangleCoord A, TriangleCoord B)
        {
            if (A.x == B.x && A.y == B.y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(TriangleCoord A, TriangleCoord B)
        {
            if (A.x != B.x)
            {
                return true;
            }
            else if (A.y != B.y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

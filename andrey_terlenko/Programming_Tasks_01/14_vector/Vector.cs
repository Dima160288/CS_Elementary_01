using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_vector
{
    class Vector
    {
        private int x;
        private int y;
        private int z;

        public int X { get => x; }
        public int Y { get => y; }
        public int Z { get => z; }

        public Vector(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.x + b.x, a.y + b.y, a.z + b.z);
        }

        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector(a.x - b.x, a.y - b.y, a.z - b.z);
        }

        public static double ScalarComposition(Vector a, Vector b)
        {
            return (a.x * b.x) + (a.y * b.y) + (a.z * b.z);
        }

        public double VectorLength()
        {
            return Math.Round(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2)), 2);
        }

        public static double AngleCos(Vector a, Vector b)
        {
            return Math.Round((ScalarComposition(a, b) / (a.VectorLength() * b.VectorLength())), 2);
        }

        public void Show()
        {
            Console.WriteLine($"Coords: {x}, {y}, {z}");
        }
    }
}

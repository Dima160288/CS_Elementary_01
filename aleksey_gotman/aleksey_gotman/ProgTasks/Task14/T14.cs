using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    /*Составить описание класса для вектора, заданного координатами его концов в трехмерном пространстве. Обеспечить операции сложения и вычитания векторов с получением нового вектора (суммы или разности), вычисления скалярного произведения двух векторов, длины вектора, косинуса угла между векторами.*/
    public class T14
    {
    }
    public class Vector
    {
        public Point A { get; }
        public Point B { get; }
        public double AV { get; }
        public double BV { get; }
        public double CV { get; }
        public Vector(int x1, int y1, int z1, int x2, int y2, int z2)
        {
            A = new Point(x1, y1, z1);
            B = new Point(x2, y2, z2);
            AV = x2 - x1;
            BV = y2 - y1;
            CV = z2 - z1;
        }
        public Vector(double a, double b, double c)
        {
            AV = a;
            BV = b;
            CV = c;
        }

        public static Vector operator +(Vector first, Vector second)
        {
            return new Vector(first.AV + second.AV, first.BV + second.BV, first.CV + second.CV);
        }
        public static Vector operator -(Vector first, Vector second)
        {
            return new Vector(first.AV - second.AV, first.BV - second.BV, first.CV - second.CV);
        }
        public static double operator *(Vector first, Vector second)
        {
            return first.AV * second.AV + first.BV * second.BV + first.CV * second.CV;
        }
        public int Angle(Vector first, Vector second)
        {
            return (int)(Math.Acos((first * second) / (first.Length * second.Length)) * 180 / Math.PI);
        }
        public double Length { get { return Math.Sqrt(Math.Pow(AV, 2) + Math.Pow(BV, 2) + Math.Pow(CV, 2)); } }
    }
    public struct Point
    {
        public int X { get; }
        public int Y { get; }
        public int Z { get; }
        public Point(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}

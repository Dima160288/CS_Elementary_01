using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_complex_numbers
{
    class ComplexNumber
    {
        private double realPart;
        private double imaginaryPart;
        private double mod;
        private double arg;
        private double angle;

        public double RealPart { get => realPart; }
        public double ImaginaryPart { get => imaginaryPart; }
        public double Mod { get => mod; }
        public double Arg { get => arg; }
        public double Angle { get => angle; }

        public ComplexNumber(double realPart, double imaginaryPart)
        {
            this.realPart = realPart;
            this.imaginaryPart = imaginaryPart;
            TrigonForm();
        }

        public void Show()
        {
            if (imaginaryPart < 0)
            {
                Console.WriteLine($"z = {realPart} + ({imaginaryPart})i");
            }
            else
            {
                Console.WriteLine($"z = {realPart} + {imaginaryPart}i");
            }
            Console.WriteLine($"z = |{mod}| * (cos({arg}) + i * sin({arg}))");
            Console.WriteLine($"z = |{mod}|*e^(i*{arg})");
        }

        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber((a.realPart + b.realPart), (a.imaginaryPart + b.imaginaryPart));
        }

        public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber((a.realPart - b.realPart), (a.imaginaryPart - b.imaginaryPart));
        }

        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(((a.realPart * b.realPart) - (a.imaginaryPart * b.imaginaryPart)), ((a.imaginaryPart * b.realPart) + (a.realPart * b.imaginaryPart)));
        }

        public static ComplexNumber operator /(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber((((a.realPart * b.realPart) + (a.imaginaryPart * b.imaginaryPart)) / (Math.Pow(b.realPart, 2) + Math.Pow(b.imaginaryPart, 2))), (((b.realPart * a.imaginaryPart) - (a.realPart * b.imaginaryPart)) / (Math.Pow(b.realPart, 2) + Math.Pow(b.imaginaryPart, 2))));
        }

        public static ComplexNumber Conjugate(ComplexNumber a)
        {
            return new ComplexNumber(a.realPart, -a.imaginaryPart);
        }

        public void TrigonForm()
        {
            mod = Math.Sqrt(Math.Pow(realPart, 2) + Math.Pow(imaginaryPart, 2));
            arg = Math.Atan(imaginaryPart / realPart);
            angle = (double)(arg * 180 / Math.PI);
        }

        public ComplexNumber Exponentiation(int power)
        {
            return new ComplexNumber(Math.Pow(realPart, power), Math.Pow(angle, power));
        }

        public ComplexNumber[] SquareRoot(int power)
        {
            ComplexNumber[] res = new ComplexNumber[power];
            for (int i = 0; i < power; i++)
            {
                res[i] = new ComplexNumber(Math.Pow(mod, 1 / i), angle + 180 * i * 2);
            }
            return res;
        }
    }
}

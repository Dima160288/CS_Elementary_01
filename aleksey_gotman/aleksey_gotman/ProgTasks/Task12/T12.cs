using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    /*Создать класс для хранения комплексных чисел. Реализовать операции над комплексными числами: сложение, вычитание, умножение, деление, сопряжение, возведение в степень, извлечение корня. Предусмотреть возможность изменения формы записи комплексного числа: алгебраическая форма, тригонометрическая форма, экспоненциальная форма.*/
    public class T12
    {

    }
    public class ComplexNumber
    {
        double a;
        double b;
        double z;
        double u;
        int angle;
        public ComplexNumber(double a, double b)
        {
            this.a = a;
            this.b = b;
            ToTrigon();
        }
        public ComplexNumber(double z, int angle)
        {
            this.z = z;
            this.angle = angle;
            ToAlg();
        }
        void ToAlg()
        {
            u = angle * Math.PI / 180;
            a = z * Math.Cos(u);
            b = z * Math.Sin(u);
        }
        void ToTrigon()
        {
            z = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            u = Math.Atan(b / a);
            angle = (int)(u * 180 / Math.PI);
        }
        
        public void Show()
        {
            Console.WriteLine("z = {a} + {b}i", a, b);
            Console.WriteLine("z = |{0}| * (cos({1}) + i * sin({1}))", z, u);
            Console.WriteLine("z = |{0}|*e^(i*{1})", z , u);
        }
        public static ComplexNumber operator + (ComplexNumber x, ComplexNumber y)
        {
            return new ComplexNumber(x.a + y.a, x.b + y.b);
        }
        public static ComplexNumber operator - (ComplexNumber x, ComplexNumber y)
        {
            return new ComplexNumber(x.a - y.a, x.b - y.b);
        }
        public static ComplexNumber operator * (ComplexNumber x, ComplexNumber y)
        {
            return new ComplexNumber( x.a*y.a + x.b*y.b*(-1), x.a * y.b + x.b * y.a);
        }
        public static ComplexNumber operator / (ComplexNumber x, ComplexNumber y)
        {
            ComplexNumber c = x * Interfacing(y);
            double del = Math.Pow(y.a, 2) - Math.Pow(y.b, 2) * (-1);
            return new ComplexNumber(c.a / del, c.b / del);
        }
        public static ComplexNumber Interfacing(ComplexNumber x)
        {
            return new ComplexNumber(x.a, x.b * (-1));
        }
        public ComplexNumber Pow(int i)
        {
            return new ComplexNumber(Math.Pow(a, i), Math.Pow(angle, i));
        }
        public ComplexNumber[] Sqr(int sqr)
        {
            ComplexNumber[] buf = new ComplexNumber[sqr];
            for (int i = 0; i < sqr; i++)
            {
                buf[i] = new ComplexNumber(Math.Pow(z, 1 / i),angle +180*i*2);
            }
            return buf;
        }
    }
}

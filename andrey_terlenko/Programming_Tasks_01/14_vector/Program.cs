using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_vector
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector test = new Vector(2, 4, 6);
            test.Show();
            Console.WriteLine("Length: ~ " + test.VectorLength());
            Console.WriteLine("---------------------------------------------");
            Vector qwerty = new Vector(-6, 1, 2);
            qwerty.Show();
            Console.WriteLine("Length: ~ " + qwerty.VectorLength());
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Scalar composition: " + Vector.ScalarComposition(test, qwerty));
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Cosine of angle between the vectors: " + Vector.AngleCos(test, qwerty));
        }
    }
}

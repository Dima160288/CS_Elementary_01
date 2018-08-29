using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task8;

namespace ProgTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Polynomial p = new Polynomial(new int[] { 2, 3, 5 }, 2);
            p.Show();
            
            Console.ReadLine();
        }
    }
}

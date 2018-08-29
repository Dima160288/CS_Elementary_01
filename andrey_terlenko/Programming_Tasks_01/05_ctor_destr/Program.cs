using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ctor_destr
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassWDestr<int, string> test = new ClassWDestr<int, string>();
            test.Show();

            ClassWDestr<int, string> test_1 = new ClassWDestr<int, string>(10, "fuck");
            test_1.Show();

        }
    }
}

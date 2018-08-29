using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_time
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Time test = new Time(15);
                test.Show();
                test.ChangeSec(30);
                test.Show();
                test.ChangeMin(25);
                test.Show();
                //test.ChangeMin(90);
                test.AddSec(25);
                test.Show();
                test.AddSec(10);
                test.Show();
                test.AddMin(30);
                test.Show();
                test.AddMin(10);
                test.Show();
                test.AddHr(7);
                test.Show();
                test.AddHr(7);
                test.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}

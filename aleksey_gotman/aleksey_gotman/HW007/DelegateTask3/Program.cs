using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTask3
{
    class Program
    {
        public delegate double AVG(Delegate[] del);
        public delegate int Number();
        public static int Randomizer()
        {
            Random r = new Random();
            return r.Next();
        }
        static void Main(string[] args)
        {

            Delegate[]  delegates = new Delegate[] { new Number(Randomizer), new Number(Randomizer), new Number(Randomizer), new Number(Randomizer), new Number(Randomizer), new Number(Randomizer), new Number(Randomizer), new Number(Randomizer), new Number(Randomizer), new Number(Randomizer) };
            AVG avg = (del) =>
            {
                double avgDel = 0;
                for (int i = 0; i < del.Length; i++)
                    avgDel = avgDel + (Int32)del[i].DynamicInvoke();
                return avgDel/del.Length;
            };
            Console.WriteLine(avg.Invoke(delegates));
            Console.ReadLine();
        }
    }
}

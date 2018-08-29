using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task6_DynamicArr;

namespace Task6_DynamicArr
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicArr arr = new DynamicArr(5);
            arr.FillArrRandom(5,100);
            arr.ShowArr();

            arr.NewSize(10);
            arr.ShowArr();

            arr.SummOfElements(1, 5);

            arr.RandomizePosition();
            arr.ShowArr();
            
            Console.ReadLine();
        }
    }
}

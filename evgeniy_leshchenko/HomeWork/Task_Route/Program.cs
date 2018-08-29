using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Route
{
    class Program
    {
        static void Main(string[] args)
        {

            int ArrSize;

            Console.WriteLine("Enter the number of routes: ");
            ArrSize = Convert.ToInt32(Console.ReadLine());

            Route TestRoutes = new Route(ArrSize);

            Route[] routes = new Route[ArrSize];

            TestRoutes.FillRoutesArr(routes);
            Console.Clear();
            TestRoutes.ShowRoutesArr(routes);

            Console.WriteLine("\nSorted Array by RouteID: \n");

            TestRoutes.SortArr(routes);
            TestRoutes.ShowRoutesArr(routes);

            Console.WriteLine("\n\nEnter Start or End Point for finding in Routes:");
            TestRoutes.FndPointName(routes, Console.ReadLine());


            Console.ReadLine();
        }
    }
}

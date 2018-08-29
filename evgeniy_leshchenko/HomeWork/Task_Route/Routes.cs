using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*5.	Определить класс с именем Route, содержащую следующие 
 * поля: название начального пункта; название конечного пункта; номер маршрута.
методы:
ввод данных в массив из n элементов в типа Route;
вывод информации о маршрутах, которые начинаются или заканчиваются в пункте, название которого ввел пользователь.
упорядочить по возрастанию номера маршрута;*/

namespace Task_Route

{
    class Route : IComparable<Route>
    {

        private string StartPoint { get; set; }
        private string EndPoint { get; set; }
        private int RouteID { get; set; }
        private int ArrSize { get; set; }

        public Route()
        {

        }

        public Route(int ArrSize)
        {
            this.ArrSize = ArrSize;
        }

        public Route(int RouteID, string StartPoint, string EndPoint)
        {

            this.RouteID = RouteID;
            this.StartPoint = StartPoint;
            this.EndPoint = EndPoint;
        }

        public int CompareTo(Route r)
        {
            return this.RouteID.CompareTo(r.RouteID);
        }


        public void FillRoutesArr(Route[] routesArr)
        {

            for (int i = 0; i<ArrSize; i++)
            {

                Console.Clear();

                Console.WriteLine("Enter information for Route № {0} \nEnter RouteID: ",i+1);
                RouteID = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Enter Start Point: ");
                StartPoint = Console.ReadLine();

                Console.WriteLine("Enter End Point: ");
                EndPoint = Console.ReadLine();

                routesArr[i] = new Route(RouteID, StartPoint, EndPoint);
                
            }
        }

        public void ShowRoutesArr(Route[] routesArr)
        {
            //Console.Clear();
            Console.WriteLine("Routes Array: \n\n");
            foreach (Route rt in routesArr)
                Console.WriteLine("RouteID: {0}  ||| Start Point: {1} ||| End Point: {2} ", rt.RouteID, rt.StartPoint, rt.EndPoint);
        }

        public void FndPointName(Route[] routesArr, string PointName)
        {

            PointName = PointName.ToLower();

            foreach (Route rt in routesArr)
            {
                if (rt.StartPoint.ToLower() == PointName || rt.EndPoint.ToLower() == PointName)
                Console.WriteLine("RouteID: {0}  ||| Start Point: {1} ||| End Point: {2} ", rt.RouteID, rt.StartPoint, rt.EndPoint);
            }

        }

        public void SortArr(Route[] routesArr)
        {
            Array.Sort(routesArr);
        }

    }
}

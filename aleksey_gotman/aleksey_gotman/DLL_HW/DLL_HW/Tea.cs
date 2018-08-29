using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_HW
{
    public class Tea
    {
        public string country { get; set; }
        public string brand { get; set; }
        private int weight;
        public int Weight
        {
            get { return weight; }
            set
            {
                if (value < 1) throw new Exception();
                else weight = value;
            }
        }
        private double price;
        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0.01) throw new Exception();
                else price = value;
            }
        }
        public static List<Tea> list = new List<Tea>();


        public static void SortTea()
        {
            list = list.OrderBy(a => a.price).ToList<Tea>();
        }

        public static List<Tea> Info(string searchCountry)
        {
            List<Tea> infoList = list.FindAll((a => a.country == searchCountry));
            return infoList;
        }

    }
}

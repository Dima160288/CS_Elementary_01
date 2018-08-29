using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Определить класс с именем Tea содержащую следующие поля: страна производитель; сорт чая; вес в упаковке; цена чая за 100 гр.
        методы: ввод данных в массив из n элементов в типа Tea;
                упорядочить по убыванию цены;
                вывод информации об объекте, страна производитель которого введена пользователем.*/
namespace HomeWork001
{
    class Tea
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork001
{
    class Program
    {
        public static void Create()
        {
            try
            {
                Tea tea = new Tea();
                Console.WriteLine("Enter manufacturer country");
                tea.country = Console.ReadLine();
                Console.WriteLine("Enter brand of tea");
                tea.brand = Console.ReadLine();
                Console.WriteLine("Enter weight per package");
                tea.Weight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter prise of 100gr");
                tea.Price = Convert.ToDouble(Console.ReadLine());
                Tea.list.Add(tea);
            }
            catch
            {
                Console.WriteLine("Enter correct data");
                Create();
            }
        }
        public static void SrchTea()
        {
            Console.WriteLine("Enter manufacturer country");
            List<Tea> teaList = Tea.Info(Console.ReadLine());
            foreach (Tea tea in teaList)
            {
                Console.WriteLine("Brand: "+ tea.brand + ". Weight per package:" + tea.Weight + ". Price of 100gr: " + tea.Price);
            }
        }

        public static void TeaList()
        {
            
            foreach (Tea tea in Tea.list)
            {
                Console.WriteLine("Manufacturer country: " + tea.country + ". Brand: " + tea.brand + ". Weight per package:" + tea.Weight + ". Price of 100gr: " + tea.Price);
            }
        }

        public static void Help()
        {
            Console.WriteLine("Enter \"new\" to add new tea");
            Console.WriteLine("Enter \"sort\" to sort tea list on price");
            Console.WriteLine("Enter \"info\" to view full tea list");
            Console.WriteLine("Enter \"search\" to find tea on manufacturer country");
            Console.WriteLine("Enter \"exit\" to close window");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Tea Land");
            Console.WriteLine("Enter \"help\" to view command");
            for (string s = ""; s != "exit";)
            {
                s = Console.ReadLine();
                switch (s)
                {
                    case "new":
                        Create();
                        break;
                    case "sort":
                        Tea.SortTea();
                        break;
                    case "info":
                        TeaList();
                        break;
                    case "search":
                        SrchTea();
                        break;
                    case "help":
                        Help();
                        break;
                }
                    
            }
                
        }
    }
}

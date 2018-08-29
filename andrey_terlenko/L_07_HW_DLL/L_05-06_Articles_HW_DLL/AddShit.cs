using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_05_06_Articles_HW_DLL
{
    static class AddShit
    {
        public static Article AddNewArticle()
        {
            try
            {
                Console.WriteLine("Enter article name:");
                string productName = Console.ReadLine();
                Console.WriteLine("Enter store name:");
                string storeName = Console.ReadLine();
                Console.WriteLine("Enter price:");
                double price = Convert.ToDouble(Console.ReadLine());
                return new Article(productName, storeName, price);
            }
            catch
            {
                Console.WriteLine("Incorrect data.");
                return AddNewArticle();
            }
        }

        public static Store AddNewStore()
        {
            int n = 0;
            try
            {
                Console.WriteLine("Enter number of articles:");
                n = Convert.ToInt32(Console.ReadLine());
                Store s = new Store(n);
                for (int i = 0; i < n; i++)
                {
                    s[i] = AddNewArticle();
                }
                return s;
            }
            catch
            {
                Console.WriteLine("Incorrect data.");
                return AddNewStore();
            }
        }

        public static void ShowIndexInfo(Store s)
        {
            try
            {
                Console.WriteLine("Enter index:");
                int index = Convert.ToInt32(Console.ReadLine());
                s[index - 1].ShowArticle();
            }
            catch
            {
                Console.WriteLine("Incorrect data.");
            }
        }

        public static void ShowNameInfo(Store s)
        {
            try
            {
                Console.WriteLine("Enter article name:");
                int count = 0;
                string str = Console.ReadLine();
                for (int i = 0; i < s.indexArticle; i++)
                {
                    if (str == s[i].StoreName)
                    {
                        s[i].ShowArticle();
                        count++;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine("No matches found");
                } 
            }
            catch
            {
                Console.WriteLine("Incorrect data.");
            }
        }
    }
}

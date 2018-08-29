using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_HW005_4
{
   public static class InOut
    {
        // Start program from this method
        static void Main()
        {
            Console.WriteLine("Store");
            Console.WriteLine("Enter \"help\" to veiw commands");
            string ex = null;
            Store s = null;
            while (ex != "exit")
            {
                ex = Console.ReadLine();

                switch (ex)
                {
                    case "addst":
                        {
                            s = Input.AddNewStore();
                            break;
                        }
                    case "showin":
                        {
                            Input.ShowIndexInfo(s);
                            break;
                        }
                    case "shown":
                        {
                            Input.ShowNameInfo(s);
                            break;
                        }
                    case "help":
                        {
                            Console.WriteLine("Enter \"addst\" to add new store");
                            Console.WriteLine("Enter \"showin\" to search article info on index");
                            Console.WriteLine("Enter \"shown\" to search article info on store");
                            Console.WriteLine("Enter \"exit\" to exit programm");
                            break;
                        }


                }
            }

        }
    }
    static class Input
    {
        public static Article AddNewArticle()
        {
            try
            {
                Console.WriteLine("Enter article name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter storage:");
                string store = Console.ReadLine();
                Console.WriteLine("Enter price:");
                double price = Convert.ToDouble(Console.ReadLine());
                return new Article(name, store, price);
            }

            catch
            {
                Console.WriteLine("Enter correct data!!");
                return AddNewArticle();
            }
        }
        public static Store AddNewStore()
        {
            int n = 0;
            try
            {
                Console.WriteLine("Enter count of article:");
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
                Console.WriteLine("Enter correct data!");
                return AddNewStore();
            }
        }
        public static void ShowIndexInfo(Store s)
        {
            try
            {
                Console.WriteLine("Enter index:");
                int ind = Convert.ToInt32(Console.ReadLine());
                s[ind - 1].Show();
            }
            catch { Console.WriteLine("Incorrect data."); }
        }
        public static void ShowNameInfo(Store s)
        {
            try
            {
                Console.WriteLine("Enter article name:");
                int count = 0;
                string str = Console.ReadLine();
                for (int i = 0; i < s.n; i++)
                {
                    if (str == s[i].Store)
                    {
                        s[i].Show();
                        count++;
                    }
                }
                if (count == 0) Console.WriteLine("No matches found");
            }
            catch { Console.WriteLine("Incorrect data."); }
        }

    }
}

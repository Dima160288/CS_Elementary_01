using DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CRUD.ConnectionOpen();
            bool s = CRUD.Login("1@gmail.com", "1");
            Console.WriteLine(s);
            CRUD.GetProductsData();
            CRUD.ChangeCount(new int[] { 6 },new int[] { 123 });
            Console.ReadLine();
        }
    }
}

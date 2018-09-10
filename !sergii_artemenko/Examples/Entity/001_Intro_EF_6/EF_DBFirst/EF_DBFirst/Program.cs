using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DBFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDBEntities contextEntities = new MyDBEntities();

            List<Table> list = contextEntities.Tables.ToList();

            foreach (Table item in list)
            {
                Console.WriteLine($"{item.Id}.{item.FirstName} - {item.LastName} {item.Age}");
            }

            Console.ReadLine();
        }
    }
}

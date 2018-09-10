using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_EF
{
    class Program
    {
        static void Main(string[] args)
        {
            MyModel context = new MyModel();
            var list = context.PersonalInfos.ToList();
            context.PersonalInfos.Add(new PersonalInfo { FirstName = "Serh" });
            context.SaveChanges();

            foreach (var item in list)
            {
                Console.WriteLine($"{item.ID}.{item.FirstName}");
            }
        }
    }
}

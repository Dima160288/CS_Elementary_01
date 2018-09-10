using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_CodeSecond_EF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Model1 model = new Model1())
            {
                var list = model.PersonalInfoes.ToList();
                foreach (var item in list)
                {
                    Console.WriteLine($"{item.ID} {item.FirstName}");
                }
            }
        }
    }
}

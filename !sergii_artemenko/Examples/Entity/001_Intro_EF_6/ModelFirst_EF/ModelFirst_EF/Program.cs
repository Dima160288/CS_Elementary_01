using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirst_EF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyModelContainer db = new MyModelContainer())
            {
                db.PersonalInfoes.Add(new PersonalInfo
                {
                    FirstName = "Serhii",
                    LastName = "Artemenko",
                    Age = 32
                });

                db.PersonalInfoes.Add(new PersonalInfo
                {
                    FirstName = "Ivan",
                    LastName = "Ivanov",
                    Age = 35
                });

                db.SaveChanges();

                var list = db.PersonalInfoes.ToList();

                foreach (var item in list)
                {
                    Console.WriteLine($"{item.Id}.{item.FirstName} - {item.LastName} {item.Age}");
                }

                Console.ReadLine();
            }
            
        }
    }
}

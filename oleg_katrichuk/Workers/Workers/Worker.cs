using System;
using System.Collections.Generic;
using System.Linq;

namespace Workers
{
    class Worker
    {
        public string Name { get; set; }
        public int YearToGo { get; set; }
        public string Positiom { get; set; }

        public static List<Worker> Workers = new List<Worker>();
        public void InfoWorker()
        {
            try
            {
                var worker = new Worker();
                Console.Write("Enter name : ");
                worker.Name = Console.ReadLine();
                Console.Write("Enter position : ");
                worker.Positiom = Console.ReadLine();
                Console.Write("Enter year : ");
                worker.YearToGo = Convert.ToInt32(Console.ReadLine());
                Workers.Add(worker);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " Enter correct infomation");
                InfoWorker();
            }

        }

        public static void SortedWorker()
        {
            var sortedName = from temp in Workers
                             orderby temp.Name
                             select temp;
            Console.WriteLine("Sorted List : ");
            Console.WriteLine();
            foreach (var tempWorker in sortedName)
            {
                Console.Write(tempWorker.Name + "\t\t\t " + tempWorker.Positiom + "\t\t\t " + tempWorker.YearToGo);
                Console.WriteLine();
            }
        }

        public static void OldWorker()
        {
            var sortedName = from temp in Workers
                             orderby temp.Name
                             select temp;
            Console.Write("Enter work experience : ");
            int experience = Convert.ToInt32(Console.ReadLine());
            foreach (var temp in sortedName)
            {
                if (experience < DateTime.Now.Year - temp.YearToGo)
                    Console.Write(temp.Name + "\t\t\t " + temp.Positiom + "\t\t\t " + temp.YearToGo + "\n");
            }
        }

    }
}

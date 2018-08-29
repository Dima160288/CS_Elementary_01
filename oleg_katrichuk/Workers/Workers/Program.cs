using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workers;

namespace Workers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("If you wont go out enter \"Y\" or enter any letters ");
                string str = Console.ReadLine();
                if (str != null && str.ToUpper() == "Y") break;
                Worker worker = new Worker();
                worker.InfoWorker();               
                
            }
            Console.Clear();
           
            foreach (var tempWorker in Worker.Workers)
            {
                Console.Write(tempWorker.Name + "\t\t\t " + tempWorker.Positiom + "\t\t\t " + tempWorker.YearToGo+"\n");                
            }
            
            Console.WriteLine();
            Worker.SortedWorker();
            Console.WriteLine();
            Worker.OldWorker();
            Console.ReadLine();
        }
    }
}

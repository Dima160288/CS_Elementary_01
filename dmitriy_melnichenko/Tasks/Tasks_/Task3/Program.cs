using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Train
    {
        private string destination;
        private int trainNumber;
        private DateTime time;        

        public int TrainNum { get => trainNumber; set => trainNumber = value; }
        public string Destination { get => destination; set => destination = value; }
        public DateTime Time { get => time; set => time = value; }

        public int setTrainNumber()
        {
            Random random = new Random();
            TrainNum = random.Next(1, 100);
            return TrainNum;
        }
        public DateTime dateTimeAdd()
        {            
            Random random = new Random();
            Time = new DateTime(random.Next(DateTime.Now.Year, 2020), random.Next(1, 13), random.Next(1, 31), random.Next(0, 25), random.Next(0, 60), random.Next(0, 60));            
            return Time;
        }

        public Train ()
        {
            string destination;
            Console.Write("Enter destination:");
            destination = Console.ReadLine();
            this.Destination = destination;
            this.TrainNum = setTrainNumber();
            this.Time = dateTimeAdd();
        }
    }
    
    class Program
    {   

        static Train[] SortingByNumbers(Train[] trains){return trains.OrderBy(x => x.TrainNum).ToArray();}
        static Train[] SortingByDestination(Train[] trains){return trains.OrderBy(x => x.Destination).ToArray().GroupBy(x => x.Time).SelectMany(x => x).ToArray();}

        static void Main(string[] args)
        {
            Train[] trains = new Train[5];
            for (int i = 0; i < trains.Length; i++)
            {
                trains[i] = new Train();
            }
        void FindTrain()
            {
                int findTrain;
                Console.WriteLine("Enter № of Train to find: ");
                findTrain = int.Parse(Console.ReadLine());
                for (int i = 0; i < trains.Length; i++)
                {                                       
                    if (findTrain == trains[i].TrainNum)
                    {
                        Console.WriteLine(trains[i].Destination + " is arriving at " + trains[i].Time);
                    }
                }
                FindTrain();
            }
        Console.ReadLine();
        }
    }
}

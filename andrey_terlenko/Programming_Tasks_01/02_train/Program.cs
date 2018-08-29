using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_train
{
    struct train
    {
        private string destination;
        private int trainNum;
        private DateTime departureTime;

        public string Destination { get => destination; }
        public int TrainNum { get => trainNum; }
        public DateTime DepartureTime { get => departureTime; }

        public train(string destination, int trainNum, DateTime departureTime)
        {
            this.destination = destination;
            this.trainNum = trainNum;
            this.departureTime = departureTime;
        }
    }

    class Program
    {
        static void ShowArrTrains(train[] trains)
        {
            foreach (var item in trains)
            {
                Console.WriteLine($"Train {item.TrainNum} departs to {item.Destination} on {item.DepartureTime}");
            }
        }

        static DateTime EnterDateTime()
        {
            DateTime departureTime;

            Console.Write("Enter month:");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter day:");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter hour:");
            int hour = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter minute:");
            int minute = Convert.ToInt32(Console.ReadLine());

            departureTime = new DateTime(DateTime.Now.Year, month, day, hour, minute, 00);

            return departureTime;
        }

        static void ShowTrainInfoByNum(train[] trains, int trainNum)
        {
            foreach (var item in trains)
            {
                if (trainNum == item.TrainNum)
                {
                    Console.WriteLine($"Match: Train {item.TrainNum} departs to {item.Destination} on {item.DepartureTime}");
                }
            }
        }

        static train[] FillTrainsArr(train[] trains)
        {
            string destination;
            int trainNum;

            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine($"Train #{i + 1}:");
                Console.Write("Enter destination:");
                destination = Console.ReadLine();
                Console.Write("Enter train number:");
                trainNum = Convert.ToInt32(Console.ReadLine());
                try
                {
                    DateTime departureTime = EnterDateTime();

                    trains[i] = new train(destination, trainNum, departureTime);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    DateTime departureTime = EnterDateTime();
                    trains[i] = new train(destination, trainNum, departureTime);
                }
            }
            return trains;
        }

        static train[] SortByTrainNum(train[] trains)
        {
            Console.WriteLine("Sorted by train №:");
            return trains.OrderBy(x => x.TrainNum).ToArray();
            
        }

        static train[] SortByDestination(train[] trains)
        {
            Console.WriteLine("Sorted by destination:");
            return trains.OrderBy(x => x.Destination).ToArray().GroupBy(x => x.DepartureTime).SelectMany(x => x).ToArray();
        }        

        static void Main(string[] args)
        {
            train[] trains = new train[3];

            FillTrainsArr(trains);
            ShowArrTrains(trains);
            ShowArrTrains(SortByTrainNum(trains));
        }
    }
}

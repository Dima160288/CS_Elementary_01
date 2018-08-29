using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task2
{

    //2.	Создайте структуру с именем train, содержащую поля: название пункта назначения, номер поезда, 
    //    время отправления.Ввести данные в массив из пяти элементов типа train, упорядочить элементы 
    //    по номерам поездов.
    // Добавить возможность вывода информации о поезде, номер которого введен пользователем.
    //    Добавить возможность сортировки массив по пункту назначения, причем поезда с одинаковыми 
    //    пунктами назначения должны быть упорядочены по времени отправления.

    struct Train : IComparable<Train>
    {
        public int CompareTo(Train s)
        {
           int result;
            result = this.pointName.CompareTo(s.pointName);
            // Если CompareTo видит одинаковые значения то он вернет 0. Если первое меньше то -1 если больше то 1.
            // Если ID совпадают то сравниваем по времени прибытия.
            if (result == 0)
            {
                result = this.timeDepart.CompareTo(s.timeDepart);
            }

           return result;

        }

        private string pointName;
        private int trainID;
        private DateTime timeDepart;

        // свойства только с геттерами
        public string PointName
        {
            get { return pointName; }
        }

        public int TrainID
        {
            get { return trainID; }
        }

        public DateTime TimeDepart
        {
            get { return timeDepart; }
        }

        // Пользовательский конструктор
        public Train(string pointName, int trainID, DateTime timeDepart)
        {
            this.pointName = pointName;
            this.trainID = trainID;
            this.timeDepart = timeDepart; 
        }

    }



    class Program
    {

        static void Main(string[] args)
        {
            Train[] arrTrains = new Train[5];
            //Random rnd = new Random();

            FillArr(arrTrains);
            Console.WriteLine("\nИзначальный массив: \n");
            ShowArr(arrTrains);

            Console.WriteLine("\n\nВыводим отсортированый массив по TraindID: \n");
            Array.Sort(arrTrains, new Comparison<Train>((a, b) => a.TrainID.CompareTo(b.TrainID)));
            ShowArr(arrTrains);


            // Используется IComparable и прописаный в структуре CompareTo
            Array.Sort(arrTrains);
            Console.WriteLine("\n\nВыводим отсортированый массив по PointName, TimeDepart:  \n");
            ShowArr(arrTrains);

            ShowTrainInfo(arrTrains);


            //ShowGoodStudents(arrTrudents);

            //Console.WriteLine("\n\n\nSorted students by AVG marks: ");

            //ShowArr(arrTrudents);

            Console.ReadKey();
        }

        static DateTime RandomDay()
        {

            int range = 0;
            Random rnd = new Random();
            DateTime start = new DateTime(2018, 7, 1);
             range = (DateTime.Today - start).Days;
            // рандомим время
            start = start.AddMinutes(rnd.Next(1000));
            Thread.Sleep(500);

            return start.AddDays(rnd.Next(range));
        }


        private static void FillArr(Train[] arrTr)
        {

            Random rand = new Random();

            for (int i = 0; i < arrTr.Length; i++)
            {
                arrTr[i] = new Train("PointName" + rand.Next(1,3), rand.Next(1, 11), RandomDay());
            }

            

        }

        private static void ShowArr(Train[] arrTr)
        {
            
            foreach (Train tr in arrTr)
            {
                Console.WriteLine("PointName: " + tr.PointName + " TrainID: " + Convert.ToString(tr.TrainID) + " TimeDepart: " + tr.TimeDepart);

            }
        }

        private static void ShowTrainInfo(Train[] arrTr)
        {
            int TrainID;

            Console.WriteLine("\n\nВведите номер поезда: ");
            TrainID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nИнформация по указанному поезду: ");

            foreach (Train tr in arrTr)
            {
                if(tr.TrainID == TrainID)
                {
                    Console.WriteLine("PointName: " + tr.PointName + " TrainID: " + Convert.ToString(tr.TrainID) + " TimeDepart: " + tr.TimeDepart);
                }
            }

        }

   //     private static void SortArr(Train[] arrTr)
   //     {
  //          Array.Sort(arrTr);
  //      }

    }
}

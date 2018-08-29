using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Zadacha2
{
    //Создайте структуру с именем train, содержащую поля: 
    //название пункта назначения, номер поезда, время отправления.
    //    Ввести данные в массив из пяти элементов типа train, упорядочить 
    //    элементы по номерам поездов.Добавить возможность вывода информации о поезде,
    //    номер которого введен пользователем.Добавить возможность сортировки массив по пункту назначения,
    //    причем поезда с одинаковыми пунктами назначения должны быть упорядочены по времени отправления.

    class Program
    {
        static void Main(string[] args)
        {
            Train[] trains;
            trains = Train.CreateArray();//Создание массива с рандомными значениями ном поездов и типов датаТайм
            Train.Display(trains); // вывод на экран сформированого массива
            trains = Train.SortByNamberTrains(trains); // сортировка по номерам поездов
            Train.Display(trains); // вывод на экран после сорт
            Array.Sort(trains); // Сортировка по назв станции и если одинаковы по времени отпр
            Train.Display(trains);// вывод на экран
            Train.DisplayForNumberTraine(trains); // вывод на экран информации по заданному номеру поезда
        }
    }

    public struct Train : IComparable
    {
        string nameStation;
        int numberTrain;
        DateTime timeStart;

        public Train(string nameStation, int numberTrain, DateTime timeStart)
        {
            this.nameStation = nameStation;
            this.numberTrain = numberTrain;
            this.timeStart = timeStart;
        }

        public static Train[] CreateArray()
        {
            Random rnd = new Random();
            Train[] tr = new Train[5];
            Console.WriteLine("Формируем массив из 5 элементов: введите название пункта назначения");
            for (int i = 0; i < 5; i++)
            {
                DateTime dt = new DateTime(rnd.Next(2018, 2020), rnd.Next(1, 12), rnd.Next(1, 31), rnd.Next(1, 24), rnd.Next(1, 60), 0);
                Console.WriteLine("Пункт назначения номер {0}", i + 1);
                tr[i] = new Train(Console.ReadLine(), rnd.Next(100, 999), dt);
            }
            return tr;
        }
        public static void Display(Train[] arrTr)
        {
            foreach (Train s in arrTr)
            {
                Console.WriteLine("Номер поезда: {0}, Время отправления: {1}, \n  Название станции назначения:  {2} " +
                    "\n ----------------------------------------------", s.numberTrain, s.timeStart, s.nameStation);
            }
            Console.WriteLine("*********************************************************** \n\n\n");
        }

        public static void DisplayForNumberTraine(Train[] trInput)
        {
            int tmp = 0;
            Console.WriteLine("Введите номер поезда , о котором нужна информация");
            tmp = Convert.ToInt32(Console.ReadLine());
            foreach (Train s in trInput)
            {
                if (s.numberTrain == tmp)
                Console.WriteLine("Номер поезда: {0}, Время отправления: {1}, \n  Название станции назначения:  {2} " +
                        "\n ----------------------------------------------", s.numberTrain, s.timeStart, s.nameStation);
            }
        }

        public int CompareTo(object obj)
        {
            int lengs = 0;
            Train temp = (Train)obj;
            if (this.nameStation.Length > temp.nameStation.Length)
                lengs = temp.nameStation.Length;
            else
                lengs = this.nameStation.Length;

            for (int i = 0; i < lengs; i++)
            {
                if (this.nameStation[i] > temp.nameStation[i])
                    return 1;
                if (this.nameStation[i] < temp.nameStation[i])
                    return -1;
                if (i == lengs - 1)

                    if (this.nameStation.Length < temp.nameStation.Length)
                        return -1;
                    else
                        return 1;

                if (this.nameStation.Length == temp.nameStation.Length)
                {
                    if (this.timeStart > temp.timeStart)
                        return 1;
                    return -1;
                }
            }
            return 0;
        }

        public static Train[] SortByNamberTrains(Train[] trains)
        {
            for (int i = 0; i < trains.Length; i++)
            {
                for (int j = 0; j < trains.Length - 1; j++)
                {
                    if (trains[j].numberTrain > trains[j + 1].numberTrain)
                    {
                        int temp = trains[j].numberTrain;
                        trains[j].numberTrain = trains[j + 1].numberTrain;
                        trains[j + 1].numberTrain = temp;
                    }
                }
            }
            return trains;
        }
    }
}

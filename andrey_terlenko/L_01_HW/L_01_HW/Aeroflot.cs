using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_01_HW
{
    public class Aeroflot
    {
        private string _destination { get; set; }
        private int _flightNum { get; set; }
        private string _planeType { get; set; }

        public Aeroflot()
        {

        }

        public Aeroflot(string _destination, int _flightNum, string _planeType)
        {
            this._destination = _destination;
            this._flightNum = _flightNum;
            this._planeType = _planeType;
        }

        private Aeroflot FillAeroflot(Aeroflot obj)//fills empty object with respective values (constructor-ish)
        {
            bool tryAgain = true;
            do
            {
                try
                {
                    Console.Write("Enter destination: ");
                    obj._destination = Console.ReadLine();
                    Console.Write("Enter flight №: ");
                    obj._flightNum = int.Parse(Console.ReadLine());
                    Console.Write("Enter plane type: ");
                    obj._planeType = Console.ReadLine();
                    tryAgain = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);                    
                }
            } while (tryAgain);
            return obj;
        }

        public Aeroflot[] FlightsArr(Aeroflot obj, int size)//returns filled array
        {
            Aeroflot[] flights = new Aeroflot[size];
            try
            { 
                flights[0] = obj;//assigning created object as 0 element so it won't be useless
                FillAeroflot(flights[0]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            for (int i = 1; i < flights.Length; i++)
            {
                flights[i] = new Aeroflot();
                FillAeroflot(flights[i]);
            }
            return flights;
        }

        public void ShowFlightsArr(Aeroflot[] flights)//shows data of every object
        {
            for (int i = 0; i < flights.Length; i++)
            {
                Console.WriteLine($"\nFlight №{flights[i]._flightNum}\nDestination: {flights[i]._destination}\nPlane type: {flights[i]._planeType}");
            }
        }

        public Aeroflot[] SortFlightsArrDescending(Aeroflot[] flights)//sorts array descendingly by flight number
        {
            try
            {
                if (flights.Length == 0)
                {
                    throw new Exception("Array is empty, nothing to sort");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            for (int i = 0; i < flights.Length - 1; i++)
            {
                for (int j = i + 1; j < flights.Length; j++)
                {
                    if (flights[i]._flightNum < flights[j]._flightNum)
                    {
                        Aeroflot temp = flights[j];
                        flights[j] = flights[i];
                        flights[i] = temp;
                    }
                }
            }
            return flights;
        }

        public void ShowMatchedFlights(Aeroflot[] flights, string destination)
        {
            int counter = 0;
            foreach (var item in flights)
            {
                if (destination == item._destination)
                {
                    Console.WriteLine($"\nMATCHED:\nFlight №{item._flightNum}\nPlane type: {item._planeType}");
                }
                else
                {
                    counter++;
                }
            }
            if (counter == flights.Length)
            {
                Console.WriteLine("\nNO MATCHES");
            }
        }
    }
}

using System;

namespace L_01_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.Write("Enter array size: ");
            size = int.Parse(Console.ReadLine());
            Aeroflot qwerty = new Aeroflot();
            Aeroflot[] qwertyArr = new Aeroflot[size];//creating new array to hold array which is returned from FlightsArr function
            qwertyArr = qwerty.FlightsArr(qwerty, size);
            qwerty.ShowFlightsArr(qwertyArr);

            qwerty.SortFlightsArrDescending(qwertyArr);
            Console.WriteLine("\nArray sorted by flight number:");
            qwerty.ShowFlightsArr(qwertyArr);

            string destination;
            Console.Write("\nEnter desired destination: ");
            destination = Console.ReadLine();
            qwerty.ShowMatchedFlights(qwertyArr, destination);
        }
    }
}

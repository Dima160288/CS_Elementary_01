using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;



namespace UserSerialWork
{
    class Program
    {
        static void Main()
        {
            Car car = new Car("Mersedes-Benz", 250);
            Stream stream = File.Create("CarData.dat");
                        
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, car);
            stream.Close();

            stream = File.OpenRead("CarData.dat");

            car = formatter.Deserialize(stream) as Car;

            Console.WriteLine(car.name + "\n" + car.speed);

            Console.ReadKey();
        }
    }
}

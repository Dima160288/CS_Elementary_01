using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_motor_depot
{
    class Automobile
    {
        private string model;
        private string numPlate;
        private Driver driver;
        private string status;

        public string Model { get => model; }
        public string NumPlate { get => numPlate; }
        internal Driver Driver { get => driver; }
        public string Status { get => status; }

        public Automobile(string model, string numPlate)
        {
            this.model = model;
            this.numPlate = numPlate;
        }

        public void SetDriver(Driver driver)
        {
            this.driver = driver;
        }

        public void SetStatus()
        {
            bool isSucc = true;
            int choose;
            while (!isSucc)
            {
                Console.WriteLine("0 = OK\n1 = Broken\n2 = Under repairs");
                Console.Write("-> ");
                choose = 
            }            
        }
    }
}

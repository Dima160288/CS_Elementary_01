using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_motor_depot
{
    class Dispatch : Employee
    {
        private List<Driver> drivers;
        private List<Automobile> automobiles;
        private List<Delivery> deliveries;
        private List<Repair> repairs;

        internal List<Driver> Drivers { get => drivers; set => drivers = value; }
        internal List<Automobile> Automobiles { get => automobiles; set => automobiles = value; }
        internal List<Delivery> Deliveries { get => deliveries; set => deliveries = value; }
        internal List<Repair> Repairs { get => repairs; set => repairs = value; }

        public Dispatch(string firstName, string lastName, int id) : base(firstName, lastName, id)
        {
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_motor_depot
{
    abstract class Employee
    {
        private string firstName;
        private string lastName;
        private int id;

        public string FirstName { get => firstName; }
        public string LastName { get => lastName; }
        public int Id { get => id; }

        public Employee(string firstName, string lastName, int id)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
        }        
    }
}

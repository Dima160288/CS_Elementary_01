using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//include
using System.IO;
using Newtonsoft.Json;

namespace JSONNETExample
{

    class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public override string ToString()
        {
            return string.Format("Name: {0} \nAge: {1}", name, age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {


            // deserialize JSON directly from a file
            
            String JSONstring = File.ReadAllText("JSON.json");
            Person p1 = JsonConvert.DeserializeObject<Person>(JSONstring);
            Console.WriteLine(p1);

            // output JSON file

            Person p2 = new Person { name = "ben", age = 46 };
            string outputJSON = JsonConvert.SerializeObject(p2);
            File.WriteAllText("Output.json", outputJSON);

            Console.ReadLine();
        }
    }
}

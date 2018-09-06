using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//include
using System.Web.Script.Serialization;
using System.IO;

namespace JavaScriptSerializerExample
{
    class Person
    {
        public string name { get; set; }
        public int age { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0} \nAge: {1}",name,age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //deserialize JSON from file
            String JSONstring = File.ReadAllText("JSON.json");

            JavaScriptSerializer ser = new JavaScriptSerializer();
            Person p1 = ser.Deserialize<Person>(JSONstring);
            Console.WriteLine(p1);

            //output JSON file

            Person p2 = new Person() { name = "Ben", age = 58 };
            string outputJSON = ser.Serialize(p2);
            File.WriteAllText("Output.json", outputJSON);
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inheritance
{
    class BaseClass
    {
        public string publicField = "Base.publicField";
        private string privateField = "Base.privateField";
        protected string protectedField = "Base.protectedField";

        public void ShowPrivateField()
        {
            Console.WriteLine(privateField);
        }
    }

    class DerivaedClass : BaseClass
    {
        public DerivaedClass()
        {
            publicField = "DerivaedClass.publicField";
            protectedField = "DerivaedClass.protectedField";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DerivaedClass instance = new DerivaedClass();
            Console.WriteLine(instance.publicField);

            instance.ShowPrivateField();

            Console.ReadLine();
        }
    }
}

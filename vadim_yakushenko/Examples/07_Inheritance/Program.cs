using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Inheritance
{
 

    class Humans
    {
        public int Heig1;

        public Humans()
        {
            this.Heig1 = 1;
        }
    }

    class Mans : Humans
    {
        public int ManHeig1;

        public Mans()
        {
           ManHeig1 = Heig1;
        }
    }

    class Elf : Mans
    {
        public int ElfManHeig1;

        public Elf()
        {
            ElfManHeig1 = ManHeig1;
        }
    }

    class Dwarws : Mans
    {
        public int DwarwsManHeig1;

        public Dwarws()
        {
            DwarwsManHeig1 = ManHeig1;
        }
    }

    class Womans : Humans
    {
        public int WomansHeig1;

        public Womans()
        {
            WomansHeig1 = Heig1;
        }
    }

    class SamllWoman : Womans
    {
        public int SamllWomanHeig1;

        public SamllWoman()
        {
            SamllWomanHeig1 = WomansHeig1;
        }

        public void Hello()
        {
            throw new System.NotImplementedException();
        }
    }

    class BigWoman : Womans
    {
        public int BigWomanWomanHeig1;

        public BigWoman()
        {
            BigWomanWomanHeig1 = WomansHeig1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BigWoman instance = new BigWoman();

            Console.WriteLine(instance.BigWomanWomanHeig1);
           // Console.WriteLine(instance.DwarwsManHeig1);

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    public class Animal
    {
        public string Name;
        public int Size;
        public string Colours;
        public string Halo;
    }

    public class Vertebrates : Animal
    {

    }

    public class Invertebrates : Animal
    {

    }

    public class Fishes : Vertebrates
    {

    }

    public class Amphibians : Vertebrates
    {

    }

    public class Reptiles : Vertebrates
    {

    }

    public class Mammals : Vertebrates
    {

    }

    public class Birds : Vertebrates
    {

    }

    public class Coelenterates : Invertebrates
    {

    }

    public class Worms : Invertebrates
    {

    }
    
    public class Arthropods : Invertebrates
    {

    }

    public class Mollusks : Invertebrates
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

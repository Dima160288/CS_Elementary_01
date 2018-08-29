using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site_Ierarchy
{
    class dp_informator_ua { }

    class Main : dp_informator_ua { }

    class Life : Main { }
    class Power : Life { }
    class Money : Life { }
    class Thrash : Life { }
    sealed class Article_Power : Power { }
    sealed class Article_Money : Money { }
    sealed class Article_Thrash : Thrash { }

    class Press_Release : Main { }
    class Announses : Press_Release { }
    class SEO : Press_Release { }
    sealed class Article_Announses : Announses { }
    sealed class Article_SEO : SEO { }

    class People : Main { }
    class Human_Rights : People { }
    class Experts_Commentaries : People { }
    class Specproject : People { }
    sealed class Article_Human_Rights : Human_Rights { }
    sealed class Article_Experts_Commentaries : Experts_Commentaries { }
    sealed class Article_Specproject : Specproject { }

    sealed class About : Main { }

    class Commercials : Main { }
    sealed class Commercial_Window : Commercials { }
    
    class Cities : Main { }
    sealed class City : Cities { }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

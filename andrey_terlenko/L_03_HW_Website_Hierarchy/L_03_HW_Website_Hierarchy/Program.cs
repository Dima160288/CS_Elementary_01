using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_03_HW_Website_Hierarchy
{
    class Wolfswood_ru { }

    class Main : Wolfswood_ru { }

    class All_Books : Main { }

    class Redacted_Book : All_Books { }

    sealed class RB_Comments : Redacted_Book { }

    class In_Progress_Book : All_Books { }

    sealed class IPB_Comments : In_Progress_Book { }

    class Glossary : Main { }

    class About : Main { }

    class FAQ : Main { }

    sealed class FAQ_Comments : FAQ { };

    class Forum : Main { }

    class Thread : Forum { }

    sealed class Answer : Thread { }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

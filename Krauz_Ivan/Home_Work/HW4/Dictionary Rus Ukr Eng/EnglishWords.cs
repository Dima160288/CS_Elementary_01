using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    class EnglishWords
    {
        public string[] EnglishArray = null;

        public EnglishWords()
        {
            EnglishArray = new string[5];
            EnglishArray[0] = "book";
            EnglishArray[1] = "pen";
            EnglishArray[2] = "sun";
            EnglishArray[3] = "apple";
            EnglishArray[4] = "table";
        }

        public virtual string this [int index]
        {
            get { return EnglishArray[index]; }
        }
    }
}

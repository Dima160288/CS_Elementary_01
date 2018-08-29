using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    class RussianWords : EnglishWords
    {
        public string[] RussianArray = null;

        public RussianWords()
        {
            RussianArray = new string[5];
            RussianArray[0] = "книга";
            RussianArray[1] = "ручка";
            RussianArray[2] = "солнце";
            RussianArray[3] = "яблоко";
            RussianArray[4] = "стол";
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < RussianArray.Length; i++)
                    if (RussianArray[i] == index)
                        return EnglishArray[i] + " - " + RussianArray[i];

                return string.Format("{0} - нет перевода для этого слова.", index);
            }
        }


        public override string this[int index]
        {
            get { return base[index] + " - " + RussianArray[index]; }
        }
    }
}

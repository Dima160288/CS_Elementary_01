using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    class UkrainianWords : RussianWords
    {
        public string[] UkrainianArray = null;

        public UkrainianWords()
        {
            UkrainianArray = new string[5];
            UkrainianArray[0] = "книга";
            UkrainianArray[1] = "ручка";
            UkrainianArray[2] = "сонце";
            UkrainianArray[3] = "яблуко";
            UkrainianArray[4] = "стiл";
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < UkrainianArray.Length; i++)
                    if (UkrainianArray[i] == index || RussianArray[i] == index || EnglishArray[i] == index)
                        return UkrainianArray[i] + " - " + RussianArray[i] + " - " + EnglishArray[i];

                return string.Format("{0} - нет перевода для этого слова.", index);
            }
        }


        public override string this[int index]
        {
            get { return base[index] + " - " + UkrainianArray[index]; }
        }
    }
}

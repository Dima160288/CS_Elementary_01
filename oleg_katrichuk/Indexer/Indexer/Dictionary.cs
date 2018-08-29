using System;
using System.Collections.Generic;
using System.Text;

namespace Indexer
{
    class Dictionary
    {
        private readonly string[] rus = new string[5];
        private readonly string[] english = new string[5];
        private readonly string[] ukr = new string[5];

        public Dictionary()
        {
            rus[0] = "книга"; english[0] = "book"; ukr[0] = "книга";
            rus[1] = "ручка"; english[1] = "pen"; ukr[1] = "олiвець";
            rus[2] = "солнце"; english[2] = "sun"; ukr[2] = "сонце";
            rus[3] = "яблоко"; english[3] = "apple"; ukr[3] = "яблуко";
            rus[4] = "стол"; english[4] = "table"; ukr[4] = "стiл";
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < rus.Length; i++)
                {
                    if (rus[i] == index)
                        return rus[i] + " - " + english[i] + " - " + ukr[i];
                    if (ukr[i] == index)
                        return ukr[i] + " - " + english[i] + " - " + rus[i];
                    if (english[i] == index)
                        return english[i] + " - " + rus[i] + " - " + ukr[i];
                }
                return string.Format("{0} - нет перевода для этого слова.", index);
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < rus.Length)
                    return rus[index] + " - " + english[index];
                else
                    return "Попытка обращения за пределы массива.";
            }
        }

    }
}

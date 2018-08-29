using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_HW005_3
{
    public class Dictionary
    {
        private string[] rus = new string[5];
        private string[] eng = new string[5];
        private string[] ukr = new string[5];

        public Dictionary()
        {
            rus[0] = "книга"; eng[0] = "book"; ukr[0] = "книга";
            rus[1] = "ручка"; eng[1] = "pen"; ukr[1] = "ручка";
            rus[2] = "солнце"; eng[2] = "sun"; ukr[2] = "сонце";
            rus[3] = "яблоко"; eng[3] = "apple"; ukr[3] = "яблуко";
            rus[4] = "стол"; eng[4] = "table"; ukr[4] = "стіл";
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < rus.Length; i++)
                    if (rus[i] == index || eng[i] == index || ukr[i] == index)
                        return rus[i] + " - " + eng[i] + " - " + ukr[i];

                return string.Format("{0} - нет перевода для этого слова.", index);
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < rus.Length)
                    return rus[index] + " - " + eng[index] + " - " + ukr[index];
                else
                    return "Попытка обращения за пределы массива.";
            }
        }
    }
}

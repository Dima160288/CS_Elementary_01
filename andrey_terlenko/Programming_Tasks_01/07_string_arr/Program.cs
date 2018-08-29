using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_string_arr
{
    class Program
    {
        static void Main(string[] args)
        {
            StringArr test = new StringArr(5);
            test.FillArr();
            StringArr.ShowArr(test.StrArr);
            //test.ShowElemByIndex(4);
            StringArr qwerty = new StringArr(5);
            qwerty.FillArr();
            StringArr.ShowArr(qwerty.StrArr);

            //StringArr.ShowArr(StringArr.LinkByElem(test.StrArr, qwerty.StrArr));

            //test.StrArr = test.StrArr.Distinct().ToArray();
            //StringArr.ShowArr(test.StrArr);

            StringArr.ShowArr(StringArr.ConcatUniqueElems(test.StrArr, qwerty.StrArr));            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_string_arr
{
    class StringArr
    {
        private string[] strArr;

        public string[] StrArr { get => strArr; set => strArr = value; }

        public string this[int index]
        {
            get { return strArr[index]; }
            set { strArr[index] = value; }
        }

        public StringArr(int size)
        {
            strArr = new string[size];
        }  
        
        public void FillArr()
        {
            for (int i = 0; i < strArr.Length; i++)
            {
                Console.Write($"Enter string #{i + 1}: ");
                strArr[i] = Console.ReadLine();
            }
        }

        public void ShowElemByIndex(int index)
        {
            try
            {
                Console.WriteLine($"String #{index} is -> {strArr[index]}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);                
            }
        }

        public static void ShowArr(string[] strArr)
        {
            foreach (var item in strArr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        //дальше говнокод
        public static string[] LinkByElem(string[] arr_1, string[] arr_2) // подразумеваю что длины одинаковые, тк "7.	Составить описание класса для определения одномерных массивов строк фиксированной длины"
        {
            string[] resArr = new string[arr_1.Length];
            for (int i = 0; i < resArr.Length; i++)
            {
                resArr[i] = arr_1[i] + arr_2[i];
            }
            return resArr;
        }

        public static string[] ConcatUniqueElems(string[] arr_1, string[] arr_2)
        {            
            arr_1 = arr_1.Distinct().ToArray();
            arr_2 = arr_2.Distinct().ToArray();

            string[] resArr = new string[arr_1.Length + arr_2.Length];
            resArr = arr_1.Concat(arr_2).ToArray();
            resArr = resArr.Distinct().ToArray();
            return resArr;
        }
    }
}

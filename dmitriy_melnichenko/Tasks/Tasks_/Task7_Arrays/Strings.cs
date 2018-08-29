using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_Arrays
{
    class String
    {

        private string[] strArr;
        private string str;
        private int strLengh;

        public string Str { get => str; set => str = value; }
        public int StrLengh { get => strLengh; set => strLengh = value; }
        public string[] StrArr { get => strArr; set => strArr = value; }

        public String(int arrLengh, int strLengh)
        {
            this.strLengh = strLengh;
            string[] strArr = new string[arrLengh];            
            for (int i = 0; i < strArr.Length; i++)
            {
                Console.WriteLine($"Enter text for string{i + 1}: ");
                this.str = strArr[i];
                strArr[i] = Console.ReadLine();
                if (strArr[i].Length > strLengh)
                {
                    throw new Exception("Excessive string length");
                }
            }
            this.strArr = strArr;
        }
        public void ShowArr()
        {
            foreach (var item in strArr)
            {
                Console.Write(item + " ");
            }
        }

        public string this[int index]
        {
            get { return StrArr[index]; }
            set { StrArr[index] = value; }
        }

        public string ShowStringBeIndex(int index)
        {
            return $"String`s {index} is {index}";
        }




        ////////public string[] SetStrArr(int arrLengh, int strLengh)
        ////////{
        ////////    this.strLengh = strLengh;
        ////////    String strings = new String();
        ////////    string[] strArr = new string[arrLengh];
        ////////    this.strArr = strArr;
        ////////    for (int i = 0; i < strArr.Length; i++)
        ////////    {
        ////////        Console.WriteLine($"Enter text for string{i + 1}: ");
        ////////        strArr[i] = strings.str = Console.ReadLine();
        ////////        if (strArr[i].Length > strLengh)
        ////////        {
        ////////            throw new Exception("Excessive string length");
        ////////        }
        ////////    }
        ////////    return strArr;          
        ////////}
        ////////public String(int size)
        ////////{
        ////////    strArr = new string[size];
        ////////}
        ////////public string[] strAddArr(int strLengh)
        ////////{
        ////////    string[] str = new string[strLengh];
        ////////    this.strLengh = strLengh;
        ////////    for (int i = 0; i < str.Length; i++)
        ////////    {
        ////////        Console.WriteLine($"Enter text for string{i + 1}: ");
        ////////        str[i] = Console.ReadLine();
        ////////        if (str[i].Length > strLengh)
        ////////        {
        ////////            throw new Exception("Excessive string length");
        ////////        }
        ////////    }
        ////////    return str;
        ////////}

        ////////public String(int size)
        ////////{
        ////////    str = new string[size];
        ////////}

        ////////public string this[int index]
        ////////{
        ////////    get
        ////////    {
        ////////        return str[index];
        ////////    }

        ////////    set
        ////////    {
        ////////        str[index] = value;
        ////////    }
        ////////}

        ////////public void FillArr(int strLengh)
        ////////{
        ////////    this.strLengh = strLengh;
        ////////    for (int i = 0; i < str.Length; i++)
        ////////    {
        ////////        Console.WriteLine($"Enter text for string{i + 1}: ");
        ////////        str[i] = Console.ReadLine();
        ////////        if (str[i].Length > strLengh)
        ////////        {
        ////////            throw new Exception("Excessive string length");
        ////////        }
        ////////    }
        ////////}



    }
}

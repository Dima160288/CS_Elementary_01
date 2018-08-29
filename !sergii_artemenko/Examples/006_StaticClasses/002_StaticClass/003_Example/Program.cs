using System;


namespace _003_Example
{
    class Helper
    {
        public static int Report(string str)
        {
            Console.WriteLine(str);
            return 0;
        }
    }

    class MyClass
    {
        static int staticField = Helper.Report("Инициализация статических полей");

        static MyClass()
        {
            Helper.Report("Статический конструктор");
        }

        int field = Helper.Report("Инициализация нестатических полей");

        public MyClass(int c)
        {
            Helper.Report("Конструктор, вызванный другим конструктором");
        }

        public MyClass()
            : this(1)
        {
            Helper.Report("Явно вызванный конструктор");
        }

        public void Method()
        {
            Helper.Report("Метод");
        }
    }

    class Program
    {
        public static void Main()
        {
            Helper.Report("Начало программы");
            new MyClass().Method();

            Console.ReadLine();
        }
    }
}

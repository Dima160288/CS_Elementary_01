using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Files
{
    class Program
    {
        static object block = new object();

        static string path_3 = @"third.txt";

        static void ReadWriteF(object path)
        {
            lock (block)
            {
                string text;
                using (StreamReader reader = new StreamReader((string)path, System.Text.Encoding.Default))
                {
                    text = reader.ReadToEnd();
                }
                Console.WriteLine($"Файл {(string)path} считан");
                using (StreamWriter writer = new StreamWriter(path_3, true, System.Text.Encoding.Default))
                {
                    writer.WriteLine(text);
                    writer.WriteLine(new string('-', 80));
                }
                Console.WriteLine($"Текст записан в {path_3}");
            }            
        }

        static void Main(string[] args)
        {
            string path_1 = @"first.txt";
            string path_2 = @"second.txt";

            ParameterizedThreadStart readWriteF = new ParameterizedThreadStart(ReadWriteF);
            Thread first = new Thread(readWriteF);
            Thread second = new Thread(readWriteF);

            first.Start(path_1);
            //first.Join();
            //Thread.Sleep(500);
            second.Start(path_2);

            Thread.Sleep(500);

            Console.ReadKey();
        }
    }
}

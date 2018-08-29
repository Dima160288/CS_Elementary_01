using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp7
{
    class Program
    {

        static int threadCount = 0;

        static void Main(string[] args)
        {
            //Console.SetBufferSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            for (int i = 0; i < (Console.LargestWindowWidth/2); ++i)
            {
                Thread thread = new Thread(Display);
                threadCount+=2;
                thread.Start();
                Thread.Sleep(1000);
            }
        }

        public static void Display()
        {
            int c = 0;
            int countArrayLengs;
            char[] arr;
            int threadCountThis = threadCount;
           
            arr = GetSymbolMethod();
           
            countArrayLengs = arr.Length;
            
            while (true)
            {
                for (int i = 0; i < Console.LargestWindowHeight; i++)
                {
                    if (c < Console.LargestWindowHeight)
                    {
                        c++;
                    }
                    else
                    {
                        c = 0;
                        for (int clear = 0; clear < Console.LargestWindowHeight; clear++)
                        {
                            Console.SetCursorPosition(threadCountThis, clear);
                            Console.Write(" ");
                            Thread.Sleep(100);
                        }
                        for (int clear = 0; clear < Console.LargestWindowHeight; clear++)
                        {
                            Console.SetCursorPosition(threadCountThis, clear);
                            Console.Write(" ");
                            
                        }
                    }

                    if (i == arr.Length - 1)
                    {
                        arr = GetSymbolMethod();
                        countArrayLengs = arr.Length;
                        i = 0;
                    }
                    else
                    {
                        Console.SetCursorPosition(threadCountThis, c);
                        Console.WriteLine(arr[i]);
                        Thread.Sleep(100);
                    }
                }
                
            }
        }

        public static char[] GetSymbolMethod()
        {

            Random r = new Random();
            int leng = r.Next(40, 80);
            char[] arrayChar = new char[leng];

            for (int i = 0; i < leng; i++)
            {
                int t = r.Next(10);
                if (t <= 2)
                    arrayChar[i] = (char)('0' + r.Next(10));
                else if (t <= 4)
                    arrayChar[i] = (char)('a' + r.Next(27));
                else if (t <= 6)
                    arrayChar[i] = (char)('A' + r.Next(27));
                else
                    arrayChar[i] = (char)(r.Next(32, 255));
            }
            return arrayChar;
        }
    }
}

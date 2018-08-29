using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task_1_of_6_Tasks
{




    class Program
    {
        public static Mutex mutexObj = new Mutex();

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetWindowPosition(0, 0);
            Console.WindowLeft = Console.WindowTop = 0;
            Console.WindowHeight = Console.BufferHeight = Console.LargestWindowHeight;
            Console.WindowWidth = Console.BufferWidth = Console.LargestWindowWidth;
            Thread thread;

            for (int i = 0; i < 2; i ++)
            {
              //   mutexObj.WaitOne();
                Program cc = new Program();
                cc.ThreadCountThis = i;
                thread = new Thread(cc.MethodCreateCharArray);
                thread.Start();
              //    mutexObj.ReleaseMutex();
            }
        }


        public int ThreadCountThis { get; set; }

        public void Displays(int trCount, int inc, char ch)
        {

            Thread.Sleep(10);
            Console.SetCursorPosition(trCount, inc);
            Console.Write(ch);
        }

        public void MethodCreateCharArray()
        {
            while (true)
            {
                char ch = ' ';
                int c = 0;
                Random r = new Random();
                mutexObj.WaitOne();

                for (int i = r.Next(0,Console.LargestWindowHeight - 1); i != 0; i--)
                {
                    c++;
                    Displays(ThreadCountThis, c - 1, ' ');
                }
                for (int i = 0; i < r.Next(0, Console.LargestWindowHeight - 1); i++)
                {
                    int t = r.Next(10);
                    if (t <= 2)
                        ch = (char)('0' + r.Next(10));
                    else if (t <= 4)
                        ch = (char)('a' + r.Next(27));
                    else if (t <= 6)
                        ch = (char)('A' + r.Next(27));
                    else
                        ch = (char)(r.Next(32, 255));

                    Displays(ThreadCountThis, i, ch);
                }
                mutexObj.ReleaseMutex();
            }
        }


        public void SetSymbolColor(int val1, int val2)
        {
            if (val2 == val1)
                Console.ForegroundColor = ConsoleColor.White;
            else if (val2 == val1 - 1)
                Console.ForegroundColor = ConsoleColor.Green;
            else
                Console.ForegroundColor = ConsoleColor.DarkGreen;
        }

    }
}



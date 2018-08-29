using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MatrixReload
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

            for (int i = 0; i < Console.LargestWindowWidth; i+=2)
            {
               // mutexObj.WaitOne();
                ColumsCreate cc = new ColumsCreate();
                cc.ThreadCountThis = i;
                thread = new Thread(cc.MethodCreateCharArray );
                thread.Start();
              //  mutexObj.ReleaseMutex();
            }
        }
    }
    class ColumsCreate
    {
        public static Mutex mutexObj = new Mutex();
        public int ThreadCountThis { get; set; }

        public void Displays(int trCount, int inc, char ch)
        {
            
            Thread.Sleep(1);
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
                
                for (int i = Console.LargestWindowHeight - 1; i != 0; i--)
                {
                    c++;
                    Displays(ThreadCountThis, c-1, ' ');
                }
                for (int i = 0; i < Console.LargestWindowHeight-1; i++)
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
    }
}

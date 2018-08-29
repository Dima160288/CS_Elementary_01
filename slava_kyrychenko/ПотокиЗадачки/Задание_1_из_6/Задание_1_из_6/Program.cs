using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1_из_6
{
    class Program
    {
        
        static void Main(string[] args)
        {   
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowLeft = Console.WindowTop = 0;
            Console.WindowHeight = Console.BufferHeight = Console.LargestWindowHeight;
            Console.WindowWidth = Console.BufferWidth = Console.LargestWindowWidth;
        }


        public static string[] CreateString()
        {
            string[] arr = [Console.LargestWindowHeight];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = GetChar();
            }

            return 
        }
        
        static char[] GetCharArray()
        {Random r = new Random();

                int t = r.Next(10);
                if (t <= 2)
                    return (char)('0' + r.Next(10));
                else if (t <= 4)
                    return (char)('a' + r.Next(27));
                else if (t <= 6)
                    return (char)('A' + r.Next(27));
                else
                    return (char)(r.Next(32, 255));
        }
    }
}

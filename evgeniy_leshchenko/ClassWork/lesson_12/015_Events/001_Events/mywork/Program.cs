using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mywork
{
    public delegate void PressKeyEventHandler();

    public class Keyboard
    {
        public event PressKeyEventHandler PressKeyI = null;

        public void PressKeyIEvent()
        {
            if (PressKeyI != null)
            {
                PressKeyI.Invoke();
            }
        }

        public void Start()
        {
            Boolean flagcontinue = true;

            while (flagcontinue == true)
            {
                string s = Console.ReadLine();

                switch (s)
                {
                    case "i":
                    case "I":
                        PressKeyIEvent();
                        break;
                    case "exit":
                        flagcontinue = false;
                        Console.WriteLine("Exit!");
                        break;

                    default:
                        Console.WriteLine("Нет обработчика нажатия на клавишу {0}", s);
                        break;
                }
            }
        }
    }

    class Program
    {
        // Методы обработчики события.

        static private void PressKeyI_Handler()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine("X");
            Console.WriteLine("\n");
            Console.WriteLine("X");
            Console.WriteLine("X");
            Console.WriteLine("X");
            Console.WriteLine("X");
            Console.WriteLine("X");
            Console.WriteLine("X");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static void Main()
        {
            Keyboard keyboard = new Keyboard();

            // Подписка на событие.
            
            keyboard.PressKeyI += PressKeyI_Handler;

            // Запуск метода, который будет следить за нажатием клавиш 
            keyboard.Start();
        }
    }
}

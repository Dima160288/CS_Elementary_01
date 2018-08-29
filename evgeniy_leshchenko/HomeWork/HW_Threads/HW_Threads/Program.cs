using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


//1 - Создайте программу, которая будет выводить на экран цепочки падающих символов.
//Длина каждой цепочки задается случайно.Первый символ цепочки – белый, второй символ – светло-зеленый,
// остальные символы темно-зеленые.Во время падения цепочки, на каждом шаге, все символы меняют свое значение.
//Дойдя до конца, цепочка исчезает и сверху формируется новая цепочка.Смотрите ниже снимок экрана, представленный как образец.

namespace HW_Threads
{
    class Program   
    {

        static Boolean flagStart = false;
        static object locker = new object();

        static void WriteColumn(object offset)
        {

           // offset += 1;
            //Thread thread = Thread.CurrentThread;

            int threadOffset = (int)offset;
            int i = 0; int colSize = 0;

            Random rand = new Random();
            colSize = rand.Next(Console.WindowHeight/2, Console.WindowHeight);


            while (i <= colSize)
            {
                lock (locker)
                {
                    switch (i)
                    {
                        case 0:
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            break;
                    }

                    

                    //Console.Write(new string(' ', threadOffset) + (char)(rand.Next(25, 70)) );

                    Console.SetCursorPosition(threadOffset, i);
                    Console.Write((char)(rand.Next(33, 190)));
                    i += 1;
                }

                if (i > colSize)
                {
                    i = 0;
                    colSize = rand.Next(Console.WindowHeight / 2, Console.WindowHeight);
                    // Console.WriteLine("Строка закончилась");
                }


                Thread.Sleep(100);

            }


        }





        // тестовая процедура что бы именно цепочками опускалась
        static void WriteLinks(object offset)
        {

            int threadOffset = (int)offset;
            int i = 0;
            int linkSize = 0;

            Random rand = new Random();
            linkSize = rand.Next( Console.WindowHeight / 2, Console.WindowHeight);

            string[] LinkSet = new string[Console.WindowHeight];

            //for(i=0; i< linkSize; i++)
            //{
            //    LinkSet[i] = new string(' ', threadOffset) + (char)(rand.Next(25, 70));
            //}


            i = 0;

            while(flagStart == false)
            {
                Thread.Sleep(50);
            }

            while (linkSize != -1 )
            {
                lock (locker)
                {

                    for (int j = 0; j < i; j++)
                    {
                        Console.SetCursorPosition(threadOffset, j);
                        Console.Write(" ");
                    }






                    //Console.Write(new string(' ', threadOffset) + (char)(rand.Next(25, 70)) );


                    for (int j = 0; j < linkSize; j++)
                    {

                        switch (j)
                        {
                            case 0:
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            case 1:
                                Console.ForegroundColor = ConsoleColor.Green;
                                break;

                            default:
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                break;
                        }


                        Console.SetCursorPosition(threadOffset, i+j);
                        Console.Write((char)(rand.Next(33, 190)));
                    }
                        
                    
                   
                    if(i+linkSize == LinkSet.Length)
                    {
                        linkSize -= 1;
                        if(linkSize <0)
                        {
                            linkSize = rand.Next(Console.WindowHeight / 2, Console.WindowHeight);
                            i = 0;
                        }
                        else
                            i += 1;

                    }
                    else
                        i += 1;

                }

                //if (i > linkSize)
                //{
                //    i = 0;
                //    linkSize = rand.Next(Console.WindowHeight / 2, Console.WindowHeight);
                //    // Console.WriteLine("Строка закончилась");
                //}


                Thread.Sleep(50);

            }


        }




        static void Main()
        {

            int offset = 0;

            Random rand = new Random();

            //ThreadStart writeColumn = new ThreadStart(WriteColumn);
            //Thread thread = new Thread(WriteColumn);
            //thread.Start();
            //Console.SetC
            // Console.SetWindowPosition(-10, 0);
            Console.WindowHeight = 40;//Console.LargestWindowHeight;
            Console.WindowWidth = 180;//Console.LargestWindowWidth;

            ParameterizedThreadStart writeColumn = new ParameterizedThreadStart(WriteColumn);
            //ParameterizedThreadStart writeColumn = new ParameterizedThreadStart(WriteLinks);

            for (int i = 0; i < Console.WindowWidth; i++)
            {

                new Thread(writeColumn).Start(offset);
                offset += 1;
                Thread.Sleep(50);

            }
            flagStart = true;

           // new Thread(writeColumn).Start(offset);
           // offset += 1;
           //Thread.Sleep(50);

            //      WriteColumn();


            // Delay.
            Console.ReadKey();
        }


    }
}

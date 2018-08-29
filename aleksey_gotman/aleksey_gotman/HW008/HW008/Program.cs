using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HW008
{
    /*1 - Создайте программу, которая будет выводить на экран цепочки падающих символов. Длина каждой цепочки задается случайно. Первый символ цепочки – белый, второй символ – светло-зеленый, остальные символы темно-зеленые. Во время падения цепочки, на каждом шаге, все символы меняют свое значение. Дойдя до конца, цепочка исчезает и сверху формируется новая цепочка. Смотрите ниже снимок экрана, представленный как образец. 

2 - Расширьте задание 1, так, чтобы в одном столбце одновременно могло быть две цепочки символов. 

3 - Создайте консольное приложение, которое в различных потоках сможет получить доступ к 2-м файлам. Считайте из этих файлов содержимое и попытайтесь записать полученную информацию в третий файл. Чтение/запись должны осуществляться одновременно в каждом из дочерних потоков. Используйте блокировку потоков для того, чтобы добиться корректной записи в конечный файл. */
    static class Program
    {
        static char[,] mas = new char[25, 80];
        static void Main(string[] args)
        {

            //for (int i = 0; i < 20; i++)
            //{
            //    for (int j = 0; j < 20; j++)
            //    {
            //        mas[i, j] = '1';
            //    }

            //}

            ParameterizedThreadStart thread = new ParameterizedThreadStart(Changer);
            for (int i = 0; i < 80; i++)
            {
                Thread thread1 = new Thread(thread);
                thread1.Start(i);
                Thread.Sleep(75);
            }

            while (true)
            {
                for (int i = 0; i < 25; i++)
                {
                    for (int j = 0; j < 80; j++)
                    {
                        if (i == 24 || i == 23)
                            Console.ForegroundColor = ConsoleColor.Green;
                        else if (mas[i + 2, j] == ' ' || mas[i + 1, j] == ' ')
                            Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(mas[i, j]);
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                    }
                    Console.WriteLine();
                }
                Thread.Sleep(200);
                Console.Clear();
            }
        }
        static void Changer(object x)
        {
            int j = (int)x;
            Random r = new Random();
            int slep = r.Next(1000, 3000);
            int length = r.Next(15, 26);
            int num;
            int chance;
            while (true)
            {
                for (int i = 0; i < length; i++)
                {
                    if (i != 0)
                        mas[i, j] = mas[i - 1, j];
                    Thread.Sleep(slep);
                    for (int a = 0; a < i - 1; a++)
                    {
                        chance = r.Next(0, 3);
                        if (chance != 1)
                        {
                            num = r.Next(25, 70);
                            mas[a, j] = (char)(num);
                        }
                    }
                }
                for (int i = 0; i < length; i++)
                {
                    mas[i, j] = ' ';
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.IO;

namespace DownloadFiles
{
    class Program
    {
        static readonly Mutex mutex = new Mutex();

        //static readonly SemaphoreSlim slim = new SemaphoreSlim(1, 2);

        static WebClient wc = new WebClient();

        static void Main(string[] args)
        {
            string[] url = { "http://textfiles.com/anarchy/203.txt", "http://textfiles.com/anarchy/001.txt", "http://textfiles.com/survival/pinesoup.txt", "http://textfiles.com/survival/fire.txt" };
            string[] savePath = { "file_1.txt", "file_2.txt", "file_3.txt", "file_4.txt" };
            Thread[] threads = new Thread[4];

            for (int i = 0; i < threads.Length; i++)
            {
                Arguments arguments = new Arguments(url, savePath, i);
                Thread thread = new Thread(new ThreadStart(arguments.DownloadF));
                thread.Start();
                //thread.Join(); //лечит webclient не поддерживает параллельные операции ввода-вывода (можно lock в ф-и)
            }

            //Thread.Sleep(1000);
            //slim.Release();
            Console.ReadKey();
        }

        class Arguments //вложенный класс чтобы не ебаться с глобальными переменными
        {            
            private string[] url;
            private string[] savePath;
            private int num;

            public Arguments(string[] url, string[] savePath, int num)
            {
                this.url = url;
                this.savePath = savePath;
                this.num = num;
            }

            public void DownloadF()
            {
                mutex.WaitOne();
                //slim.Wait();
                Console.WriteLine($"Начало скачивания файла #{num + 1}");
                Thread.Sleep(500);
                wc.DownloadFile(url[num], savePath[num]);
                Console.WriteLine($"Конец скачивания файла #{num + 1}");
                mutex.ReleaseMutex();
                //slim.Release();
            }
        }
    }    
}

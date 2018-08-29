using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Download
{
    class Program
    {
        static readonly SemaphoreSlim semSlim = new SemaphoreSlim(1, 2);
        static WebClient wc = new WebClient();

        static void Main(string[] args)
        {
            string[] urls = { "http://textfiles.com/holiday/fdc", "http://textfiles.com/holiday/mc.xmas", "http://textfiles.com/holiday/santa4.fun", "http://textfiles.com/holiday/xmas1.txt" };
            string[] urlsNames = { "text1.txt", "text2.txt", "text3.txt", "text4.txt" };
            Thread[] threads = new Thread[urls.Length];

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(delegate () { Download(i, urls, urlsNames); } );
                threads[i].Start();
                threads[i].Join();
            }
            Thread.Sleep(2000);
            semSlim.Release();
            Console.WriteLine("Download Complete!");
            Console.ReadKey();
        }

        public static void Download(int i, string[] urls, string[] urlsNames)
        {
            semSlim.Wait();
            Console.WriteLine($"Поток {i} начал работу!");
            Thread.Sleep(1000);
            wc.DownloadFile(urls[i], urlsNames[i]);
            Console.WriteLine($"Поток {i} завершил работу!");
            semSlim.Release();
        }
    }
}

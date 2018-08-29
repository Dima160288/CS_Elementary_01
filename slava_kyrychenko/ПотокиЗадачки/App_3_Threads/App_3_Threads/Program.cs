using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;


namespace App_3_Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            var cl = new WebClient();
            cl.DownloadFileAsync(new Uri ("https://gorod.dp.ua/"), "file.txt");
            cl.DownloadFileCompleted += (a, b) => Console.WriteLine("completed");
            cl.DownloadProgressChanged += (a, b) => Console.WriteLine("Received: {0}", b.BytesReceived.ToString());
            Console.ReadKey();
        }
    }
}

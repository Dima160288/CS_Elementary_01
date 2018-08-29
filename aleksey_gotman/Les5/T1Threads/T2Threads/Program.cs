using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace T2Threads
{
    class Program
    {
        static string path3 = "T3.txt";
        static void Main(string[] args)
        {
            string path1 = "T1.txt";
            string path2 = "T2.txt";
            
            Thread t1 = new Thread(new ParameterizedThreadStart(DoIt));
            Thread t2 = new Thread(new ParameterizedThreadStart(DoIt));
            t1.Start(new Cell(path1, t1, "first"));
            t2.Start(new Cell(path2, t2, "second"));
            Console.ReadLine();
        }
        static void DoIt(object path)
        {
            Cell c = (Cell)path;
            Console.WriteLine("{0} start", c.name);
            StreamReader r = new StreamReader(c.path1);
            string s = r.ReadToEnd();
            Console.WriteLine("{0} readed", c.name);
            c.t1.Join();
            StreamWriter w = new StreamWriter(path3);
            w.WriteLine(s);
            Console.WriteLine("{0} writed", c.name);
        }
    }
    class Cell
    {
        public string name;
        public string path1;
        public Thread t1;

        public Cell(string path1, Thread t1, string name)
        {
            this.name = name;
            this.path1 = path1;
            this.t1 = t1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Figure
{
    public class Point
    {
        private int x;
        private int y;
        private string name;

        public int X { get; }
        public int Y { get; }
        public string Name { get; }

        public Point()
        {

        }

        public Point(int x, int y, string name=null)
        {
            X = x;
            Y = y;
            Name = name;
        }
    }
}

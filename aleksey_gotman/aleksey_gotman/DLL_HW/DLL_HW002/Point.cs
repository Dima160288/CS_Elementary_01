using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_HW002
{
    public class Point
    {

        private int x;
        public int X { get { return x; } }
        private int y;
        public int Y { get { return y; } }
        private string name;
        public string Name { get { return name; } }

        public Point(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

    }
}

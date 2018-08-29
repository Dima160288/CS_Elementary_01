using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_rectangulars
{
    struct Point
    {
        private int x;
        private int y;

        public int X { get => x; }
        public int Y { get => y; }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void MoveX(int offset)
        {
            this.x += offset;
        }

        public void MoveY(int offset)
        {
            this.y += offset;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    /*Составить описание класса прямоугольников со сторонами, параллельными осям координат.
     * Предусмотреть возможность перемещения прямоугольников на плоскости, изменение размеров, построение наименьшего прямоугольника,
     * содержащего два заданных прямоугольника, и прямоугольника, являющегося общей частью (пересечением) двух прямоугольников.*/
    public static class T11
    {
        public static Rectangle Rebuild(Rectangle a, Rectangle b)
        {
            int x1;
            int x2;
            int y1;
            int y2;
            if (a.A.X < b.A.X && a.B.X < b.B.X && a.B.X > b.A.X)
            {
                x1 = b.A.X;
                x2 = a.B.X;
            }
            else if (a.A.X > b.A.X && a.B.X > b.B.X && a.B.X < b.A.X)
            {
                x1 = b.B.X;
                x2 = a.A.X;
            }
            else if (a.A.X <= b.A.X && a.B.X >= b.B.X)
            {
                x1 = b.A.X;
                x2 = b.B.X;
            }
            else if (a.A.X >= b.A.X && a.B.X <= b.B.X)
            {
                x1 = a.A.X;
                x2 = a.B.X;
            }
            else
            {
                x1 = 0;
                x2 = 0;
            }
            if (a.A.Y < b.A.Y && a.D.Y < b.D.Y && a.D.Y > b.A.Y)
            {
                y1 = b.A.Y;
                y2 = a.D.Y;
            }
            else if (a.A.Y > b.A.Y && a.D.Y > b.D.Y && a.D.Y < b.A.Y)
            {
                y1 = b.D.Y;
                y2 = a.A.Y;
            }
            else if (a.A.Y <= b.A.Y && a.D.Y >= b.D.Y)
            {
                y1 = b.A.Y;
                y2 = b.D.Y;
            }
            else if (a.A.Y >= b.A.Y && a.D.Y <= b.D.Y)
            {
                y1 = a.A.Y;
                y2 = a.D.Y;
            }
            else
            {
                y1 = 0;
                y2 = 0;
            }
            return new Rectangle(x1, y1, x2, y2);
        }
    }
}

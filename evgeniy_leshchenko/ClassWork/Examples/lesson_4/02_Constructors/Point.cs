﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Constructors
{
    class Point
    {
        // Поля.

        private int x, y;
        private string name;

        // Свойства.
        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        public string Name
        {
            get { return name; }
        }

        // Конструкторы.

        // Использование ключевого слова this в конструкторе  с одним параметром с 43-й строки,
        // приводит к вызову этого конструктора.
        public Point(int x, int y)
        {
            Console.WriteLine("Конструктор с двумя параметрами.");
            this.x = x;
            this.y = y;
        }

        // Использование ключевого слова this в конструкторе приводит к вызову конструктора с двумя параметрами с 35-й строки.
        public Point(string name)
            : this(300, 400) // вызывает сразу же и другой конструктор. Делается с целью не повторять один и тот же код много 
            //раз в разных перегруженных конструкторах 
        {
            Console.WriteLine("Конструктор с одним параметром.");
            this.name = name;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_HW005_4
{
    public class Store
    {
        private Article[] art;
        public int n { get; }
        public Article this[int index]
        {
            get
            {
                return art[index];
            }
            set
            {
                art[index] = value;
            }
        }
        public Store(int n)
        {
            this.n = n;
            art = new Article[n];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_05_06_Articles_HW_DLL
{
    class Store
    {
        private Article[] articles;

        public int indexArticle { get; }

        public Store(int indexArticle)
        {
            this.indexArticle = indexArticle;
        }

        public Article this[int index]
        {
            get
            {
                return articles[index];
            }
            set
            {
                articles[index] = value;
            }
        }
    }
}

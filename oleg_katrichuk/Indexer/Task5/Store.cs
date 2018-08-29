using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Store
    {

        private readonly Article[] articles;
        
        public Store (int size)
        {
            articles=new Article[size];
        }


        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < articles.Length)
                    return articles[index].Info();
                return "Index of rang exeption ";
            }
        }

        public void AddArticle(Article value, int index)
        {
            if (index >= 0 && index < articles.Length)
                articles[index] = value;
            else
            {
                Console.WriteLine("Write out array");
            }
            
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < articles.Length; i++)
                
                    if (articles[i].NameProduct == index)
                        return articles[i].Info();
                    return string.Format("No product : {0} ", index);
                
            }
        }
        public void Show()
        {
            foreach (var product in articles)
            {
                Console.WriteLine(product.Info());
            }
        }

        public void Sort()
        {
            for (int i = 0; i <= articles.Length-1; i++)
            {
                for (int j = 0; j <= articles.Length-1; j++)
                {
                    if (articles[i].Price <= articles[j].Price)
                    {
                        Article temp = articles[i];
                        articles[i] = articles[j];
                        articles[j] = temp;
                    }
                }
            }
        }


       
    }
}

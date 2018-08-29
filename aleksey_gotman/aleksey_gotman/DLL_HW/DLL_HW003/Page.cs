using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_HW003
{
    class Page
    {
        object Head;
        object Futer;
    }
    class Main : Page
    {
        object bodyMain;
    }
    class Catalog : Page
    {
        object bodyCatalog;
        List<Article> articles = new List<Article>();
    }
    class About : Page
    {
        object bodyAbout;
    }
    class Article : Page
    {
        Articles bodyArticles;
    }
    
}

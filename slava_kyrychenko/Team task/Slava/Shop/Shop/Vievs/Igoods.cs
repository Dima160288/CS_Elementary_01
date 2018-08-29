using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Models;
using Shop.Presenters;
using Shop.Vievs;

namespace Shop.Vievs
{
    public  interface Igoods
    {
        string CategoryGoodsText { get; set; }
        string NameGoodsText { get; set; }
        string DescriptionGoodsText { get; set; }
        string PriceGoodsText { get; set; }
        string RatingGoodsText { get; set; }
        string IdGoodsText { get; set; }

        List<object> GoodsCollection { get; set; }
        

    }
}

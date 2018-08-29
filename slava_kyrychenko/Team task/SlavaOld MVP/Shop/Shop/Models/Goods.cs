using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Models
{
    class Goods
    {
        public string CategoryGoods { get; set; }
        public string NameGoods { get; set; }
        public string DescriptionGoods { get; set; }
        public double PriceGoods { get; set; }
        public double RatingGoods { get; set; }
        public int IdGoods { get; set; }

        public Goods() { }

        public Goods(string CategoryGoods, string NameGoods, string DescriptionGoods, double PriceGoods, double RatingGoods, int IdGoods)
        {
            this.CategoryGoods = CategoryGoods;
            this.NameGoods = NameGoods;
            this.DescriptionGoods = DescriptionGoods;
            this.PriceGoods = PriceGoods;
            this.RatingGoods = RatingGoods;
            this.IdGoods = IdGoods;

        }

        public List<Goods> GoodsCollection()
        {
            List<Goods> p = new List<Goods>();


            return p;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Models;
using Shop.Vievs;

namespace Shop.Presenters
{
   public class GoodsPresenter
    {
        Igoods goodsViews;

        public GoodsPresenter(Igoods view)
        {
            goodsViews = view;

        }

        public void CollectionsPresenter()
        {
            Goods goods = new Goods();
            goods.CategoryGoods = goodsViews.CategoryGoodsText;
            goods.DescriptionGoods = goodsViews.DescriptionGoodsText;
            goods.IdGoods = int.Parse( goodsViews.IdGoodsText);
            goods.NameGoods = goodsViews.NameGoodsText;
            goods.PriceGoods = double.Parse(goodsViews.PriceGoodsText);
            goods.RatingGoods = double.Parse(goodsViews.RatingGoodsText);
            Goods g = new Goods(goods.CategoryGoods,goods.NameGoods, goods.DescriptionGoods,goods.PriceGoods, goods.RatingGoods, goods.IdGoods);


            goodsViews.GoodsCollection = g.GoodsCollection();

        }

       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop.Vievs;
using Shop.Presenters;

namespace Shop
{
    public partial class Form1 : Form , Igoods
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string CategoryGoodsText { get => textBoxCategory.Text ; set => textBoxCategory.Text=value; }
        public string NameGoodsText { get => textBoxName.Text; set => textBoxName.Text= value; }
        public string DescriptionGoodsText { get => textBoxDescription.Text; set => textBoxDescription.Text =value; }
        public string PriceGoodsText { get => textBoxPrice.Text; set => textBoxPrice.Text = value; }
        public string RatingGoodsText { get => textBoxRating.Text; set => textBoxRating.Text= value; }
        public string IdGoodsText { get => textBoxId.Text; set => textBoxId.Text = value; }
        public List<object> GoodsCollection { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        // public string SummText { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            GoodsPresenter presenter = new GoodsPresenter(this);
            presenter.Summ();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void buttonAddGoods_Click(object sender, EventArgs e)
        {
           
        }
    }
}

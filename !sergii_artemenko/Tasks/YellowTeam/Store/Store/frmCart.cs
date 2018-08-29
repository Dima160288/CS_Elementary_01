using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class frmCart : Form
    {
        public frmCart()
        {
            InitializeComponent();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            // из значения поля Count выбранной строки таблицы Product базы данных отнимает значение свойства nudCountToBuy.Value и записывает его. Закрывает окно с сообщением об успешной покупке
            MessageBox.Show("Congratulations! You just made a purchase.");
            FrmCartProvider.FrmCart.Close();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // очищает значения свойства Text лейблов lblProductNameData, lblDescriptionData, lblPriceData, lblRateData
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Закрывает окно
            FrmCartProvider.FrmCart.Close();
        }
    }
}

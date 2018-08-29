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
    public partial class frmAddGood : Form
    {
        public frmAddGood()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Закрывает окно
            FrmAddGoodProvider.FrmAddGood.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // добавляет значения в пустой строке в базе данных(Products) значения введенные в текстовых боксах и закрывает окно с сообщением об успешном добавлении товара
            MessageBox.Show("Good successfully added");
            FrmAddGoodProvider.FrmAddGood.Close();
        }
    }
}

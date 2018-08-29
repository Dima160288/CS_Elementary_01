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
    public partial class frmChangeGood : Form
    {
        public frmChangeGood()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            // заменяет значения выбранной строки в базе данных (Products) на значения введенные в текстовых боксах и закрывает окно с сообщением об успешном изменении товара
            MessageBox.Show("Selected good has been updated successfully");
            FrmChangeGoodProvider.FrmChangeGood.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Закрывает окно
            FrmChangeGoodProvider.FrmChangeGood.Close();
        }
    }
}

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
    public partial class frmShop : Form
    {
        public frmShop()
        {
            InitializeComponent();
        }

        private void btnRemoveGoods_Click(object sender, EventArgs e)
        {
            // Удаляет выбранный в списке(dgvStore) товар из базы данных (таблица Products)
            MessageBox.Show("You remove this good to cart.");
        }

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            // Добавить выбранный товар в корзину (frmCart)
            MessageBox.Show("You add this good to cart.");
        }

        private void btnChangeGoods_Click(object sender, EventArgs e)
        {
            // Вызывает окно изменения товара (frmChangeGood) с уже внесенным в него выбранным товаром
            FrmChangeGoodProvider.FrmChangeGood.Show();
        }

        private void btnAutorization_Click(object sender, EventArgs e)
        {
            // Выход из формы магазина (frmShop) и вызов формы авторизации (frmAutorization)
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Выход из программы
            if (MessageBox.Show("Do you really want to exit?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                Application.Exit();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Обновление списка товаров, если после добавления товара список не обновился
        }

        private void btnGotoCart_Click(object sender, EventArgs e)
        {
            // Открывает окно Корзины с выбранным товаром (frmCart)
            FrmCartProvider.FrmCart.Show();
        }

        private void btnAddGoods_Click(object sender, EventArgs e)
        {
            // Вызывает окно добавления товара (frmAddGood) с уже внесенным в него выбранным товаром
            FrmAddGoodProvider.FrmAddGood.Show();
        }
    }
}

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
    public partial class frmAutorization : Form
    {
        public frmAutorization()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Скрывает окно авторизации (frmAutorization) и открывает окно регистрации (frmRegistration)
            FrmAutorizationProvider.FrmAutorization.Close();
            FrmRegistrationProvider.FrmRegistration.Show();
            //При FrmRegistrationProvider.FrmRegistration обращении к FrmRegistrationProvider.FrmRegistration будет создан. Любое последующее попадание в свойство 
            //FrmRegistrationProvider.FrmRegistration возвращает форму, созданную при первом доступе. Это означает, что форма будет создаваться только один раз.
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // сверяет наличие логина и пароля с наличием таких в базе данных (User)
        }

        private void btnUnreg_Click(object sender, EventArgs e)
        {
            FrmAutorizationProvider.FrmAutorization.Close();
            FrmShopProvider.FrmShop.Show();
            // закрывает окно авторизации (frmAutorization) и открывает окно магазина (frmShop) co скрытыми кнопками btnAddGoods, btnRemoveGoods, btnAddtoCart, btnChangeGoods, btnGotoCart
        }
    }
}

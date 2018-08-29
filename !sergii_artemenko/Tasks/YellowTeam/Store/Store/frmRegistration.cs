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
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // закрывает форму регистрации(frmRegistration) и открывает форму авторизации(frmAutorization)
            FrmRegistrationProvider.FrmRegistration.Close();
            FrmAutorizationProvider.FrmAutorization.Show();
        }

        private void btnRegisterReg_Click(object sender, EventArgs e)
        {
            // После заполнения полей регистрации заносит запись в базу данных в таблицу "User", создавая нового пользователя.
        }
    }
}

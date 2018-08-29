using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Store
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            if (User.UserCategory > 0)
            {
                btnAddGoods.Hide();
                btnRemoveGoods.Hide();
                btnChangeGoods.Hide();
                if(User.UserCategory > 1)
                {
                    btnAddtoCart.Hide();
                    btnGotoCart.Hide();
                    btnAutorization.Show();
                }
            }


            const string strDBname = @"Store.db";
            const string sql = "select * from Products;";
            var connection = new SQLiteConnection("Data Source=" + strDBname + ";Version=3;");
            try
            {
                connection.Open();
                DataSet ds = new DataSet();
                var da = new SQLiteDataAdapter(sql, connection);
                da.Fill(ds);
                dgvStore.DataSource = ds.Tables[0].DefaultView;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddGoods_Click(object sender, EventArgs e)
        {
            AddGood addGood = new AddGood();
            addGood.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void btnGotoCart_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();
        }

        private void btnAutorization_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnChangeGoods_Click(object sender, EventArgs e)
        {
            ChangeGood changeGood = new ChangeGood();
            changeGood.Show();
        }
    }
}

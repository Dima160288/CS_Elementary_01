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
    public partial class AddGood : Form
    {
        public AddGood()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //ДОбавляем товар в базу
            const string databaseName = @"D:\VS_Projects\CS Elementary Console\elementary01\hlib_tynkovan\Store\Store\Store.db";
            SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", databaseName));
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("INSERT INTO 'Products' ('Name', 'Category', 'Description', 'Count', 'Price', 'Rate') VALUES ('" + txbProductName.Text + "', '" + txbCategory.Text + "', '" + txbDescription.Text + "', '" + Convert.ToInt32(txbCount.Text) + "', '" + Convert.ToInt32(txbPrice.Text) + "', '" + Convert.ToInt32(txbRate.Text) + "');", connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Good successfully added!");
            Close();
        }
    }
}

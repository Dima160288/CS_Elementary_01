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

namespace SQLite_demo
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            DbConnect connect = new DbConnect();
            using (SQLiteConnection connection = new SQLiteConnection(connect.connectionString))
            {
                try         // Добавление данных в БД
                {
                    string sql = @"INSERT INTO Product(Category, Name, Description, Price, Rating, Quantity) VALUES(@Category, @Name, @Description, @Price, @Rating, @Quantity)";
                    SQLiteCommand cmd = new SQLiteCommand(sql, connection);
                    connection.Open();
                    cmd.Parameters.Add(new SQLiteParameter("@Category", textCategory.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Name", textName.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Description", textDescription.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Price", textPrice.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Rating", textRating.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@Quantity", textQuantity.Text));

                    int ExeNonQuerry = cmd.ExecuteNonQuery();

                    if (ExeNonQuerry == 1)
                    {
                        MessageBox.Show("Product added successfully.");
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    connection.Close();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        private void DisplayStore_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

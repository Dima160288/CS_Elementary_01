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
    public partial class DisplayStore : Form
    {
        static DbConnect connect = new DbConnect();
        SQLiteConnection connection;
        SQLiteCommand cmd;
        SQLiteDataAdapter dataAdapter;
        DataTable dataTable = new DataTable();

        public DisplayStore()
        {
            InitializeComponent();
            SetupDisplayStore();
        }

        public void ButtonRefresh_Click(object sender, EventArgs e)
        {
            Retrieve();
        }

        private void SetupDisplayStore()
        {
            ViewStore.MultiSelect = false;
            ViewStore.FullRowSelect = true;
        }

        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct addProductShowFrom = new AddProduct();
            addProductShowFrom.Show();
        }

        private void ButtonDeleteProduct_Click(object sender, EventArgs e)
        {
            int selectedIndex = ViewStore.SelectedIndices[0];
            if (selectedIndex != -1)
            {
                String selected = ViewStore.SelectedItems[0].SubItems[0].Text;
                int id = Convert.ToInt32(selected);
                Delete(id);
            }
        }

        private void DisplayStore_Load(object sender, EventArgs e)
        {
            Retrieve();
        }

        public void Retrieve()      //получаем базу данных и записываем в таплицу
        {
            ViewStore.Items.Clear();
            using (connection = new SQLiteConnection(connect.connectionString))
            {
                connection.Open();
                cmd = new SQLiteCommand("SELECT *  FROM product", connection);
                try
                {
                    dataAdapter = new SQLiteDataAdapter(cmd);
                    dataAdapter.Fill(dataTable);
                    foreach (DataRow dr in dataTable.Rows)      //Заполнение таблицы ListView
                    {
                        ListViewItem item = new ListViewItem(dr["ID"].ToString());
                        item.SubItems.Add(dr["category"].ToString());
                        item.SubItems.Add(dr["name"].ToString());
                        item.SubItems.Add(dr["description"].ToString());
                        item.SubItems.Add(dr["price"].ToString());
                        item.SubItems.Add(dr["rating"].ToString());
                        item.SubItems.Add(dr["quantity"].ToString());
                        ViewStore.Items.Add(item);
                    }
                    connection.Close();
                    dataTable.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void Delete(int id) //delete from database
        {
            string sql = "DELETE FROM product WHERE ID=" + id + "";
            using (SQLiteConnection connection = new SQLiteConnection(connect.connectionString))
            {
                cmd = new SQLiteCommand(sql, connection);
                try
                {
                    connection.Open();
                    dataAdapter = new SQLiteDataAdapter(cmd)
                    {
                        DeleteCommand = connection.CreateCommand()
                    };
                    dataAdapter.DeleteCommand.CommandText = sql;
                    if (MessageBox.Show(@"Are you sure to permanently delete this?", @"DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show(@"Successfully deleted");
                        }
                    }
                    connection.Close();
                    Retrieve();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.Close();
                }

            }
        }

        public void Update(int ID, string category, string name, string description, double price, double rating, int quantity)
        {
            // int ID, string name, string description, string category, double price, double rating, int quantity)
            string sql = "UPDATE product SET category='" + category + "',name='" + name + "',description='" + description + "'," +
                " price ='" + price + "', rating='" + rating + "', quantity='" + quantity + "' WHERE ID='" + ID + "'";
            cmd = new SQLiteCommand(sql, connection);
            using (connection = new SQLiteConnection(connect.connectionString))
            {
                try
                {
                    connection.Open();
                    dataAdapter = new SQLiteDataAdapter(cmd)
                    {
                        UpdateCommand = connection.CreateCommand()
                    };

                    dataAdapter.UpdateCommand.CommandText = sql;

                    if (dataAdapter.UpdateCommand.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show(@"Successfully Updated");
                    }
                    connection.Close();
                    Retrieve();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
            }
        }

        private void ViewStore_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DisplayStore_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ViewStore_DoubleClick(object sender, EventArgs e)
        {
            int selectedIndex = ViewStore.SelectedIndices[0];
            if (selectedIndex != -1)
            {
                String selected = ViewStore.SelectedItems[0].SubItems[0].Text;
                int id = Convert.ToInt32(selected);
                UpdateProduct updateProduct = new UpdateProduct(ViewStore.Items[id-1]);
                updateProduct.Show();
            }

        }
    }
}



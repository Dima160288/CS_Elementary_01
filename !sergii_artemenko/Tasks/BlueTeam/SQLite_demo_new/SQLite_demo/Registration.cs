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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            if (textUsername.Text != string.Empty && textPassword.Text != string.Empty && textPasswordConfirm.Text != string.Empty && textEmail.Text != string.Empty)
            {
                if (textPassword.Text == textPasswordConfirm.Text)
                {
                    AccountCheck(textUsername.Text);
                }
                else
                {
                    MessageBox.Show("Passwords doesnt match!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void AccountCheck(string username)
        {
            DbConnect connect = new DbConnect();
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connect.connectionString))
                {
                    connection.Open();
                    int userCount = 0;
                    string sql = @"SELECT Username, Password, email FROM UserData WHERE Username= '" + username + "'";
                    SQLiteCommand cmd = new SQLiteCommand(sql, connection);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        userCount++;
                    }
                    if (userCount == 1)
                    {
                        MessageBox.Show("User with this name already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (userCount == 0)
                    {
                        InsertData(textUsername.Text, textPassword.Text, textEmail.Text);
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void InsertData(string username, string password, string email)
        {
            DbConnect connect = new DbConnect();
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connect.connectionString))
                {
                    connection.Open();
                    string sql = @"INSERT INTO UserData(Username, Password, Email) VALUES (@username, @password, @email)";
                    SQLiteCommand cmd = new SQLiteCommand(sql, connection);
                    cmd.Parameters.Add(new SQLiteParameter("@username", username));
                    cmd.Parameters.Add(new SQLiteParameter("@password", password));
                    cmd.Parameters.Add(new SQLiteParameter("@email", email));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Succes!", "Succes", MessageBoxButtons.OK);
                    connection.Close();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

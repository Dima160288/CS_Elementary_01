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
using System.IO;

namespace SQLite_demo
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (textUsername.Text != string.Empty && textPassword.Text != string.Empty)
            {
                UserCheck(textUsername.Text, textPassword.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void LoginWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ButtonRegisterNewUser_Click(object sender, EventArgs e)
        {
            Registration showRegistration = new Registration();
            showRegistration.Show();
        }

        private void UserCheck(string username, string password)
        {
            DbConnect connect = new DbConnect();
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connect.connectionString))
                {
                    connection.Open();
                    int userCount = 0;
                    string sql = @"SELECT Username, Password, email FROM UserData WHERE Username= '" + username + "' and Password = '" + password + "' ";
                    SQLiteCommand cmd = new SQLiteCommand(sql, connection);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        userCount++;
                    }
                    if (userCount == 1)
                    {
                        MessageBox.Show("Login succes!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        DisplayStore f2 = new DisplayStore();
                        f2.ShowDialog();
                        this.Close();
                    }
                    else if (userCount == 0)
                    {
                        MessageBox.Show("Incorrect username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

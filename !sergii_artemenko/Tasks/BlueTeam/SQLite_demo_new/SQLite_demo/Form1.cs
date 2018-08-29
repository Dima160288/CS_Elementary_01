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
            if (users.Contains(textUsername.Text) && password.Contains(textPassword.Text) && Array.IndexOf(users.ToArray(), textUsername.Text) == Array.IndexOf(password.ToArray(), textPassword.Text))
            {
                this.Hide();
                DisplayStore f2 = new DisplayStore();
                f2.ShowDialog();
                this.Close();
            }
            else
            {
               MessageBox.Show("Username or password is incorrect!");
            }            
        }

        List<string> users = new List<string>();
        List<string> password = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("UserAndPass.txt");  // Считывание данных Юзер/Пароль из файла и запись в массивы users/password
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                string[] components = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                users.Add(components[0]);
                password.Add(components[1]);
            }
            sr.Close();
        }

        private void LoginWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}

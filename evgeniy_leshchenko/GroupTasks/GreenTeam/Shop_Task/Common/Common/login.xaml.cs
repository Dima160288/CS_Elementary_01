using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CRUD;


namespace Common
{
    /// <summary>
    /// Логика взаимодействия для login.xaml
    /// </summary>
    public partial class login : Window
    {

        public login()
        {
            InitializeComponent();
            txtEmail.Focus();
        } 



        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            DB.SetConn(); // !!!!  временно, пока не все перешли на CRUD

            SqlLite sq = new SqlLite();
            if (sq.SetConnection("Data Source=../../ShopDB.db") == false)
            {
                MessageBox.Show("Ошибка соединения с базой данных. Попробуйте войти позже.");
                return;
            }

            if (Login.CheckUser(txtEmail.Text, txtPW.Password) == true)
            {

                MainWindow MW = new MainWindow();

                MW.Show();
                MW.FillGrid();
                this.Close();

            }
            else
            {
                MessageBox.Show("Данный пользователь не найден.");
                txtPW.Password = "";
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {

            SqlLite sq = new SqlLite();
            sq.CloseConnection();
            this.Close();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            SqlLite sq = new SqlLite();
            if (sq.SetConnection("Data Source=../../ShopDB.db") == false)
            {
                MessageBox.Show("Ошибка соединения с базой данных. Попробуйте войти позже.");
                return;
            }

            Registration NW = new Registration();
            NW.Show();
            this.Close(); // hide?


        }
    }
}

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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {

        public Registration()
        {
            InitializeComponent();
            txtEmail.Focus();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            int NewUserID;

            if (checkFields() == false)
            {
                MessageBox.Show("Поля со * обязательны для заполнения.");
                return;
            }

            if (CheckPassword(txtPW.Password) == "Пароль должен содержать не менее 6 символов!")
                return;


                SqlLite sq = new SqlLite();

            NewUserID = Convert.ToInt16(sq.GetSingleSet("Select ifnull(max(UserID),0)+1 from UsersLogin"));

            sq.Create("UsersLogin", Convert.ToString(NewUserID) + ",'" + txtEmail.Text + "','" + txtPW.Password + "'", "UserID,Email,PW");

            if (txtFio.Text != "" || txtPhone.Text != "")
                sq.Create("Users", Convert.ToString(NewUserID) + ",'" + txtFio.Text + "','" + txtPhone.Text + "'", "UserID,Fio,Phone");


            //  MessageBox.Show("Регистрация прошла успешно, авторизируйтесь в программе.");

            login NW = new login();
            NW.Show();
            NW.txtRegConfirm.Content = "Регистрация прошла успешно, авторизируйтесь в программе.";
            NW.txtRegConfirm.Visibility = Visibility.Visible;
            this.Close();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            SqlLite sq = new SqlLite();
            sq.CloseConnection();
            this.Close();
        }


        private bool checkFields()
        {
            if (txtEmail.Text == "" || txtPW.Password == "")
            {
                return false;
            }
            return true;
        }

        private string CheckPassword(string PW)
        {
            string PwRes;
            PwRes = Convert.ToString(PasswordStrength.CheckPasswordStrength(txtPW.Password)); // проверка качества пароля

            if (PwRes == "Короткий") PwRes = "Пароль должен содержать не менее 6 символов!";

            return PwRes;

        }



   

        private void txtPW_KeyUp(object sender, KeyEventArgs e)
        {

            txtPWRes.Text = "Уровень пароля: " + CheckPassword(txtPW.Password);

        }


       
    }
}

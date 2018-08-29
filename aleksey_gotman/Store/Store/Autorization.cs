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
    public partial class Autorization : Form
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            Hide();
            Registration registration = new Registration();
            registration.Show();
        }

        private void btnUnreg_Click(object sender, EventArgs e)
        {
            Close();
            Main main = new Main();
            main.Show();
        }




        private void btnLogin_Click(object sender, EventArgs e)
        {

            SQLiteConnection connection = new SQLiteConnection(@"Data Source= Store.db");

            try
            {
                string email = txbEmail.Text;
                string pass = txbPassword.Text;
                string com = String.Format(@"SELECT IdUser AS A, IsAdmin AS B FROM Users WHERE Email LIKE '{0}' AND Pass LIKE '{1}'", email, pass);

                SQLiteCommand command = new SQLiteCommand(com, connection);
                SQLiteDataReader myReader;
                connection.Open();
                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    User.idUser = Convert.ToInt32(myReader["A"].ToString());
                    User.UserCategory = Convert.ToInt32(myReader["B"].ToString());
                }

                if (User.idUser == 0)
                {
                    lblAlert.ForeColor = Color.Red;
                    lblAlert.Visible = true;
                }
                else
                {
                    Main main = new Main();
                    Hide();
                    main.Show();
                }
                connection.Close();
            }
        
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
}

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.SQLite;

namespace Store
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
            Autorization autorization = new Autorization();
            autorization.Show();
        }

        private void btnRegisterReg_Click(object sender, EventArgs e)
        {
            if (txbPasswordReg.Text != txbConfPassword.Text)
            {
                lblRegAlert.Visible = true;
                lblRegAlert.ForeColor = Color.Red;
                lblRegAlert.Text = "Passwords do not match!";
            }
            else if (txbEmailReg.Text == "")
            {
                lblRegAlert.Visible = true;
                lblRegAlert.ForeColor = Color.Red;
                lblRegAlert.Text = "Field Email is Empty!";
            }
            else if (txbPasswordReg.Text == "" & txbConfPassword.Text == "")
            {
                lblRegAlert.Visible = true;
                lblRegAlert.ForeColor = Color.Red;
                lblRegAlert.Text = "Fields Passwords is Empty!";
            }
            else
            {
                const string databaseName = @"Store.db";
                SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", databaseName));
                string ch = null;
                try
                {
                    connection.Open();
                    SQLiteCommand check = new SQLiteCommand(@"SELECT COUNT (*) AS A FROM Users WHERE Email LIKE '" + txbEmailReg + "'", connection);
                    SQLiteDataReader reader = check.ExecuteReader();
                    //ШЛЯПА
                    reader.Read();
                    int i= Convert.ToInt32(reader["A"].ToString());
                    if (i==0)
                    {
                        SQLiteCommand command = new SQLiteCommand("INSERT INTO 'Users' ('Email', 'Pass', 'IsAdmin') VALUES ('" + txbEmailReg.Text + "', '" + txbPasswordReg.Text + "', 1);", connection);
                        command.ExecuteNonQuery();
                        connection.Close();
                        lblRegAlert.Visible = true;
                        lblRegAlert.ForeColor = Color.Green;
                        lblRegAlert.Text = "Register Complete! You may return to Log In window";
                    }
                    else
                    {
                        lblRegAlert.Visible = true;
                        lblRegAlert.ForeColor = Color.Red;
                        lblRegAlert.Text = "Email is used!";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.Close();
                }

                
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace multilogin
{
    public partial class Form4 : Form
    {
        //SQL database connectionString
        string connectionString = @"Data Source=NYASHA-PC\SQLEXPRESS;Initial Catalog=UseRegistrationDB;Integrated Security=True";
        public Form4()              
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //SubmitButton
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Check is password or username are free or not as well as making password and confirm password match.
            if (txtUsername.Text == "" || txtPassword.Text == "")
                MessageBox.Show("Please fill all fields!");
            else if (txtPassword.Text != txtConfirmPassword.Text)
                MessageBox.Show("Passwords do not Match!");
            else
            {


                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("[dbo].[UserAdd]", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Contact", txtContact.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@UserType", comboBox1.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Registration is Successfull !");
                    Clear();
                }
            }
        }
        //Clears TextFields After successful user data entry.
        void Clear()
        {
            txtFirstName.Text = txtLastName.Text = txtContact.Text = txtAddress.Text = txtUsername.Text 
                = txtPassword.Text = txtConfirmPassword.Text = ""; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}

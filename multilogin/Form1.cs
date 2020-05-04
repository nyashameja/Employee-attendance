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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void username_Click(object sender, EventArgs e)
        {

        }

        //databse used is :UseRegistrationDB
            private void login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=NYASHA-PC\\SQLEXPRESS;Initial Catalog=UseRegistrationDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from tblUser where Username='"+txtuser.Text+"' and Password='"+txtpass.Text+"'",con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
      
            DataTable dt = new DataTable();
            sda.Fill(dt);

            string cmbItemValue = comboBox1.SelectedItem.ToString();



            if(dt.Rows.Count > 0)
            {
                for(int i=0; i<dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["usertype"].ToString() == cmbItemValue)
                    {
                        MessageBox.Show("You are logged in as"+ " " + dt.Rows[i][1]);

                        if (comboBox1.SelectedIndex == 0)
                        {
                      
                            Form2 f = new Form2();
                            f.Show();
                            this.Hide();

                        } 
                        else
                        {
                            Form3 ff = new Form3();
                            ff.Show();
                            this.Hide();
                        }
                    }
                }


            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Unhides user password 
        private void checkBox_Show_Hide_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Show_Hide.Checked)
            {
                txtpass.UseSystemPasswordChar = false;
            }
            else
            {
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                label2.Text = DateTime.Now.ToLongTimeString();
                label3.Text = DateTime.Now.ToLongDateString();

        }
    }
}

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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            load_table();
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
            this.Close();
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                
            }

        }
        //This automatically loads the table from the database upon execution of panel
        void load_table()
        {
            //SqlConnection con = new SqlConnection("Data Source= NYASHA-PC\\SQLEXPRESS;Initial Catalog=cmblogin;Integrated Security=True");
            string constring = @"Data Source=NYASHA-PC\SQLEXPRESS;Initial Catalog=UseRegistrationDB;Integrated Security=True";
            SqlConnection conDataBase = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand("Select * from tblUser", conDataBase);

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //update button allows you to "refresh" the data from the database upon editing, inserting and or deleting. 
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source= NYASHA-PC\\SQLEXPRESS;Initial Catalog=cmblogin;Integrated Security=True");
            string constring = @"Data Source=NYASHA-PC\SQLEXPRESS;Initial Catalog=UseRegistrationDB;Integrated Security=True";
            SqlConnection conDataBase = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand("Select * from tblUser", conDataBase);

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Successful!");
            }

        }
        //Delete button does not work yet. all it does is clear the data from the gridview panel but not from the database(tblUser)
        private void btnDelete_Click(object sender, EventArgs e)
        {
           

            //string constring = @"Data Source=NYASHA-PC\SQLEXPRESS;Initial Catalog=UseRegistrationDB;Integrated Security=True";
            
            //string query = "DELETE FROM tblUser where Id ='" + textBox1.Text + "'";
            //SqlDataAdapter sda = new SqlDataAdapter(query, constring);
            //sda.SelectCommand.ExecuteNonQuery();
            
            //MessageBox.Show("Deleted Successfully!");
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Search box does not work yet.
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        
    }
}

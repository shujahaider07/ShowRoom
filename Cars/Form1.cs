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
using System.Threading;

namespace Cars
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // textBox1.KeyUp += TextBox1_KeyUp1;
            // textBox2.KeyUp += TextBox2_KeyUp;
            textBox1.KeyUp += TextBox1_KeyUp;
            textBox2.KeyUp += TextBox2_KeyUp1;
        }

        private void TextBox2_KeyUp1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                button1.Focus();
            }
        }

        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        /*private void TextBox1_KeyUp1(object sender, KeyEventArgs e)
            {
                textBox2.Focus();
            }*/

        private void TextBox2_KeyUp(object sender, KeyEventArgs e)
        {
            button1.Focus();
        }
/*
        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
          
        }
*/
        SqlConnection sql = new SqlConnection(@"Data Source=DESKTOP-C13GBHB\SQLEXPRESS01;Initial Catalog=showroom;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

            sql.Open();
            String qry = "select * from login where username = @user and password = @pass";
            SqlCommand cmd = new SqlCommand(qry,sql);
            cmd.Parameters.AddWithValue("@user",textBox1.Text);
            cmd.Parameters.AddWithValue("@pass",textBox2.Text);
            SqlDataReader dr = cmd.ExecuteReader();



            if (dr.HasRows == true)
            {
                MessageBox.Show("LOGIN SUCCESSFULL");
                for (int i = 0; i <100; i ++)
                {
                   // progressBar1.Value = 100;
                    //progressBar1.Minimum = 0;
                    //progressBar1.Maximum = 100;
                    //Thread.Sleep(10);
                   
                }

                cars c1 = new cars();
                c1.Show();
                this.Hide();
            }
            else if (String.IsNullOrEmpty(textBox1.Text) == true)
            {
                errorProvider1.SetError(textBox1, "Please fill the box");
                textBox1.Focus();
            }

            else {
               
                    MessageBox.Show("Failed, Invalid password/username");
                textBox2.Focus();
                
                
            }
           
          
            sql.Close();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}

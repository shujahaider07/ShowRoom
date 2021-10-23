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

namespace Cars
{
    public partial class registration : Form
    {
        public static string name;

        public registration()
        {
            InitializeComponent();
            rnametxt.KeyUp += Rnametxt_KeyUp;
            nictxt.KeyUp += Nictxt_KeyUp;
            Carnametxt.KeyUp += Carnametxt_KeyUp;
            enginetxt.KeyUp += Enginetxt_KeyUp;
            dateTimePicker1.KeyUp += DateTimePicker1_KeyUp;
            dateTimePicker2.KeyUp += DateTimePicker2_KeyUp;
            advancetxt.KeyUp += Advancetxt_KeyUp;
            remaingtxt.KeyUp += Remaingtxt_KeyUp;
            chassistxt.KeyUp += Chassistxt_KeyUp;
        }

        private void Chassistxt_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                ttlamont.Focus();
            }
        }

        private void Remaingtxt_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
             chassistxt.Focus();
            }
        }

        private void Advancetxt_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                remaingtxt.Focus();
            }
        }

        private void DateTimePicker2_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                advancetxt.Focus();
            }
        }

        private void DateTimePicker1_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                dateTimePicker2.Focus();
            }
        }

        private void Enginetxt_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                dateTimePicker1.Focus();
            }
        }

        private void Carnametxt_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                enginetxt.Focus();
            }
        }

        private void Nictxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                Carnametxt.Focus();
            }
        }

        private void Rnametxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                nictxt.Focus();
            }
        }

        SqlConnection sql = new SqlConnection(@"Data Source=DESKTOP-C13GBHB\SQLEXPRESS01;Initial Catalog=showroom;Integrated Security=True");

        private void registration_Load(object sender, EventArgs e)
        {
            rnametxt.Text = cars.text1;
            ttlamont.Text = cars.text2;
           
          
                  
            
        }
        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String book = dateTimePicker1.Text;
            String delivery = dateTimePicker2.Text;
            
            sql.Open();
            String qry = "insert into registration values('" + rnametxt.Text + "', '" + nictxt.Text + "','" + chassistxt.Text + "','"+enginetxt.Text+"','"+book+"','"+delivery+"','"+advancetxt.Text+"','"+remaingtxt.Text+"','"+Carnametxt.Text+"','"+ttlamont.Text+"')";
            SqlCommand cmd = new SqlCommand(qry, sql);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Inserted");
           


            sql.Close();



        }
    }
}

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
using System.Diagnostics;

namespace Cars
{
    public partial class registration : Form
    {
        public static string name; 

        public registration()
        {

           
            InitializeComponent();

          
            RegistrationName();
            rnametxt.KeyUp += Rnametxt_KeyUp;
            maskedTnictxtextBox1.KeyUp += MaskedTnictxtextBox1_KeyUp;
            comboBox1.KeyUp += ComboBox1_KeyUp;
            enginetxt.KeyUp += Enginetxt_KeyUp;
            dateTimePicker1.KeyUp += DateTimePicker1_KeyUp;
            dateTimePicker2.KeyUp += DateTimePicker2_KeyUp;
            advancetxt.KeyUp += Advancetxt_KeyUp;
            remaingtxt.KeyUp += Remaingtxt_KeyUp;
            chassistxt.KeyUp += Chassistxt_KeyUp;
            ttlamont.KeyUp += Ttlamont_KeyUp;

        }

        private void Ttlamont_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                button1.Focus();
            }
        }

        private void ComboBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                enginetxt.Focus();
            }
        }

        private void MaskedTnictxtextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboBox1.Focus();
            }
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

     

        private void Rnametxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                maskedTnictxtextBox1.Focus();
            }
        }

        SqlConnection sql = new SqlConnection(@"Data Source=DESKTOP-C13GBHB\SQLEXPRESS01;Initial Catalog=showroom;Integrated Security=True");

        private void registration_Load(object sender, EventArgs e)
        {
            //chassistxt.Text = "Ch-";
            fetchCars();

            
            
            rnametxt.Text = cars.text1;
            maskedTnictxtextBox1.Text = cars.text2;
            chassistxt.Text = cars.text3;
            enginetxt.Text = cars.text4;
            dateTimePicker1.Text = cars.text5;
            dateTimePicker2.Text = cars.text6;
            advancetxt.Text = cars.text7;
            remaingtxt.Text = cars.text8;
            comboBox1.Text = cars.text9;
            ttlamont.Text = cars.text10;
            
           

        }
        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(rnametxt.Text) == true)
            {
                MessageBox.Show("Please fill the box");
                rnametxt.Focus();

            }else if (String.IsNullOrEmpty(maskedTnictxtextBox1.Text) == true)
            {
                MessageBox.Show("Please fill the box");

            }
            else if (String.IsNullOrEmpty(comboBox1.Text) == true)
            {
                MessageBox.Show("Please fill the box");

            }
            else if (String.IsNullOrEmpty(enginetxt.Text) == true)
            {
                MessageBox.Show("Please fill the box");

            }
            else if (String.IsNullOrEmpty(maskedTnictxtextBox1.Text) == true)
            {
                MessageBox.Show("Please fill the box");

            }
            else if (String.IsNullOrEmpty(dateTimePicker1.Text) == true)
            {
                MessageBox.Show("Please fill the box");

            }
            else if (String.IsNullOrEmpty(dateTimePicker2.Text) == true)
            {
                MessageBox.Show("Please fill the box");

            }
            else if (String.IsNullOrEmpty(advancetxt.Text) == true)
            {
                MessageBox.Show("Please fill the box");

            }
            else if (String.IsNullOrEmpty(remaingtxt.Text) == true)
            {
                MessageBox.Show("Please fill the box");

            }
            else if (String.IsNullOrEmpty(chassistxt.Text) == true)
            {
                MessageBox.Show("Please fill the box");

            }
            else if (String.IsNullOrEmpty(maskedTnictxtextBox1.Text) == true)
            {
                MessageBox.Show("Please fill the box");

            }
            else if (String.IsNullOrEmpty(ttlamont.Text) == true)
            {
                MessageBox.Show("Please fill the box");

            }
            else
            {
                
                    String book = dateTimePicker1.Text;
                    String delivery = dateTimePicker2.Text;

                    sql.Open();
                    String qry = "insert into registration values('" + rnametxt.Text + "', '" + maskedTnictxtextBox1.Text + "','" + chassistxt.Text + "','" + enginetxt.Text + "','" + book + "','" + delivery + "','" + advancetxt.Text + "','" + remaingtxt.Text + "','" + comboBox1.Text + "','" + ttlamont.Text + "')";
                    SqlCommand cmd = new SqlCommand(qry, sql);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Inserted");
                    sql.Close();


               
            }
       }
        public void RegistrationName()
        {
            rnametxt.Text = registrationDetail.value1;
        }

     public void fetchCars()
        {
            sql.Open();
            String qry = "select carnamee from cars";
            SqlCommand cmd = new SqlCommand(qry,sql);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                String cars = dr.GetString(0);
                comboBox1.Items.Add(cars);
            }




            sql.Close();
        }

        private void advancetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch =  e.KeyChar;
            if (char.IsLetter(ch))
            {
                e.Handled = true;
            }else if (e.KeyChar == 8 )
            {
                e.Handled = false;

            }else
            {
                e.Handled = false;
            }
        }

        private void remaingtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch))
            {
                e.Handled = true;
            }else if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = false;
            }

        }

        private void ttlamont_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch))
            {
                e.Handled = true;
            }else if (e.KeyChar == 8 )
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = false;
            }
        }

        private void chassistxt_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

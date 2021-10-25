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
    public partial class registrationDetail : Form
    {
        public static string value1;
        public registrationDetail()
        {
            InitializeComponent();
        }
        SqlConnection sql = new SqlConnection(@"Data Source=DESKTOP-C13GBHB\SQLEXPRESS01;Initial Catalog=showroom;Integrated Security=True");

        private void registrationDetail_Load(object sender, EventArgs e)
        {
          

            textBox1.Text = registration.name;

            styleGridView2();
            sql.Open();
            String qry = "select * from registration";
            SqlDataAdapter da = new SqlDataAdapter(qry,sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            sql.Close();
            link();

        }

        public void styleGridView2()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("calibri", 9);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        public void search()
        {
            sql.Open();
            string qry = "SELECT * FROM registration WHERE Name LIKE  '%" + textBox1.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(qry,sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            sql.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            search();
           
        }
           public void link()
        {
           

            DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
            Editlink.UseColumnTextForLinkValue = true;
            Editlink.HeaderText = "Edit";
            Editlink.DataPropertyName = "lnkColumn";
            Editlink.LinkBehavior = LinkBehavior.SystemDefault;
            Editlink.Text = "Edit";
            Editlink.Name = "Edit";
            dataGridView1.Columns.Add(Editlink);

            
            DataGridViewLinkColumn Delete = new DataGridViewLinkColumn();
            Delete.UseColumnTextForLinkValue = true;
            Delete.HeaderText = "Delete";
            Delete.DataPropertyName = "Delete";
            Delete.LinkBehavior = LinkBehavior.SystemDefault;
            Delete.Text = "Delete";
            Delete.Name = "Delete";
            dataGridView1.Columns.Add(Delete);


        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                registration r1 = new registration();
                r1.Show();
                dataGridView1.CurrentRow.Selected = true;
                value1 = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                value1 = dataGridView1.Rows[e.RowIndex].Cells["CarNamee"].Value.ToString();

          
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
               
                cars.text1 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                cars.text2 = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                cars.text3 = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                cars.text4 = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                cars.text5 = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                cars.text6 = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                cars.text7 = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                cars.text8 = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                cars.text9 = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                cars.text10 = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                registration r = new registration();
                r.Show();
                sql.Open();
                String qry = "update registration set name = '" + cars.text1 + "', Nic = '" + cars.text2 + "',Chassisno = '" + cars.text3 + "', Engineno '"+cars.text4+"',bookingdate = '"+cars.text5+"'delivery = '"+cars.text6+"' , advance = '"+cars.text7+"',remainingamount = '"+cars.text8+"',carname = ''"+cars.text9+",totalamount = '"+cars.text10+ "' where nic ='" + cars.text2 + "'";
                SqlCommand cmd = new SqlCommand(qry,sql);
                cmd.ExecuteNonQuery();
                MessageBox.Show("RECORD UPDATED!");
                

                sql.Close();



            }
        }

       
    }
}

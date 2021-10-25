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
    public partial class cars : Form
    {
        public static String text1;
        public static String text2;

        
        

        public static String text3;
        public static String text4;
        public static String text5;
        public static String text6;
        public static String text7;
        public static String text8;
        public static String text9;
        public static String text10;
       
       
        public cars()
        {
            InitializeComponent();
            refreshData();
            count();
        }
        SqlConnection sql = new SqlConnection(@"Data Source=DESKTOP-C13GBHB\SQLEXPRESS01;Initial Catalog=showroom;Integrated Security=True");
        private void cars_Load(object sender, EventArgs e)
        {
            count();
            styleGridView2();
            sql.Open();
            String qry = "select * from cars ";
            SqlDataAdapter da = new SqlDataAdapter(qry,sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            


            sql.Close();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cars2 c2 = new cars2();
            c2.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            count();
            sql.Open();
            String qry1 = "select * from cars ";
            SqlDataAdapter da = new SqlDataAdapter(qry1, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sql.Close();
     
        }
        public void refreshData()
        {

            String qry = "select * from cars ";
            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
           
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            text9= dataGridView1.Rows[e.RowIndex].Cells["CarNamee"].Value.ToString();
            text10 = dataGridView1.Rows[e.RowIndex].Cells["price"].Value.ToString();



            registration r1 = new registration();
            r1.Show();

          
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

        private void button3_Click(object sender, EventArgs e)
        {
            registration r1 = new registration();
            r1.Show();
            


        }

        private void button4_Click(object sender, EventArgs e)
        {
            registrationDetail rd = new registrationDetail();
            rd.Show();
        }
        public void count()
           {
            sql.Open();
            string qry = "select count (carnamee) from cars";
            SqlCommand cmd = new SqlCommand(qry,sql);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                String value = dr[0].ToString();
                label3.Text = value + " Cars are Available";
                label3.Visible = true;
                
            }



            sql.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {



        }
    }



}
    
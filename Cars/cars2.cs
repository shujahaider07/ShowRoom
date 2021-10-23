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
    public partial class cars2 : Form
    {
        public cars2()
        {
            InitializeComponent();
            carnametxt.KeyUp += Carnametxt_KeyUp;
           
            modelnametxt.KeyUp += Modelnametxt_KeyUp;
            Pricetxt.KeyUp += Pricetxt_KeyUp1;
        }

        private void Pricetxt_KeyUp1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                button1.Focus();
            }
        }

        private void Modelnametxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                Pricetxt.Focus();
            }
        }

       

        private void Carnametxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Enter)
            {
                modelnametxt.Focus();
            }
        }

        SqlConnection sql = new SqlConnection(@"Data Source=DESKTOP-C13GBHB\SQLEXPRESS01;Initial Catalog=showroom;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            sql.Open();
            String qry = "insert into cars values('"+carnametxt.Text+"', '"+ Pricetxt.Text + "','"+modelnametxt.Text+"')" ;
            SqlCommand cmd = new SqlCommand(qry,sql);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Inserted");

           


            
            String qry1 = "select * from cars ";
            SqlDataAdapter da = new SqlDataAdapter(qry1, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sql.Close();
        }

        private void cars2_Load(object sender, EventArgs e)
        {
            styleGridView2();
            sql.Open();
            String qry = "select * from cars ";
            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;



            sql.Close();

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            carnametxt.Text = dataGridView1.Rows[e.RowIndex].Cells["CarNamee"].Value.ToString();
            modelnametxt.Text = dataGridView1.Rows[e.RowIndex].Cells["Model"].Value.ToString();
            Pricetxt.Text = dataGridView1.Rows[e.RowIndex].Cells["price"].Value.ToString();


        }
    }
}

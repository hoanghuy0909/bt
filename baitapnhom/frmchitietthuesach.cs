using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace baitapnhom
{
    public partial class frmchitietthuesach : Form
    {
        
        public frmchitietthuesach()
        {
            InitializeComponent();
        }

        private void frmchitietthuesach_Load(object sender, EventArgs e)
        {
            DAO.connect();
            loaddata();
        }
        private void loaddata()
        {
            
            string sql = "select * from chitietthuesach";
            SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            DataTable tblchitietthuesach = new DataTable();
            adp.Fill(tblchitietthuesach);
            dataGridView1.DataSource = tblchitietthuesach;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmathue.Text = dataGridView1.CurrentRow.Cells["mathue"].Value.ToString();
            txtmasach.Text = dataGridView1.CurrentRow.Cells["masach"].Value.ToString();
            txtmatinhtrang.Text = dataGridView1.CurrentRow.Cells["matinhtrang"].Value.ToString();
            txtdatra.Text = dataGridView1.CurrentRow.Cells["datra"].Value.ToString();
            txtmathue.Enabled = false;
            txtmasach.Enabled = false;
            
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DAO.con.Close();
            this.Close();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtmasach.Text = "";
            txtmathue.Text = "";
            txtmatinhtrang.Text = "";
            txtdatra.Text = "";
            txtmathue.Enabled = true;
            txtmasach.Enabled = true;
            
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from chitietthuesach where mathue= '" + txtmathue.Text + "'";
            SqlCommand cmd = new SqlCommand(sql,DAO.con);
            cmd.ExecuteNonQuery();
            loaddata();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtmathue.Text == "")
            {
                MessageBox.Show("mã thuê còn trống");

            }
            if (txtmasach.Text == "")
            {
                MessageBox.Show("mã sach còn trống");
            }
            if (txtmatinhtrang.Text == "")
            {
                MessageBox.Show("mã tình trạng còn trống");
            }
            if (txtdatra.Text == "")
            {
                MessageBox.Show("đã trả còn trống");
            }
            else
            {
                try
                {
                    string sql = "insert into chitietthuesach values (@mathue, @masach,@matinhtrang,@datra)";
                    SqlCommand cmd = new SqlCommand(sql, DAO.con);
                    cmd.Parameters.AddWithValue("mathue", txtmathue.Text);
                    cmd.Parameters.AddWithValue("masach", txtmasach.Text);
                    cmd.Parameters.AddWithValue("matinhtrang", txtmatinhtrang.Text);
                    cmd.Parameters.AddWithValue("datra", txtdatra.Text);
                    cmd.ExecuteNonQuery();
                    loaddata();
                }catch(Exception d)
                {
                    MessageBox.Show(d.ToString());
                }

            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtmatinhtrang.Text == "")
            {
                MessageBox.Show("chưa nhập mã tình trạng");
            }
            if (txtdatra.Text == "")
            {
                MessageBox.Show("chưa nhập ô đã trả");
            }
            else
            {
                string sql = "update chitietthuesach set masach=@masach, matinhtrang=@matinhtrang,datra=@datra where mathue=@mathue";
                SqlCommand cmd = new SqlCommand(sql, DAO.con);
                cmd.Parameters.AddWithValue("mathue", txtmathue.Text);
                cmd.Parameters.AddWithValue("masach", txtmasach.Text);
                cmd.Parameters.AddWithValue("matinhtrang", txtmatinhtrang.Text);
                cmd.Parameters.AddWithValue("datra", txtdatra.Text);
                cmd.ExecuteNonQuery();
                loaddata();
            }
        }
    }
}

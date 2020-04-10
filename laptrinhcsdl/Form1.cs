using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace laptrinhcsdl
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            string connectionstring = "Data Source=DESKTOP-QQP2MDV;Initial Catalog=quanlybanhang;Integrated Security=True";
            con.ConnectionString = connectionstring;
            con.Open();
            string sql = "select * from dmhang";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tabledmhang = new DataTable();
            adp.Fill(tabledmhang);
            dataGridView1.DataSource = tabledmhang;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmahang.Text = dataGridView1.CurrentRow.Cells["mahang"].Value.ToString();
            txtgianhap.Text = dataGridView1.CurrentRow.Cells["gianhap"].Value.ToString();
            txtgiaban.Text = dataGridView1.CurrentRow.Cells["giaxuat"].Value.ToString();
            txtsoluong.Text = dataGridView1.CurrentRow.Cells["soluong"].Value.ToString();
            txttenhang.Text = dataGridView1.CurrentRow.Cells["tenhang"].Value.ToString();
            txtmahang.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void loaddatagridview()
        {
            string sql = "select * from dmhang";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tabledmhang = new DataTable();
            adp.Fill(tabledmhang);
            dataGridView1.DataSource = tabledmhang;
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from dmhang where mahang = '" + txtmahang.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            loaddatagridview();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtmahang.Text = "";
            txttenhang.Text = "";
            txtgianhap.Text = "";
            txtgiaban.Text = "";
            txtsoluong.Text = "";
            txtmahang.Enabled = true;

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtmahang.Text == "")
            {
                MessageBox.Show("ban chua nhap ma hang", "thong bao");
                txtmahang.Focus();
                return;
            }
            if (txttenhang.Text == "")
            {
                MessageBox.Show("ban chua nhap ten hang", "thong bao");
                txttenhang.Focus();
                return;
            }else
            {
                string sql = "insert into dmhang values('" + txtmahang.Text + "' , '" + txttenhang.Text + "'";
                if (txtgianhap.Text != "")
                {
                    sql = sql + "," + txtgianhap.Text.Trim();
                }
                if (txtgiaban.Text != "")
                {
                    sql = sql + "," + txtgiaban.Text.Trim();
                }
                if (txtsoluong.Text != "")
                {
                    sql = sql + "," + txtsoluong.Text.Trim();
                }
                sql = sql + ")";
                try
                {
                    MessageBox.Show(sql);
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    loaddatagridview();
                } catch (Exception d)
                {
                    MessageBox.Show(d.ToString());
                }
                finally
                {
                    
                }
            }

        }

        private void txtgianhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) ||(e.KeyChar == '.') || (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }


        private void btnthoat_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
        }

        private void txtgiaban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == '.') || (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == '.') || (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            
        }
    }
}

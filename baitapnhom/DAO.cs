using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
namespace baitapnhom
{
    class DAO
    {
        public static SqlConnection con;
        public static string connectstring;
        public static void connect()
        {
            connectstring = "Data Source=DESKTOP-QQP2MDV;Initial Catalog=cuahangchothuesach;Integrated Security=True";
            con = new SqlConnection();
            con.ConnectionString = connectstring;
            con.Open();
        }
        public static void disconnect()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
                con.Dispose();
                con = null;
            }
        }
        public static bool CheckKey(string sql)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, DAO.con);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }
        public static void RunSql(string sql)
        {
            SqlCommand cmd;		                // Khai báo đối tượng SqlCommand
            cmd = new SqlCommand();	         // Khởi tạo đối tượng
            cmd.Connection = DAO.con;	  // Gán kết nối
            cmd.CommandText = sql;			  // Gán câu lệnh SQL
            try
            {
                cmd.ExecuteNonQuery();		  // Thực hiện câu lệnh SQL
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }


    }
}

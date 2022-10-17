using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DOANCANHAN_HOTHANHTAI_9057
{
    class LOPDUNGCHUNG
    {
        string chuoikn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\source\repos\DOANCANHAN_HOTHANHTAI_9057\DOANCANHAN_HOTHANHTAI_9057\DOANCANHAN_HOTHANHTAI.mdf;Integrated Security=True";
        SqlConnection cnn;
        public LOPDUNGCHUNG()
        {
            cnn = new SqlConnection(chuoikn);
        }
        public int ThemSuaXoa(string cmd)
        {
            SqlCommand comm = new SqlCommand(cmd,cnn);
            cnn.Open();
            int kq = comm.ExecuteNonQuery();
            cnn.Close();
            return kq;
        }
        public object TraGiaTri(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, cnn);
            cnn.Open();
            object kq = comm.ExecuteScalar();
            cnn.Close();
            return kq;
        }
        public DataTable LoadDL(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            da.Fill(dt);
            return dt;
        }
    }
}

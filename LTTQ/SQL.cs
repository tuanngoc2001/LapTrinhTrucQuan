using System.Data.SqlClient;
using System.Data;

namespace LTTQ
{
    class SQL
    {
        string chuoiketnoi = @"Data Source=DESKTOP-O2T5G7H\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=LTTQ";
        SqlConnection sqlconn=null;
        private void KetNoiCSDL()
        {
            sqlconn = new SqlConnection(chuoiketnoi);
            if (sqlconn.State != ConnectionState.Open)
                sqlconn.Open();
        }
        private void DongKetNoiCSDL()
        {
            if (sqlconn.State != ConnectionState.Closed)
                sqlconn.Close();
            sqlconn.Dispose();
        }
        public DataTable loaddulieu(string sql)
        {
            DataTable dtbang = new DataTable();
            KetNoiCSDL();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlconn);
            sqlDataAdapter.Fill(dtbang);
            return dtbang;
        }
        public void CapNhatDuLieu(string sql)
        {
            KetNoiCSDL();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlconn;
            sqlCommand.CommandText = sql;
            sqlCommand.ExecuteNonQuery();
            DongKetNoiCSDL();
        }
    }
    
}

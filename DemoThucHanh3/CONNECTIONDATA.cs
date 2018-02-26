namespace DemoThucHanh3
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    public class CONNECTIONDATA
    {
        private SqlConnection cnn;
        private SqlCommand cmd;

        public CONNECTIONDATA()
        {
            cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Tuan Nguyen\documents\visual studio 2015\Projects\DemoThucHanh3\DemoThucHanh3\QUANLYBANHANG.mdf"";Integrated Security=True");
        }

        public void Open()
        {
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
        }

        public void Close()
        {
            if (cnn.State != ConnectionState.Closed)
            {
                cnn.Close();
            }

        }

        public DataTable getData(string sql)
        {
            DataTable dt = new DataTable();

            Open();
            cmd = new SqlCommand(sql, cnn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(dt);
            Close();

            return dt;
        }

        /// <summary>
        /// Phhuong thuc excute thuc thi truy van SQL
        /// Insert Into: them moi 1 bang ghi
        /// Update: hieu chinh 1 bang ghi
        /// Date: xoa 1 bang ghi
        /// StoreProcedure: thuc thi thu tuc
        /// </summary>
        /// <param name="SQL"></param>
        public int ExcuteSQL(String SQL)
        {
            this.Open();
            SqlCommand cmd = new SqlCommand(SQL, this.cnn);
            int result = cmd.ExecuteNonQuery();
            this.Close();
            return result;
   
        }
    }
}

using JPlatform.Client.Controls8;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.ConnectDB
{
    class ConnectDB
    {
        public static readonly string ConnectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=LaserCutDB;Integrated Security=True;";

        public static DataTable Getcombobox(string proc, string namecombobox)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(proc , conn)) //"GetMRASRESDEF_ByResID"
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@NameCbx", namecombobox);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }

            catch //(Exception ex)
            {
                //MessageBox.Show(MessageBoxIcon.Error);
                dt = null;
            }

            return dt;
        }

        //var parameters = new Dictionary<string, object>
        //{
        //    { "@NameCbx", "bi" },
        //    { "@Age", 25 }
        //};

        //DataTable dt = CallPROC("ProcNoParam", null);
        //DataTable dt = CallPROC("ProcName2", parameters);

        public static void CallPROC(string procName, Dictionary<string, object> parameters, GridControlEx grd, GridViewEx gvw)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(procName, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // ✅ Thêm parameters động
                        if (parameters != null)
                        {
                            foreach (var param in parameters)
                            {
                                cmd.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                            }
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            conn.Open();
                            adapter.Fill(dt);
                        }
                    }
                }

                // gắn dữ liệu lên lưới
                grd.DataSource = dt;

                // Tùy chỉnh ô giao diện GridView cho đẹp 
                gvw.BestFitColumns();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public static DataTable CallPROC(string procName, Dictionary<string, object> parameters)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(procName, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // ✅ Thêm parameters động
                        if (parameters != null)
                        {
                            foreach (var param in parameters)
                            {
                                cmd.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                            }
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            conn.Open();
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                dt = null;
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }



    }
}

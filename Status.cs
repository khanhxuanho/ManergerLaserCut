using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.ConnectDB;

namespace ManergerLaserCut
{
    public partial class STATUS : Form
    {
        public STATUS()
        {
            InitializeComponent();
            CallProc();
        }

        public void Querydata()
        {
            //ConnectDB.CallPROC("STATUS", null, grdMaster, gvwMaster);
        }

        // call procedure
        public void CallProc()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection conn = new SqlConnection(ConnectDB.ConnectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("P_MATERIAL", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // 2. Thêm tham số (tránh SQL Injection)
                        //cmd.Parameters.AddWithValue("@ResID", "ABC123");

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
                //trả dữ liệu ra lưới
                grdMaster.DataSource = dt;

                // Tùy chỉnh GridView (tùy chọn)
                gvwMaster.BestFitColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

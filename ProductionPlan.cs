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
    public partial class ProductionPlan : Form
    {
        public ProductionPlan()
        {
            InitializeComponent();

            // hien dữ liệu lên lưới // call procedure
            ConnectDB.CallPROC("P_PRODUCTIONPLAN", null, grdMaster, gvwMaster);

            //CallProc();
        }

        public void Querydata()
        {

        }

        private void btnPrintPCard_Click(object sender, EventArgs e)
        {
            string list_OrderID = "";
            DataTable dt = new DataTable();

            //lay nhung dong check chon
            foreach (int k in gvwMaster.GetSelectedRows())
            {
                list_OrderID += gvwMaster.GetValue(k, "ORDER_ID").ToString().Trim()+";";
            }
            var param1 = new Dictionary<string, object>
            {
                { "@L_ORDER_ID", list_OrderID }
            };

            dt = ConnectDB.CallPROC("P_CREATEQR", param1);
            
            //if（dt.Rows.Count > 0）{

            //}
        }
    }
}

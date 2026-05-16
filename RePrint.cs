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
    public partial class RePrint : Form
    {
        public RePrint()
        {
            InitializeComponent();
            var param1 = new Dictionary<string, object>
            {
                { "@Tab", "TAB1" }
            };
            var param2 = new Dictionary<string, object>
            {
                { "@Tab", "TAB2" }
            };
            ConnectDB.CallPROC("CANCEL", param1, grdMaster, gvwMaster);
        }

        public void Querydata()
        {
            ConnectDB.CallPROC("REPRINT", null, grdMaster, gvwMaster);
        }

    }
}

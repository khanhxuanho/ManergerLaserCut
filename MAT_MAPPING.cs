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
    public partial class MAT_MAPPING : Form
    {
        public MAT_MAPPING()
        {
            InitializeComponent();
        }

        public void Querydata()
        {
            //ConnectDB.CallPROC("MAT_MAPPING", null, grdMaster, gvwMaster);
        }

         
    }
}

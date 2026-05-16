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
    public partial class MANAGER_Machine : Form
    {
        //static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=LaserCutDB;Integrated Security=True;";
        public MANAGER_Machine()
        {
            InitializeComponent();
            //ConnectDB.CallPROC("MANAGER_MACHINE", null, grdMaster, gvwMaster);
            //CallProc();
        }

        public void Querydata()
        {
            ConnectDB.CallPROC("MANAGER_MACHINE", null, grdMaster, gvwMaster);
        }

       

    }
}

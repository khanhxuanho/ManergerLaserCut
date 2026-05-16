using System;
using System.Drawing;
using System.Windows.Forms;

namespace ManergerLaserCut
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
            InitializeMenu();

            //Image original = btnQuery.ImageOptions.Image;
            //btnQuery.ImageOptions.Image = new Bitmap(original, new Size(45, 45));

        }

        private void InitializeMenu()
        {
            TreeNode systemNode = new TreeNode("Account");
            systemNode.Nodes.Add("Login");
            systemNode.Nodes.Add("Register");

            TreeNode mesNode = new TreeNode("Product Information");
            mesNode.Nodes.Add("Production Plan");
            mesNode.Nodes.Add("Machine");
            mesNode.Nodes.Add("Production Laser");
            mesNode.Nodes.Add("Material");
            //mesNode.Nodes.Add("TK_VM 3.0");

            TreeNode devNode = new TreeNode("Production");
            devNode.Nodes.Add("Mapping Material&QR");
            devNode.Nodes.Add("RePrint");
            devNode.Nodes.Add("Cancel"); 
            devNode.Nodes.Add("Laser Cut"); 
            devNode.Nodes.Add("Status");

            //TreeNode toolsNode = new TreeNode("TDSV TOOLS");

            treeViewMenu.Nodes.Add(systemNode);
            treeViewMenu.Nodes.Add(mesNode);
            treeViewMenu.Nodes.Add(devNode);
            //treeViewMenu.Nodes.Add(toolsNode);
            treeViewMenu.ExpandAll();
        }

        // ⬇️ SỬA LẠI PHẦN NÀY ⬇️
        private void treeViewMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null) return;

            string menuName = e.Node.Text.Replace(" ", "");

            switch (menuName)
            {
                case "Login":

                    LoadChildForm(typeof(Login));
                break;

                //in tem va ke hoach san xuat
                case "ProductionPlan":
                    LoadChildForm(typeof(ProductionPlan));
                    break;
                
                // quản lý vị trí máy, máy còn sử dụng hay không
                case "Machine":
                    LoadChildForm(typeof(MANAGER_Machine));
                    break;

                // Thông tin nvl sản xuất
                case "Material":
                    LoadChildForm(typeof(MATERIAL));
                    break;

                    // đưa nvl và qr thành 1 để sản xuất
                case "MappingMaterial&QR":
                    LoadChildForm(typeof(MAT_MAPPING));
                    break;

                    // in lại tem do tem hư
                case "RePrint":
                    LoadChildForm(typeof(RePrint));
                    break;

                    // hủy con qr số lượng sản xuất trả lại số lượng kế hoạch về màn hình in tem
                case "Cancel":
                    LoadChildForm(typeof(Cancel));
                    break;

                    // mapping xong đưa qr lên sản xuất trừ sản luọng
                case "LaserCut":
                    LoadChildForm(typeof(LaserCut));
                    break;

                    // coi sản lượng đã sản xuất
                case "ProductionLaser":
                    LoadChildForm(typeof(ProductionLaser));
                    break;

                    // trạng thái của con qr cancel hay đng sản xuất hay mới tạo
                case "Status":
                    LoadChildForm(typeof(STATUS));
                    break; 

                //case "Hoàn tất Laser":
                //case "Hoàn tất": // Nhiều case cùng xử lý
                //    LoadChildForm(typeof(ACC0700));
                //    break;

                default:
                    LoadFormContent(menuName);
                    break;
            }
            
            //if (menuName == "ProductionPlan")
            //{
            //    LoadChildForm(typeof(ACC0100));
            //}
            //else
            //{
            //    // Các menu khác vẫn hiện label tạm thời
            //    LoadFormContent(menuName);
            //}
        }

        /// <summary>
        /// Phương thức chung để nhúng 1 Form vào panelContent
        /// </summary>
        private void LoadChildForm(Type formType)
        {
            // 1. Giải phóng form cũ (tránh leak memory)
            foreach (Control ctrl in panelContent.Controls)
            {
                ctrl.Dispose();
            }
            panelContent.Controls.Clear();

            // Xóa form cũ
            if (currentChildForm != null)
            {
                currentChildForm.Dispose();
                currentChildForm = null;
            }

            panelContent.Controls.Clear();

            // Tạo form mới
            currentChildForm = (Form)Activator.CreateInstance(formType);

            currentChildForm.TopLevel = false;
            currentChildForm.FormBorderStyle = FormBorderStyle.None;
            currentChildForm.Dock = DockStyle.Fill;

            panelContent.Controls.Add(currentChildForm);
            currentChildForm.Show();
        }

        private void LoadFormContent(string menuName)
        {
            panelContent.Controls.Clear();

            Panel contentPanel = new Panel { Dock = DockStyle.Fill, Padding = new Padding(20), BackColor = Color.White };

            Label lblContent = new Label { Text = menuName, Font = new Font("Segoe UI", 16F, FontStyle.Bold), AutoSize = true, Location = new Point(20, 20), ForeColor = Color.FromArgb(0, 114, 198) };
            Label lblDesc = new Label { Text = $"Đây là màn hình cho chức năng: {menuName}", Font = new Font("Segoe UI", 10F), AutoSize = true, Location = new Point(20, 60), ForeColor = Color.Gray };

            contentPanel.Controls.Add(lblContent);
            contentPanel.Controls.Add(lblDesc);
            panelContent.Controls.Add(contentPanel);

            lblTitle.Text = $"TK_VT_DEV - {menuName}";
        }

        private Form currentChildForm;
        private void btnQuery_Click(object sender, EventArgs e)
        {
            //SetMessageBox("alo ko chon het"); 
            //MessageBox.Show("Machine different. Please choice same machine type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            MATERIAL accForm = currentChildForm as MATERIAL;

            if (accForm != null)
            {
                accForm.Querydata();
            }

            MANAGER_Machine accForm1 = currentChildForm as MANAGER_Machine;
            if (accForm1 != null)
            {
                accForm1.Querydata();
            }

            ProductionLaser accForm2 = currentChildForm as ProductionLaser;
            if (accForm2 != null)
            {
                accForm2.Querydata();
            }

            ProductionPlan accForm3 = currentChildForm as ProductionPlan;
            if (accForm3  != null)
            {
                accForm3.Querydata();
            }

            Cancel accForm4 = currentChildForm as Cancel;
            if (accForm4 != null)
            {
                accForm4.Querydata();
            }

            RePrint accForm5 = currentChildForm as RePrint;
            if (accForm5 != null)
            {
                accForm5.Querydata();
            }

            STATUS accForm6 = currentChildForm as STATUS;
            if (accForm6 != null)
            {
                accForm6.Querydata();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManergerLaserCut
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            DesignUI();
        }

        private void DesignUI()
        {
            // PANEL LOGIN
            Panel pnlLogin = new Panel();
            pnlLogin.Size = new Size(320, 260);
            pnlLogin.Location = new Point(270, 100);
            pnlLogin.BackColor = Color.Transparent;
            this.Controls.Add(pnlLogin);

            // LINE
            Panel pnlLine = new Panel();
            pnlLine.BackColor = Color.White;
            pnlLine.Size = new Size(3, 180);
            pnlLine.Location = new Point(10, 30);
            pnlLogin.Controls.Add(pnlLine);

            // TITLE
            Label lblTitle = new Label();
            lblTitle.Text = "Login";
            lblTitle.ForeColor = Color.White;
            lblTitle.Font = new Font("Segoe UI", 16);
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(120, 20);
            pnlLogin.Controls.Add(lblTitle);

            // USERNAME
            TextBox txtUsername = new TextBox();
            txtUsername.Size = new Size(180, 30);
            txtUsername.Location = new Point(70, 70);
            txtUsername.Font = new Font("Segoe UI", 10);
            txtUsername.Text = "USERNAME";
            txtUsername.ForeColor = Color.Gray;
            pnlLogin.Controls.Add(txtUsername);

            // PASSWORD
            TextBox txtPassword = new TextBox();
            txtPassword.Size = new Size(180, 30);
            txtPassword.Location = new Point(70, 115);
            txtPassword.Font = new Font("Segoe UI", 10);
            txtPassword.Text = "PASSWORD";
            txtPassword.ForeColor = Color.Gray;
            pnlLogin.Controls.Add(txtPassword);

            // BUTTON LOGIN
            Button btnLogin = new Button();
            btnLogin.Text = "Sign In";
            btnLogin.Size = new Size(180, 35);
            btnLogin.Location = new Point(70, 165);
            btnLogin.BackColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Font = new Font("Segoe UI", 10);
            pnlLogin.Controls.Add(btnLogin);

            // CHECKBOX
            CheckBox chkRemember = new CheckBox();
            chkRemember.Text = "Remember me";
            chkRemember.ForeColor = Color.White;
            chkRemember.AutoSize = true;
            chkRemember.Location = new Point(70, 215);
            pnlLogin.Controls.Add(chkRemember);

            // LINKLABEL
            LinkLabel lnkForgot = new LinkLabel();
            lnkForgot.Text = "Forgot password?";
            lnkForgot.LinkColor = Color.White;
            lnkForgot.AutoSize = true;
            lnkForgot.Location = new Point(170, 216);
            pnlLogin.Controls.Add(lnkForgot);
        }
    }
}
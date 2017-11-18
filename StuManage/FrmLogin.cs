using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Models;

namespace StuManage
{
    public partial class FrmLogin : Form
    {
        AdminManager am = new AdminManager();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (am.AdminExists(txtLoginName.Text.ToString().Trim(), txtLoginPwd.Text.ToString().Trim()))
            {
                Admin.loginName = txtLoginName.Text.ToString().Trim();
                FrmMain fm = new FrmMain();
                fm.Show();
                this.Hide();

            }

            else
            {
                MessageBox.Show("登录失败");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btntext_Click(object sender, EventArgs e)
        {
            int a = am.ab(txtLoginName.Text.ToString().Trim(), txtLoginPwd.Text.ToString().Trim());
            MessageBox.Show(a.ToString());
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void FrmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
            if ((Keys)e.KeyChar == Keys.Escape)
            {
                btnCancel_Click(sender, e);
            }
        }

        private void btntest_Click(object sender, EventArgs e)
        {
            FrmStuSelectScope fsss = new FrmStuSelectScope();
            fsss.Show();
            this.Hide();
        }
    }
}

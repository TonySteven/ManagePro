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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void tsmQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmProManage_Click(object sender, EventArgs e)
        {
            FrmProStuManage fps = new FrmProStuManage();
            fps.MdiParent = this;
            fps.Show();

        }

        private void tsmClassManage_Click(object sender, EventArgs e)
        {
            FrmClassStuManage fcs = new FrmClassStuManage();
            fcs.MdiParent = this;
            fcs.Show();
        }

        private void tsmSubjectManage_Click(object sender, EventArgs e)
        {
            FrmSubjectManage fsjm = new FrmSubjectManage();
            fsjm.MdiParent = this;
            fsjm.Show();
        }

        private void tspstuInfoManage_Click(object sender, EventArgs e)
        {
            FrmStuManage fsm = new FrmStuManage();
            fsm.MdiParent = this;
            fsm.Show();
        }

        private void tsmscorpinput_Click(object sender, EventArgs e)
        {
            FrmStuScopeAdd fss = new FrmStuScopeAdd();
            fss.MdiParent = this;
            fss.Show();
        }

        private void tsmscorpselect_Click(object sender, EventArgs e)
        {
            FrmStuSelectScope fsss = new FrmStuSelectScope();
            fsss.MdiParent = this;
            fsss.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            tssAdminName.Text = string.Format("当前用户:{0}", Admin.loginName);
        }

        private void tsmcascade_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tsmArrange_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void Horizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tsmVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void tssAdminName_Click(object sender, EventArgs e)
        {
            
           
        }

        private void FrmMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Escape)
            {
                tsmQuit_Click(sender, e);
            }
            
        }

        private void FrmMain_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}

using BLL;
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

namespace StuManage
{
    public partial class FrmStuManage : Form
    {
        SqlDataAdapter da ;
        DataTable dt;
        StuManaer sm = new StuManaer() ;
        public FrmStuManage()
        {
            InitializeComponent();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            string sql = "select * from student";
            SqlConnection con = sm.ConnecttoStuManager();
            da = sm.GetSqlDataAdapter(con, sql);
            try
            {
                SqlCommandBuilder scb = new SqlCommandBuilder(da);
                if (da.Update(dt) > 0)
                { MessageBox.Show("保存成功"); }
                else
                {
                    MessageBox.Show("保存失败");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FrmStuManage_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            Refresh();
        }
        public void Refresh()
        {
            
            dt = sm.GetALLStu();
            dgvStuManage.AutoGenerateColumns = false;
            dgvStuManage.DataSource = dt;
        }
      

        private void tsbDelete_Click(object sender, EventArgs e)
        {
           
            if (MessageBox.Show("确定删除?", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string id = this.dgvStuManage.CurrentRow.Cells[0].Value.ToString().Trim();
                string sqltoDeleteSelectedRows = string.Format("delete  student where id = '{0}'", id);
                int s = Convert.ToInt32(cl.Execute(sqltoDeleteSelectedRows));
                if (s != 0)
                {
                    MessageBox.Show("成功删除选中行数据！");
                } 
            }
            else
            {
                
            }
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void tsbSortAsc_Click(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.Sort = "name asc ";
            dgvStuManage.DataSource = dv;
        }

        private void tsbSortDesc_Click(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.Sort = "name desc ";
            dgvStuManage.DataSource = dv;
        }

        private void tsbnew_Click(object sender, EventArgs e)
        {
            FrmAddStu fas = new FrmAddStu();
            fas.ShowDialog();
        }

        private void tsmAdd_Click(object sender, EventArgs e)
        {
            tsbnew_Click(sender, e);
        }

        private void tsmSave_Click(object sender, EventArgs e)
        {
            tsbSave_Click(sender, e);
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            tsbDelete_Click(sender, e);
        }

        private void tsmRefresh_Click(object sender, EventArgs e)
        {
            tsbRefresh_Click(sender, e);
        }

        private void tsmaz_Click(object sender, EventArgs e)
        {
            tsbSortAsc_Click(sender, e);
        }

        private void tsmza_Click(object sender, EventArgs e)
        {
            tsbSortDesc_Click(sender, e);
        }
    }
}

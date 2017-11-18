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
    public partial class FrmProStuManage : Form
    {
        SqlDataAdapter da;
        DataTable dt;
        StuManaer sm = new StuManaer();
        public FrmProStuManage()
        {
            InitializeComponent();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            string sql = "select * from Major";
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

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            string id = this.dgvProstumanage.CurrentRow.Cells[0].Value.ToString();
            string sqltoDeleteSelectedRows = string.Format("delete  Major where id = '{0}'", id);
            int s = Convert.ToInt32(cl.Execute(sqltoDeleteSelectedRows));
            if (s != 0)
            {
                MessageBox.Show("成功删除选中行数据！");
                Refresh();
            }
        }

        private void FrmProStuManage_Load(object sender, EventArgs e)
        {
            Refresh();
        }
        private void Refresh()
        {

            dt = sm.GetALLMajor();
            dgvProstumanage.AutoGenerateColumns = false;
            dgvProstumanage.DataSource = dt;
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
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
    }
}

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
using BLL;

namespace StuManage
{
    public partial class FrmSubjectManage : Form
    {
        SqlDataAdapter da;
        DataTable dt;
        StuManaer sm = new StuManaer();
        public FrmSubjectManage()
        {
            InitializeComponent();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder scb = new SqlCommandBuilder(da);
                if (da.Update(dt) > 0)
                {
                    MessageBox.Show("保存成功");
                    Refresh();  
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            string id = this.dgvSubjectManage.CurrentRow.Cells[0].Value.ToString();
            string sqltoDeleteSelectedRows = string.Format("delete  subject where id = '{0}'", id);
            int s = Convert.ToInt32(cl.Execute(sqltoDeleteSelectedRows));
            if (s != 0)
            {
                MessageBox.Show("成功删除选中行数据！");
                Refresh();
            }
        }

        private void FrmSubjectManage_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            DataSet ds = new DataSet();
            string sqltoread = string.Format("select * from subject");
            SqlConnection conn = sm.ConnecttoStuManager();
            SqlCommand cmd = new SqlCommand(sqltoread, conn);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            try
            {
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgvSubjectManage.AutoGenerateColumns = false;
            dgvSubjectManage.DataSource = dt;
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string sqltoread = string.Format("select * from subject");
            SqlConnection conn = sm.ConnecttoStuManager();
            SqlCommand cmd = new SqlCommand(sqltoread, conn);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            try
            {
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgvSubjectManage.AutoGenerateColumns = false;
            dgvSubjectManage.DataSource = dt;
        }

        private void tsbSortAsc_Click(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.Sort = "name asc ";
            dgvSubjectManage.DataSource = dv;
        }

        private void tsbSortDesc_Click(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.Sort = "name desc ";
            dgvSubjectManage.DataSource = dv;
        }

        private void tsmaz_Click(object sender, EventArgs e)
        {
            tsbSortAsc_Click(sender, e);
        }

        private void tsmza_Click(object sender, EventArgs e)
        {
            tsbSortDesc_Click(sender, e);
        }

        private void tsmSave_Click(object sender, EventArgs e)
        {
            tsbSave_Click(sender, e);
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            tsbDelete_Click(sender,e);
        }
    }
}

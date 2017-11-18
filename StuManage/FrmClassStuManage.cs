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
   
    public partial class FrmClassStuManage : Form
    {
        StuManaer sm = new StuManaer();
        SqlDataAdapter da;
        DataTable dt;
        public FrmClassStuManage()
        {
            InitializeComponent();
        }

        private void FrmClassStuManage_Load(object sender, EventArgs e)
        {
            Refresh();
        }
        #region 刷新方法
        /// <summary>
        /// 刷新界面,重新连接数据库
        /// </summary>
        private void Refresh()
        {
            
            try
            {
                dt=sm.GetALLClasses();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgvClassManage.AutoGenerateColumns = false;
            dgvClassManage.DataSource = dt;
        }
        #endregion

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            FrmAddClasses fac = new FrmAddClasses();
            fac.ShowDialog();
        }

        private void tsbreFresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            string sql = "select * from classes";
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

        private void tsbCancel_Click(object sender, EventArgs e)
        {
            string id = this.dgvClassManage.CurrentRow.Cells[0].Value.ToString();
            sm.DeleteStu(id);
            int s = Convert.ToInt32(cl.Execute(sm.returnsqltoDeleteSelectedRows(id)));
            if (s != 0)
            {
                MessageBox.Show("成功删除选中行数据！");
                Refresh();  
            }
            //for (int i = 0; i < this.dgvClassManage.SelectedRows.Count; i--)
            //{
            //    int ID = Convert.ToInt32(dgvClassManage.SelectedRows[i - 1].Cells[0].Value);
            //    dgvClassManage.Rows.RemoveAt(dgvClassManage.SelectedRows[i - 1].Index);
            //    string sqltoDeleteSelectedRows = string.Format("delete  Classes where Name = '{0}'",ID.ToString());
                
            //}
        }

        private void tsmSave_Click(object sender, EventArgs e)
        {
            tsbSave_Click(sender, e);
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            tsbCancel_Click(sender,e);
        }

        private void tsmAdd_Click(object sender, EventArgs e)
        {
            tsbAdd_Click(sender, e);
        }

        private void tsmRefresh_Click(object sender, EventArgs e)
        {
            tsbreFresh_Click(sender, e);
        }

        private void dgvClassManage_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FrmClassStuManage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Escape)
            {
                this.Close();
            }
            
        }
    }
}

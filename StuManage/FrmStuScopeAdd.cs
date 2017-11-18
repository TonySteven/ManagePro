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
    public partial class FrmStuScopeAdd : Form
    {
        SqlDataAdapter da;
        DataTable dt;
        StuManaer sm = new StuManaer();
        public FrmStuScopeAdd()
        {
            InitializeComponent();
        }

        private void FrmStuScopeAdd_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            DataSet ds = new DataSet();
            InsertComShopClass(cboClass);
            InsertComShopSubject(cboSubject);
            dt = sm.GetStuNameAndScope();
            dgvStuScopeAdd.AutoGenerateColumns = false;
            dgvStuScopeAdd.DataSource = dt;
        }

        public void InsertComShopClass(ComboBox cb)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = sm.ConnecttoStuManager();
            string sql = "select * from Classes";
            da = new SqlDataAdapter(sql, conn);
            try
            {
                da.Fill(dt);
                cboClass.DataSource = dt;
                cboClass.DisplayMember = "Name";
                cboClass.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void InsertComShopSubject(ComboBox cb)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = sm.ConnecttoStuManager();
            string sql = "select * from subject";
            da = new SqlDataAdapter(sql, conn);
            try
            {
                da.Fill(dt);
                cboSubject.DataSource = dt;
                cboSubject.DisplayMember = "name";
                cboSubject.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = this.dgvStuScopeAdd.CurrentRow.Cells[0].Value.ToString();
           
            string scope = this.dgvStuScopeAdd.CurrentRow.Cells[2].Value.ToString();
            MessageBox.Show(scope);
            string sqltoread = string.Format("update scope set scope = '{0}' where subjectid = '{1}' and id = '{2}' ", "99", "04", "03");
            SqlConnection con = sm.ConnecttoStuManager();
            da = sm.GetSqlDataAdapter(con, sqltoread);
            dt = (DataTable)dgvStuScopeAdd.DataSource;
            SqlCommandBuilder scb = new SqlCommandBuilder(da);
            try
            {
                da.Update(dt);
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

        private void btnEntering_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            

            //cboClass.SelectedIndex = 0;
            //cboSubject.SelectedIndex = 1;
            //MessageBox.Show(cboClass.SelectedValue.ToString());
            //MessageBox.Show(cboSubject.SelectedValue.ToString());
            string sqltoread =string.Format("select a.id,a.Name ,b.scope from student as a  inner join scope as b on a.id=b.id inner join subject as c on c.id = b.subjectid inner join Classes as d on d.id = a.ClassId where d.id ='{0}' and c.id = '{1}'", cboClass.SelectedValue, cboSubject.SelectedValue);
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
            dgvStuScopeAdd.AutoGenerateColumns = false;
            dgvStuScopeAdd.DataSource = dt;
        }

        private void cboSubject_DropDownClosed(object sender, EventArgs e)
        {
            MessageBox.Show(cboSubject.SelectedValue.ToString()); 
        }

        private void cboClass_DropDownClosed(object sender, EventArgs e)
        {
            MessageBox.Show(cboClass.SelectedValue.ToString());
        }

        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        
    }
}

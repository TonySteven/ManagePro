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
   
    public partial class FrmStuSelectScope : Form
    {
        SqlDataAdapter da;
        DataTable dt;
        StuManaer sm = new StuManaer();
        public FrmStuSelectScope()
        {
            InitializeComponent();
        }

        private void FrmStuSelectScope_Load(object sender, EventArgs e)
        {
            
            string sqltoread = string.Format("select a.id,a.Name,b.Name as subject,c.scope,d.Name as class from student as a inner join subject as b on a.id= b.id inner join scope as c on c.subjectid = b.id inner join Classes as d  on d.id = a.ClassId");
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
            dgvSelectScope.AutoGenerateColumns = false;
            dgvSelectScope.DataSource = dt;
        }

        private void tsmRefresh_Click(object sender, EventArgs e)
        {
            FrmStuSelectScope_Load(sender, e);
        }

        private void tsmaz_Click(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.Sort = "name asc ";
            dgvSelectScope.DataSource = dv;
        }

        private void tsmza_Click(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.Sort = "name desc ";
            dgvSelectScope.DataSource = dv;
        }
    }
}

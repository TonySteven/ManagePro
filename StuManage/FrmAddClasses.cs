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
    public partial class FrmAddClasses : Form
    {
        public FrmAddClasses()
        {
            InitializeComponent();
            this.Focus();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StuManaer sm = new StuManaer();
            if (sm.AddClassesValidateInput(txtAddCNum.Text.Trim(), txtClassName.Text.Trim(), txtHeadTeacher.Text.Trim(), cboMajorin.SelectedItem.ToString().Trim()))
            {

                SqlCommand cmd = sm.AddClasses(txtAddCNum.Text.Trim(), txtClassName.Text.Trim(), txtHeadTeacher.Text.Trim(), cboMajorin.SelectedItem.ToString().Trim());
                SqlConnection conn = sm.ConnecttoStuManager();
                try
                {
                    conn.Open();
                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("数据添加成功");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                        conn.Dispose();
                    }
                }

            }
            else
            {
                MessageBox.Show("您有没输入的值!");
            }
        }

        private void FrmAddClasses_Load(object sender, EventArgs e)
        {
            cboMajorin.SelectedIndex = 0;
        }
        
    }
}

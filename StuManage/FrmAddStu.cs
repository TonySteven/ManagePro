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
    public partial class FrmAddStu : Form
    {
        public FrmAddStu()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StuManaer sm = new StuManaer();
            
            if (ValidateInput())
            {
                string birth = dtpBirth.Value.ToLongDateString().Trim();
                //string bir = cobBirthday.SelectedItem.ToString().Trim();
                SqlCommand cmd = sm.AddStu(txtStuNum.Text.Trim(), txtStuName.Text.Trim(), cobGender.SelectedItem.ToString().Trim(),birth    , cobPolicy.SelectedItem.ToString().Trim(), cobNation.SelectedItem.ToString().Trim(), cobClass.SelectedItem.ToString().Trim(), txtCardId.Text.Trim());
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
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool ValidateInput()
        {

            if (txtStuNum.Text.Trim() == "")
            {
                MessageBox.Show("学生编号不能为空");
                return false;
            }
            if (txtStuName.Text.Trim() == "")
            {
                MessageBox.Show("学生姓名不能为空");
                return false;
            }
            if (txtCardId.Text.Trim() == "")
            {
                MessageBox.Show("身份证号不能为空");
                return false;
            }
            //if (cobBirthday.SelectedItem.ToString().Trim() == "")
            //{
            //    MessageBox.Show("出生日期不能为空");
            //    return false;
            //}
            if (cobClass.SelectedItem.ToString().Trim() == "")
            {
                MessageBox.Show("所属班级不能为空");
                return false;
            }
            if (cobGender.SelectedItem.ToString().Trim() == "")
            {
                MessageBox.Show("性别不能为空");
                return false;
            }
            if (cobNation.SelectedItem.ToString().Trim() == "")
            {
                MessageBox.Show("民族不能为空");
                return false;
            }
            if (cobPolicy.SelectedItem.ToString().Trim() == "")
            {
                MessageBox.Show("政治面貌不能为空");
                return false;
            }
            return true;
         }

        private void cobBirthday_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = dtpBirth.Value.ToShortDateString().Trim();
            MessageBox.Show(sql);
        }
    }
}

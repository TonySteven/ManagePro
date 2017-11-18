using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace StuManage
{
    class  cl
    {
        public  static int  Execute(string SQL)
        {
            StuManaer sm = new StuManaer();
            SqlConnection conn = sm.ConnecttoStuManager() ;
            SqlCommand cmd = new SqlCommand(SQL, conn);
            conn.Open();
            int i = Convert.ToInt32(cmd.ExecuteNonQuery());
            return i;
        }
    }
}

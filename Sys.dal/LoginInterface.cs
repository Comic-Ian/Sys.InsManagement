using Sys.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sys.dal
{
    public class LoginInterface
    {
        //用户注册
        public bool AddUser(User user)
            {
            string sql = string.Format("insert into Tbl_acc_inf values('{0}','{1}','{2}','{3}')",user.UserId,user.UserPasswd, user.UserName,user.UserSex);

            return DataHelper.ExecuteNonQuery(sql) > 0 ? true : false;
        }

        //用户登录
        public bool ValidationUser(User user)
        {
            string sql = string.Format("select count(*) from Tbl_acc_inf where UserId='{0}' and UserPasswd = '{1}'",user.UserId,user.UserPasswd);

            return DataHelper.ExecuteScalar(sql) > 0 ? true : false;

        }

    }
}

﻿using Sys.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sys.dal
{
    public class LoginInterface
    {
        public bool AddUser(User user)
            {
            string sql = string.Format("insert into Tbl_acc_inf values('{0}','{1}','{2}','{3}')",user.UserId,user.UserPasswd, user.UserName,user.UserSex);

            return DataHelper.ExecuteNonQuery(sql) > 0 ? true : false;
        }
    }
}

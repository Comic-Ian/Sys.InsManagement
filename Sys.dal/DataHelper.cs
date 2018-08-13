using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Sys.dal
{
    public class DataHelper
    {
        //创建链接字符串

            private static string connstr = "Data Source=LocalHost;Initial Catalog=Test;User ID=test;Password=test;";

        /*
           1.构建数据库链接
           2.构建数据库执行对象
           3.执行sql
           4.获得结果，关闭连接
         */

        public static int ExecuteNonQuery( string sql)
        {
            int result = 0;

            SqlConnection conn = new SqlConnection(connstr);

            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql,conn);
                result = comm.ExecuteNonQuery();
            }
            catch
            {
                conn.Close();
            }
            return result;
        }

        public static SqlDataReader ExecuteReader( string sql)
        {
            SqlConnection conn = new SqlConnection(connstr);

            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql,conn);
                return comm.ExecuteReader();
            }
            catch
            {
                conn.Close();
                return null;
            }
        }
    }
}

using Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public class UserDAO : IUserDao
    {
        public User selectByUserName(string username)
        {
            User objUser = null;

            //string sql = string.Format("SELECT classid,classname,remark  FROM class WHERE classid = {0}", classid);           
            //MySqlDataReader reader = MySQLHelper.ExecuteReader(sql);

            string sql = "SELECT UID,username,password  FROM User WHERE username = @username";
            MySqlParameter p1 = new MySqlParameter("@username", username);
            MySqlDataReader reader = MySQLHelper.ExecuteReader(sql, p1);

            if (reader.Read())
            {
                //读取一条记录：循环中不建议拆箱与装箱
                //objClass = new Class((int)reader["classid"],(string)reader["classname"],(string)reader["remark"]);
                //此语句效率更高：无拆箱操作
                objUser = new User(reader.GetInt32("UID"), reader.GetString("username"), reader.GetString("password"));
            }
            reader.Close();

            return objUser;
        }

        public int insert(User objUser)
        {
            int line = 0;

            //string sql = string.Format("insert into class(classname,remark) values('{0}','{1}')", objClass.ClassName, objClass.Remark);
            //string sql = string.Format("insert into class(classname,remark,class_uuid) values('{0}','{1}','{2}')", objClass.ClassName, objClass.Remark,"32");
            //line = MySQLHelper.ExecuteSql(sql);

            string sql = "insert into user (username,password) values(@username,@password)";
            //MySqlParameter p1 = new MySqlParameter("@classname", objClass.ClassName);
            //MySqlParameter p2 = new MySqlParameter("@remark", objClass.Remark);
            //line = MySQLHelper.ExecuteSql(sql, p1, p2);

            List<MySqlParameter> parameters = new List<MySqlParameter>();
            parameters.Add(new MySqlParameter("@username", objUser.UserName));
            parameters.Add(new MySqlParameter("@password", objUser.PassWord));
            line = MySQLHelper.ExecuteSql(sql, parameters.ToArray());

            return line;
        }


    }
}

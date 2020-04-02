using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAO
{
    public class CheckInfoDAO : ICheckInfoDAO
    {
        
        public bool Insert(string username, CheckInfo checkInfo)
        {
            int line = 0;

    
            int issuspected = 0;int isconfirmed =  0;
            if (checkInfo.IsSuspected.Equals("是"))
                issuspected = 1;
            if (checkInfo.Isconfirmed.Equals("是"))
                isconfirmed = 1;
            string sql = "insert into checkinfo (Username, CDate, Cprovince, CCity, CBodyTemperture, CIsSuspected, CIsConfirmed)" +
                "values(@username,@date,@province,@city,@temperture,@issuspected,@isconfirmed)";
            //alter table checkinfo modify CID int auto_increment;
            //INSERT into checkinfo(Username, CDate, Cprovince, CCity, CBodyTemperture, CIsSuspected, CIsConfirmed) VALUES('19170311', now(), '广西', '桂林', '37摄氏度', 0, 0)

            List<MySqlParameter> parameters = new List<MySqlParameter>();
            parameters.Add(new MySqlParameter("@username", username));
            //parameters.Add(new MySqlParameter("@id",cid ));
            //parameters.Add(new MySqlParameter("@date", DateTime.Now.Date ));
            parameters.Add(new MySqlParameter("@date", checkInfo.Date.Date ));
            parameters.Add(new MySqlParameter("@province",checkInfo.Province ));
            parameters.Add(new MySqlParameter("@city",checkInfo.City ));
            parameters.Add(new MySqlParameter("@temperture",checkInfo.Temperture ));
            parameters.Add(new MySqlParameter("@issuspected", issuspected));
            parameters.Add(new MySqlParameter("@isconfirmed", isconfirmed));
            line = MySQLHelper.ExecuteSql(sql, parameters.ToArray());  //返回插入条数
            if (line != 0)
                return true;
            else
                return false;


        }

        public bool IsChecked(User user)
        {
            int count = 0;

            string sql = "select * from checkinfo where Username = @username and CDate = @date";

            List<MySqlParameter> parameters = new List<MySqlParameter>();
            parameters.Add(new MySqlParameter("@username", user.GetUsername()));
            parameters.Add(new MySqlParameter("@date", DateTime.Now.Date));
            MySqlDataReader reader = MySQLHelper.ExecuteReader(sql, parameters.ToArray());
            while (reader.Read())
            {
                count += 1;
            }
            reader.Close();

            if (count > 0)
                return true;
            else
                return false;
        }

        public List<CheckInfo> selectALL(User user)
        {
            List<CheckInfo> checks = new List<CheckInfo>();
            string sql = string.Format("select CDate, CProvince, CCity, CBodyTemperture, CIsSuspected, CIsConfirmed from checkinfo where Username = @username");
            List<MySqlParameter> parameters = new List<MySqlParameter>();
            parameters.Add(new MySqlParameter("@username", user.GetUsername()));
            MySqlDataReader reader = MySQLHelper.ExecuteReader(sql, parameters.ToArray());
            //MySqlDataReader reader = MySQLHelper.ExecuteReader(sql);
            while (reader.Read())
            {
                //循环读取每一条记录：循环中不建议拆箱与装箱
                //objClass = new Class((int)reader["classid"], (string)reader["classname"], (string)reader["remark"]);
                //此语句效率更高：无拆箱操作
                CheckInfo objCheck = new CheckInfo(reader.GetDateTime("CDate"), reader.GetString("CProvince"), reader.GetString("CCity"),
                    reader.GetString("CBodyTemperture"), reader.GetString("CIsSuspected") == "1" ? "是" : "否", reader.GetString("CIsConfirmed") == "1" ? "是" : "否");
                //CheckInfo objCheck = new CheckInfo(Convert.ToDateTime("2020-2-25"), "1", "2", "3", "4", "5");
                checks.Add(objCheck);
            }
            reader.Close();
            return checks;
        }
    }
}

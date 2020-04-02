using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * CREATE TABLE `user` (
  `UID` int(11) NOT NULL AUTO_INCREMENT COMMENT '用户编号',
  `username` varchar(20) DEFAULT NULL COMMENT '用户名称',
  `password` varchar(20) DEFAULT NULL COMMENT '密码',
  PRIMARY KEY (`UID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COMMENT='用户信息表';

 * */


namespace Model
{
    [Serializable]
    public class User
    {
        public int UserID { get; set; }

        public string UserName { get; set; }

        public string PassWord { get; set; }

        public User(string username, string password)
        {
            this.UserName = username;
            this.PassWord = password;
        }
    
        public User(int UID, string username, string password):this(username,password)
        {
            this.UserID = UID;
        }

        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}",this.UserID,this.UserName,this.PassWord);
        }

        public string GetUsername()
        {
            return UserName;
        }
    
    }
}

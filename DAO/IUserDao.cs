using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public interface IUserDao
    {
        User selectByUserName(string username);

        int insert(User objUser);
    }
}

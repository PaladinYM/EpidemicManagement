using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAO
{
    public interface ICheckInfoDAO
    {
        bool Insert(string username,CheckInfo checkInfo);
        bool IsChecked(User user);
        List<CheckInfo> selectALL(User user);
    }
}

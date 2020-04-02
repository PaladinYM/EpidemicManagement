using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAO
{
    public interface IQuestionDAO
    {
        Question selectByTFID(int id);
        Question selectByCID(int id);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAO
{
    public interface IQuestionaireDAO
    {
        /// <summary>
        /// 自动生成问卷
        /// </summary>
        /// <param name="quesCount">问题个数</param>
        /// <returns></returns>
        Questionaire generate(int quesCount);

        int getTFQuesCount();

        int getChoiceCount();
    }
}

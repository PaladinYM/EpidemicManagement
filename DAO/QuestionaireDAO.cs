using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MySql.Data.MySqlClient;

namespace DAO
{
    public class QuestionaireDAO : IQuestionaireDAO
    {
        QuestionDao questiondao = new QuestionDao();
        public Questionaire generate(int quesCount)
        {
            Questionaire questionaire = null;
            List<Question> qs = new List<Question>();
            //选择题和判断题的个数
            int tfCount = new Random(Guid.NewGuid().GetHashCode()).Next(1, quesCount);
            int chCount = quesCount - tfCount;
            //生成题号和问卷
            for(int i=0;i<tfCount;i++)
            {
                int count = new Random(Guid.NewGuid().GetHashCode()).Next(1, getTFQuesCount());
                qs.Add(questiondao.selectByTFID(count));
            }
            for(int i=0;i<chCount;i++)
            {
                int count = new Random(Guid.NewGuid().GetHashCode()).Next(1, getChoiceCount());
                qs.Add(questiondao.selectByCID(count));
            }
            questionaire = new Questionaire(qs);
            return questionaire;
        }

        public int getChoiceCount()
        {
            int count = 0;
            string sql = "select * from ChoiceQues";
            MySqlDataReader reader = MySQLHelper.ExecuteReader(sql);

            while(reader.Read())
            {
                count++;
            }

            return count;

        }

        public int getTFQuesCount()
        {
            int count = 0;
            string sql = "select * from TrueFalseQues";
            MySqlDataReader reader = MySQLHelper.ExecuteReader(sql);

            while (reader.Read())
            {
                count++;
            }
            return count;

        }
    }
}

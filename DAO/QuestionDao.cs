using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MySql.Data.MySqlClient;

namespace DAO
{
    public class QuestionDao:IQuestionDAO
    {
        public Question selectByTFID(int id)
        {
            Question question = null;
            string sql = "select QID,Question,Answer from TrueFalseQues where QID = @QID";
            MySqlParameter p1 = new MySqlParameter("@QID", id);
            MySqlDataReader reader = MySQLHelper.ExecuteReader(sql, p1);

            if(reader.Read())
            {
                List<string> w = new List<string>();
                if (reader.GetString("Answer") == "正确")
                    w.Add("错误");
                else if (reader.GetString("Answer") == "错误")
                    w.Add("正确");
                question = new Question(reader.GetString("Question"), reader.GetString("Answer"), w);
            }
            reader.Close();
            return question;
        }

        public Question selectByCID(int id)
        {
            Question question = null;
            string sql = "select QID,Question,RightAnswer,WrongAnswer1,WrongAnswer2,WrongAnswer3 from ChoiceQues where QID = @QID";
            MySqlParameter p1 = new MySqlParameter("@QID", id);
            MySqlDataReader reader = MySQLHelper.ExecuteReader(sql, p1);

            if (reader.Read())
            {
                List<string> w = new List<string>();
                w.Add(reader.GetString("WrongAnswer1"));
                w.Add(reader.GetString("WrongAnswer2"));
                w.Add(reader.GetString("WrongAnswer3"));
                question = new Question(reader.GetString("Question"), reader.GetString("RightAnswer"), w);
            }
            reader.Close();
            return question;
        }
    }
}

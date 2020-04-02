using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Question
    {
        public string content { get; set; }
        public string answer { get; set; }
        public List<string> wrongAns { get; set; }
        public Question()
        {

        }
        /// <summary>
        /// 问题
        /// </summary>
        /// <param name="q">问题内容</param>
        /// <param name="a">正确答案</param>
        /// <param name="w">错误答案</param>
        public Question(string c, string a, List<string> w)
        {
            this.content = c;
            this.answer = a;
            this.wrongAns = w;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Questionaire
    {
        public List<Question> questions{ get; set; }
        public Questionaire()
        {

        }
        /// <summary>
        /// 一份问卷
        /// </summary>
        /// <param name="qs">所有的问题</param>
        public Questionaire(List<Question> qs)
        {
            this.questions = qs;
        }  
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using BLL;

namespace Guardian
{
    public partial class QuestionAnswer : Form
    {
        IQuestionaireBLL questionairebll = new QuestionaireBLL();
        private Questionaire questionaire = null;
        private int sequence = 0;
        private string[] userAns;

        public static int FormCount = 0;

        public QuestionAnswer()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (optBtn2.Checked)
            {
                userAns[sequence] = optBtn2.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(btnNxt.Text == "提交")
            {
                //获取正确率
                int score = 0;
                for(int i=0;i<5;i++)
                {
                    if(userAns[i] == questionaire.questions[i].answer)
                    {
                        score++;
                    }
                }
                MessageBox.Show("您的得分为" + score * 20 + "，满分为100");
                this.Close();
                this.Dispose();
                //成绩写入数据库
                //questionairebll
            }
            else
            {
                
                sequence++;
                refresh(sequence);
            }
        }

        private void refresh(int j)
        {
            txtQues.Text = questionaire.questions[j].content;
            int optCount = questionaire.questions[j].wrongAns.Count;
            List<string> options = new List<string>();
            options.Add(questionaire.questions[j].answer);
            for (int i = 0; i < optCount; i++)
            {
                options.Add(questionaire.questions[j].wrongAns[i]);
            }
            List<string> abcd = new List<string>();
            //选项乱序
            foreach (var item in options)
            {
                int c = new Random().Next(abcd.Count);
                abcd.Insert(c, item);
            }
            //控件调整
            optBtn1.Text = abcd[0];
            optBtn2.Text = abcd[1];
            if (abcd.Count > 2)
            {
                optBtn3.Text = abcd[2];
                optBtn4.Text = abcd[3];
                optBtn3.Visible = true;
                optBtn4.Visible = true;
            }
            else
            {
                optBtn3.Visible = false;
                optBtn4.Visible = false;
            }
            if(j == 0)
            {
                btnLst.Visible = false;
            }
            else
            {
                btnLst.Visible = true;
            }
            if(j == questionaire.questions.Count-1)
            {
                btnNxt.Text = "提交";
            }
            else
            {
                btnNxt.Text = "下一题";
            }

            if (userAns[j] == optBtn1.Text)
            {
                optBtn1.Checked = true;
                optBtn2.Checked = false;
                optBtn3.Checked = false;
                optBtn4.Checked = false;
            }
            else if (userAns[j] == optBtn2.Text)
            {
                optBtn1.Checked = false;
                optBtn2.Checked = true;
                optBtn3.Checked = false;
                optBtn4.Checked = false;
            }
            else if (userAns[j] == optBtn3.Text)
            {
                optBtn1.Checked = false;
                optBtn2.Checked = false;
                optBtn3.Checked = true;
                optBtn4.Checked = false;
            }
            else if (userAns[j] == optBtn4.Text)
            {
                optBtn1.Checked = false;
                optBtn2.Checked = false;
                optBtn3.Checked = false;
                optBtn4.Checked = true;
            }
            else
            {
                optBtn1.Checked = false;
                optBtn2.Checked = false;
                optBtn3.Checked = false;
                optBtn4.Checked = false;
            }

        }

        private void 历史成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnLst_Click(object sender, EventArgs e)
        {
            sequence--;
            refresh(sequence);
        }

        private void optBtn1_CheckedChanged(object sender, EventArgs e)
        {
            if(optBtn1.Checked)
            {
                userAns[sequence] = optBtn1.Text;
            }
        }

        private void optBtn3_CheckedChanged(object sender, EventArgs e)
        {
            if (optBtn3.Checked)
            {
                userAns[sequence] = optBtn3.Text;
            }
        }

        private void optBtn4_CheckedChanged(object sender, EventArgs e)
        {
            if (optBtn4.Checked)
            {
                userAns[sequence] = optBtn4.Text;
            }
        }

        private void QA_Load(object sender, EventArgs e)
        {
            FormCount += 1;
            userAns = new string[5];
            for (int i = 0; i < 5; i++)
                userAns[i] = "";
            //生成新问卷
            questionaire = questionairebll.generate(5);
            //显示问卷第一题
            refresh(0);
        }

        private void QA_Closing(object sender, FormClosingEventArgs e)
        {
            FormCount -= 1;
        }
    }
}

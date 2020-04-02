using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Guardian
{
    public partial class Tip2 : Form
    {
        public int flag = 0;
        public Tip2()
        {
            InitializeComponent();
        }

        private void Tip2_Load(object sender, EventArgs e)
        {

            if (flag == 0)
            {
                this.pictureBox1.Image = new Bitmap("病毒具体.png");
                this.label1.Text = "新冠病毒的科普";
                this.label2.Text = "    此次流行的冠状病毒为一种新发现的冠状病毒，国际病毒分类委员会命名为 SARS-Cov-2。因为人群缺少对新型病毒株的免疫力，所以人群普遍易感。由 SARS-Cov-2 冠状病毒引起，WHO 将 SARS-Cov-2 感染导致的疾病命名为 COVID-19，其中多数感染可以导致肺炎，就称之为新型冠状病毒肺炎/新冠肺炎。\n    目前初见病例是由武汉海鲜市场传染而来，最初传染源为野生动物，可能是中华菊头蝠。传染源主要是新型冠状病毒肺炎患者，无症状者也可称为传染源。病毒经飞沫传播，粪口途径亦可以传播。";
            }
            if (flag == 1)
            {
                this.pictureBox1.Image = new Bitmap("确诊1.png");
                this.label1.Text = "新冠病毒的正确确诊";
                this.label2.Text = "    新型冠状病毒肺炎往往以发热作为主要起病的表现，可合并轻度的干咳、乏力、呼吸不畅、腹泻等症状，流涕、咳嗽等症状少见。一半患者在一周后出现呼吸困难，严重者病情进展迅速，数日内即可出现急性呼吸窘迫综合征、脓毒症休克、难以纠正的代谢性酸中毒和出凝血功能障碍。\n    实验室检查：发病早期白细胞总数正常或降低，淋巴细胞计数减少，部分患者肝酶、LDH、肌酶和肌红蛋白增高；部分危重者可见肌钙蛋白增高。多数患者 C 反应蛋白和血沉升高，降钙素原正常。严重者 D-二聚体升高。新型冠状病毒可通过实时荧光 RT-PCR 鉴定。";
            }
            if (flag == 2)
            {
                this.pictureBox1.Image = new Bitmap("治疗1.png");
                this.label1.Text = "新冠肺炎真正的治疗方法";
                this.label2.Text = "·卧床休息，加强支持治疗，注意水、电解质平衡，维持内环境稳定；\n·根据病情监测各项指标；根据血氧饱和度变化，及时给予有效氧疗措施；\n·抗病毒治疗：目前暂无有效抗病毒药物，有几种药物已经紧急申请了临床试验，正在试用，等待进一步报告。\n·抗菌药物治疗：加强细菌学监测，有继发感染证据时及时应用抗菌药物。";
            }
            if (flag == 3)
            {
                this.pictureBox1.Image = new Bitmap("口罩.png");
                this.label1.Text = "新冠肺炎的有效防范措施";
                this.label2.Text = "·避免去疫情高发区避免去人流密集的场所。\n·避免到封闭、空气不流通的公共场所和人多聚集的地方，尤其是儿童、老年人和免疫力低下的人群。\n·外出记得佩戴口罩。\n·加强开窗通风。居家每天都要开窗通风一段时间。加强空气流通，可有效预防呼吸道传染病。\n·注意个人卫生。勤洗手，用肥皂和流动水或者免洗洗手液洗手。\n·打喷嚏或咳嗽的时候注意用纸巾或胳膊肘捂住口鼻，不要直接用双手捂住口鼻。\n·及时观察就医。如果出现发热、咳嗽、气促等呼吸道感染症状，应及时佩戴口罩并及时就医。";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}

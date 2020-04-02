using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Sunisoft.IrisSkin;
using Newtonsoft.Json.Linq;
using Model;
using System.Threading;

namespace Guardian
{
    public partial class Form1 : Form
    {
        login frm;

        private SkinEngine objSkinEngine = new SkinEngine();
        string path = Application.StartupPath;
        string ext = ".ssk";
        string filename = "skin.dat";
        string skin_path = Application.StartupPath + "/skin/";

        private User objUser;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(login frm, User user)
        {
            InitializeComponent();
            this.frm = frm;
            this.objUser = user;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //skinEngine1 = new SkinEngine();
            //skinEngine1.SkinFile = "SteelBlack.ssk";

            //1. 读取文件设置皮肤
            ReadSkin();
            
            //2. 读取皮肤文件列表，动态形成菜单
            LoadSkin();
            FormBorderStyle = FormBorderStyle.FixedDialog;

            //3. 点击动态形成的菜单，立即换肤，并保存为文件

            LoadTime();

            //图表操作
            //Titles：1、设置标题
            //属性设计
            //等价：chart.Titles.Add("疫情数据展示")
            //美化过程：

            //ChartAreas：2、设置图表区域
            //默认存在一个图表区域ChartArea1
            //通过代码添加图表区，与设计时添加等价：chart1.ChartAreas.Add("ChartArea2");
            //美化过程：

            //Series：3、图表序列
            //默认存在一个图表序列：Series1，并与ChartArea1关联
            //添加一个图表序列：chart1.Series.Add("Series2");
            //指定和某个图表区关联：chart1.Series["Series2"].ChartArea = "ChartArea1";
            //修改图表序列名称:

            chart1.Titles.Add("全国疫情数据表");
            for (int i = 2; i <= 5; ++i)
            {
                chart1.Series.Add("Series" + i.ToString());
            }
            chart1.Series["Series1"].Name = "现存确诊人数";
            chart1.Series["Series2"].Name = "累计确诊人数";
            chart1.Series["Series3"].Name = "疑似感染人数";
            chart1.Series["Series4"].Name = "治愈人数";
            chart1.Series["Series5"].Name = "死亡人数";

            chart1.Series[0].YValueMembers = "人数";
            for (int i = 0; i < 5; ++i)
            {
                chart1.Series[i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart1.Series[i].Label = "#VAL";
            }
        }

        public void ReadSkin()
        {
            string filedat = path + "/" + filename;
            
            if (File.Exists(filedat))
            {
                StreamReader reader = new StreamReader(filedat);
                //皮肤名称
                string skinname = reader.ReadLine();
                reader.Close();
                //设置皮肤
                objSkinEngine.SkinFile = skin_path + skinname + ext;
                //保存当前使用的皮肤名称
                mnuSkin.Tag = skinname;
            }
            
        }

        public void LoadSkin()
        {
            DirectoryInfo skinDir = new DirectoryInfo(skin_path);
            foreach (FileInfo f in skinDir.GetFiles())
            {
                //文件名，不包含后缀
                string mnu_text = f.Name.Substring(0, f.Name.Length - 4);
                //动态添加菜单项
                ToolStripMenuItem mnu = mnuSkin.DropDownItems.Add(mnu_text) as ToolStripMenuItem;
                //不选中
                mnu.Checked = false;
                //保存皮肤文件真实地址
                mnu.Tag = f.FullName;
                //加载后的皮肤名称，若和某个菜单项相同，则该菜单处于选中状态
                if (mnu.Text == mnuSkin.Tag.ToString())
                {
                    mnu.Checked = true;
                }
                //订阅动态添加的菜单项事件
                mnu.Click += Mnu_Click;
            }
        }

        private void Mnu_Click(object sender, EventArgs e)
        {
            //3. 点击动态形成的菜单，立即换肤，并保存为文件
            //当前被点击的菜单项
            ToolStripMenuItem currentMenuItem = sender as ToolStripMenuItem;
            //立即换肤
            //objSkinEngine.SkinFile = currentMenuItem.Tag.ToString();
            //frm.ReadSkin();

            //换肤之后，立即保存皮肤的名称
            mnuSkin.Tag = currentMenuItem.Text;
            //选中状态
            foreach (ToolStripMenuItem item in mnuSkin.DropDownItems)
            {
                item.Checked = false;
                if (item == currentMenuItem)
                {
                    item.Checked = true;
                }
            }
            //保存为文件
            string filedat = path + "/" + filename;
            StreamWriter writer = new StreamWriter(filedat);
            writer.WriteLine(currentMenuItem.Text) ;
            writer.Close();
            //写入文件后，父窗口换肤
            frm.ReadSkin();
        }

        public void LoadTime()
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Form2.FormCount == 0)
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text = "数据更新中...";
            //网络请求数据
            WebRequest wReq = WebRequest.Create("https://lab.isaaclin.cn/nCoV/api/overall?latest=0");
            WebResponse wResp = wReq.GetResponse();
            Stream respStream = wResp.GetResponseStream();
            StreamReader reader = new StreamReader(respStream, Encoding.GetEncoding("UTF-8"));
            //json解析
            string json = reader.ReadToEnd();
            JObject jObject = JObject.Parse(json);

            //MessageBox.Show(jObject["results"][6]["deadCount"].ToString());
            //MessageBox.Show(DateTime.Now.ToString("MM-dd"));
            //MessageBox.Show(json);


            //准备数据
            List<string> datelist = new List<string>();   // { "2.15", "2.16", "2.17", "2.18", "2.19", "2.20", "2.21" };
            List<int> CurrentConfirmedCount = new List<int>();   // { 66581, 68595, 70644, 72532, 74279, 74680, 75570};
            List<int> ConfirmedCount = new List<int>(); // { 56563, 57165, 57594, 57657, 57886, 55837, 54961};
            List<int> SuspectedCount = new List<int>();
            List<int> CuredCount = new List<int>();
            List<int> DeadCount = new List<int>();
            //设置图表类型
            long BaseTime = 1582300800000;  //2020-2-21 24:00
            long AddDay = DateTime.Now.Date.Subtract(Convert.ToDateTime("2020-02-21")).Days;    //与2020-2-21间隔天数
            //MessageBox.Show(AddDay.ToString());
            long Factor = 86400000;
            int count = 0;
            foreach (JToken jToken in jObject["results"])
            {
                if (long.Parse(jToken["updateTime"].ToString()) <= BaseTime + Factor * AddDay)
                {
                    CurrentConfirmedCount.Add(int.Parse(jToken["currentConfirmedCount"].ToString()));
                    ConfirmedCount.Add(int.Parse(jToken["confirmedCount"].ToString()));
                    SuspectedCount.Add(int.Parse(jToken["suspectedCount"].ToString()));
                    CuredCount.Add(int.Parse(jToken["curedCount"].ToString()));
                    DeadCount.Add(int.Parse(jToken["deadCount"].ToString()));
                    datelist.Add(DateTime.Now.AddDays(-count).ToString("MM-dd"));
                    AddDay -= 1;
                    count += 1;
                }
                if (count >= 7)
                {
                    break;
                }
            }
            CurrentConfirmedCount.Reverse();
            ConfirmedCount.Reverse();
            SuspectedCount.Reverse();
            CuredCount.Reverse();
            DeadCount.Reverse();
            datelist.Reverse();
            //chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            //chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            //数据库中获取数据

            //绑定数据

            chart1.Series[0].Points.DataBindXY(datelist, CurrentConfirmedCount);
            chart1.Series[1].Points.DataBindXY(datelist, ConfirmedCount);
            chart1.Series[2].Points.DataBindXY(datelist, SuspectedCount);
            chart1.Series[3].Points.DataBindXY(datelist, CuredCount);
            chart1.Series[4].Points.DataBindXY(datelist, DeadCount);
            //Legends：图表图例

            //Annotations：图表批注

            label2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (QuestionAnswer.FormCount == 0)
            {
                QuestionAnswer qa = new QuestionAnswer();
                qa.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Check.FormCount == 0)
            {
                Check c = new Check(objUser);
                c.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Tip1.FormCount == 0)
            {
                Tip1 t = new Tip1();
                t.Show();
            }
        }
        
        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            frm.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (browser.FormCount == 0)
            {
                browser b = new browser();
                b.Show();
            }
        }
    }
}

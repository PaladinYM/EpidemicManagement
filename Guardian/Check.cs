using System;
using System.Windows.Forms;
using Model;
using BLL;
using System.Collections.Generic;

namespace Guardian
{
    public partial class Check : Form
    {
        public static int FormCount = 0;
        ICheckInfoBLL checkbll = new CheckInfoBLL();

        Dictionary<string, string> Address = new Dictionary<string, string>(); //存放省份城市的字典

        //User user = new User("19170311", "123456"); //用于测试的user类，可以直接替换许心怡的
        private User objUser;
        public Check()
        {
            InitializeComponent();
            loadData();
            label6.Text = System.DateTime.Now.Date.ToShortDateString();
        }
        public Check(User user)
        {
            InitializeComponent();
            loadData();
            label6.Text = System.DateTime.Now.Date.ToShortDateString();
            objUser = user;
        }

        private void checkbtn_Click(object sender, EventArgs e)
        {
            if (ProvinceCbBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("省份不能为空！", "信息");
                return;
            }
            if (CityCbBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("城市不能为空！", "信息");
                return;
            }
            if (TempertureCbBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("体温不能为空！", "信息");
                return;
            }
            if (IsSuspectedCBBox.Text.Trim().Length == 0 || IsconfirmedCBBox .Text.Trim().Length == 0)
            {
                MessageBox.Show("信息不能为空！", "信息");
                return;
            }
           
           //将打卡信息保存在CheckInfo类中
            CheckInfo objcheck = new CheckInfo(DateTime.Now.Date, ProvinceCbBox.Text, CityCbBox.Text, TempertureCbBox.Text, IsSuspectedCBBox.Text, IsconfirmedCBBox.Text);
           //读取学生学号、打卡信息传入insert()中
            bool result = checkbll.insert(objUser.GetUsername(),objcheck); 
            //根据返回结果，显示不同的消息
            if (result)
            {
                MessageBox.Show("打卡成功！", "信息");
                checkbtn.Text = "已提交";
                checkbtn.Enabled = false;
                ProvinceCbBox.Enabled = false;
                CityCbBox.Enabled = false;
                TempertureCbBox.Enabled = false;
                IsSuspectedCBBox.Enabled = false;
                IsconfirmedCBBox.Enabled = false;
                this.Close();
            }
            else
            {
                MessageBox.Show("错误：打卡失败！", "信息");
            }
        }

        private void ProvinceCbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //添加之前先把市级下拉框清空 避免追加数据 
            
            CityCbBox.Items.Clear();
            //通过值查找键值
            foreach (KeyValuePair<string, string> kvp in Address)
            {
                if (kvp.Value.Equals(ProvinceCbBox.SelectedItem.ToString()))
                {
                    CityCbBox.Items.Add(kvp.Key);
                }
            }
        }

        void loadData()
        {
            Address.Add("上海", "直辖市"); Address.Add("北京", "直辖市");
            Address.Add("天津", "直辖市");
            Address.Add("重庆", "直辖市");
            Address.Add("南京", "江苏");
            Address.Add("扬州", "江苏");
            Address.Add("无锡", "江苏");
            Address.Add("连云港", "江苏");
            Address.Add("宿迁", "江苏");
            Address.Add("淮安", "江苏");
            Address.Add("盐城", "江苏");
            Address.Add("常州", "江苏");
            Address.Add("苏州", "江苏");
            Address.Add("南通", "江苏");
            Address.Add("泰州", "江苏");
            Address.Add("徐州", "江苏");

             Address.Add("杭州", "浙江"); Address.Add("温州", "浙江");
            Address.Add("武汉", "湖北"); Address.Add("黄冈", "湖北");
            Address.Add("合肥", "安徽");Address.Add("黄山", "安徽");
            Address.Add("九江", "江西");Address.Add("南昌", "江西");
            Address.Add("绵阳", "四川");Address.Add("成都", "四川");
            Address.Add("广汉", "四川");

            Address.Add("广州", "广东");Address.Add("珠海", "广东");
            Address.Add("湛江", "广东"); Address.Add("深圳", "广东");
            Address.Add("东莞", "广东");
            Address.Add("南宁", "广西"); Address.Add("桂林", "广西");



            //通过循环值添加进省会下拉框
            foreach (string province in Address.Values)
            {
                //判断下 避免重复添加省会名
                if (!ProvinceCbBox.Items.Contains(province))
                    ProvinceCbBox.Items.Add(province);
            }
        }
        private void Check_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            FormCount += 1;

            if (checkbll.ischecked(objUser))
            {
                checkbtn.Enabled = false;
                ProvinceCbBox.Enabled = false;
                CityCbBox.Enabled = false;
                TempertureCbBox.Enabled = false;
                IsSuspectedCBBox.Enabled = false;
                IsconfirmedCBBox.Enabled = false;
                MessageBox.Show("今日已打卡，请勿重复打卡！");
            }
        }

        private void Check_Closing(object sender, FormClosingEventArgs e)
        {
            FormCount -= 1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            if (CheckHistory.FormCount == 0)
            {
                CheckHistory ch = new CheckHistory(objUser);
                ch.Show();
            }
        }
    }
}

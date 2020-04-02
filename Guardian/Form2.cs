using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;

namespace Guardian
{
    public partial class Form2 : Form
    {
        public static int FormCount = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            FormCount += 1;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            WebRequest wReq = WebRequest.Create("https://lab.isaaclin.cn/nCoV/api/area");
            WebResponse wResp = wReq.GetResponse();
            Stream respStream = wResp.GetResponseStream();
            StreamReader reader = new StreamReader(respStream, Encoding.GetEncoding("UTF-8"));
            //json解析
            string json = reader.ReadToEnd();
            JObject jObject = JObject.Parse(json);
            foreach (JToken jToken in jObject["results"])
            {
                comboBox1.Items.Add(jToken["provinceName"].ToString());
            }
        }
        private void Form2_Closing(object sender, FormClosingEventArgs e)
        {
            FormCount -= 1;
        }

        private void comboBox1_SelectedItemChanged(object sender, EventArgs e)
        {
            comboBox2.Text = null;
            comboBox2.Items.Clear();
            string province = comboBox1.Text;
            WebRequest wReq = WebRequest.Create("https://lab.isaaclin.cn/nCoV/api/area?province=" + province);
            WebResponse wResp = wReq.GetResponse();
            Stream respStream = wResp.GetResponseStream();
            StreamReader reader = new StreamReader(respStream, Encoding.GetEncoding("UTF-8"));
            //json解析
            string json = reader.ReadToEnd();
            JObject jObject = JObject.Parse(json);
            foreach (JToken jToken in jObject["results"][0]["cities"])
            {
                comboBox2.Items.Add(jToken["cityName"].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == null || comboBox1.Text == "")
            {
                MessageBox.Show("请选择省份/区域！");
                return;
            }
            string province = comboBox1.Text;
            string city = comboBox2.Text;
            Form3 form3 = new Form3(province, city);
            form3.ShowDialog();
        }

    }
}

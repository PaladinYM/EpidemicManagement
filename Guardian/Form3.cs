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
    public partial class Form3 : Form
    {
        private string province;
        private string city;
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(string province, string city)
        {
            InitializeComponent();
            this.province = province;
            this.city = city;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            WebRequest wReq = WebRequest.Create("https://lab.isaaclin.cn/nCoV/api/area?province=" + province);
            WebResponse wResp = wReq.GetResponse();
            Stream respStream = wResp.GetResponseStream();
            StreamReader reader = new StreamReader(respStream, Encoding.GetEncoding("UTF-8"));
            //json解析
            string json = reader.ReadToEnd();
            JObject jObject = JObject.Parse(json);

            chart1.Titles.Add(province + city + "疫情数据表");
            List<string> subtitle = new List<string> { "现存确诊人数", "累计确诊人数", "疑似感染人数", "治愈人数", "死亡人数" };
            List<int> count = new List<int>();

            if (city == null || city == "")
            {
                count.Add(int.Parse(jObject["results"][0]["currentConfirmedCount"].ToString()));
                count.Add(int.Parse(jObject["results"][0]["confirmedCount"].ToString()));
                count.Add(int.Parse(jObject["results"][0]["suspectedCount"].ToString()));
                count.Add(int.Parse(jObject["results"][0]["curedCount"].ToString()));
                count.Add(int.Parse(jObject["results"][0]["deadCount"].ToString()));
            }
            else
            {
                foreach (JToken jToken in jObject["results"][0]["cities"])
                {
                    if (jToken["cityName"].ToString() == city)
                    {
                        count.Add(int.Parse(jToken["currentConfirmedCount"].ToString()));
                        count.Add(int.Parse(jToken["confirmedCount"].ToString()));
                        count.Add(int.Parse(jToken["suspectedCount"].ToString()));
                        count.Add(int.Parse(jToken["curedCount"].ToString()));
                        count.Add(int.Parse(jToken["deadCount"].ToString()));
                        break;
                    }
                }
            }
            
            //MessageBox.Show(jObject["results"][0]["cities"].ToString());
            chart1.Series[0].Name = "疫情数据";
            chart1.Series[0].YValueMembers = "人数";
            chart1.Series[0].Label = "#VAL";
            chart1.Series[0].ToolTip = "#VAL人";
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart1.Series[0].Points.DataBindXY(subtitle, count);
        }
    }
}

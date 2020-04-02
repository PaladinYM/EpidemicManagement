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
    public partial class Tip1 : Form
    {
        public static int FormCount = 0;
        public Tip1()
        {
            InitializeComponent();

            //Font f=new Font(

            this.listView1.View = View.List;
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.BeginUpdate();
            
            ListViewItem lv1 = new ListViewItem();

            lv1.ImageIndex = 0;

            lv1.Text = "新冠病毒究竟是什么" ;
            lv1.ToolTipText = "点击查看详情";
            this.listView1.Items.Add(lv1);


            ListViewItem lv2 = new ListViewItem();

            lv2.ImageIndex = 1;

            lv2.Text = "新冠肺炎的确诊标准";
            lv2.ToolTipText = "点击查看详情";

            this.listView1.Items.Add(lv2);


            ListViewItem lv3 = new ListViewItem();

            lv3.ImageIndex = 2;

            lv3.Text = "治疗方法早知道";
            lv3.ToolTipText = "点击查看详情";

            this.listView1.Items.Add(lv3);


            ListViewItem lv4 = new ListViewItem();

            lv4.ImageIndex = 3;

            lv4.Text = "做好预防免感染";
            lv4.ToolTipText = "点击查看详情";

            this.listView1.Items.Add(lv4);
            
            
            this.listView1.EndUpdate();

            
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            Tip2 f = new Tip2();
            f.flag = listView1.SelectedItems[0].Index;
            f.Show();
         }

        private void Tip1_Load(object sender, EventArgs e)
        {
            FormCount += 1;
        }

        private void Tip1_Closing(object sender, FormClosingEventArgs e)
        {
            FormCount -= 1;
        }
    }
}

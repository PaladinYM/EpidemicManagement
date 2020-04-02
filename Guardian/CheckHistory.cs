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
using System.Security.Cryptography;

namespace Guardian
{
    public partial class CheckHistory : Form
    {
        public static int FormCount = 0;
        //数据源绑定
        BindingSource bds = new BindingSource();
        ICheckInfoBLL cibll = new CheckInfoBLL();
        User objUser;
        public CheckHistory()
        {
            InitializeComponent();
        }

        public CheckHistory(User user)
        {
            InitializeComponent();
            objUser = user;
        }

        private void CheckHistory_Load(object sender, EventArgs e)
        {
            FormCount += 1;

            //加载用户名
            label1.Text = "用户名: " + objUser.GetUsername();

            List<CheckInfo> ci = cibll.selectALL(objUser);
            //MessageBox.Show(ci[1].Isconfirmed);
            //此处bds放上面了
            bds.DataSource = ci;
            dataGridView1.DataSource = bds;
        }

        private void CheckHistory_Closing(object sender, FormClosingEventArgs e)
        {
            FormCount -= 1;
        }
    }
}

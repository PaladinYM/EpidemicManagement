using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace Guardian
{
    public partial class browser : Form
    {
        ChromiumWebBrowser browser1 = new ChromiumWebBrowser();
        public static int FormCount = 0;
        static bool flag = true;
        public browser()
        {
            InitializeComponent();
        }

        private void browser_Load(object sender, EventArgs e)
        {
            FormCount += 1;
            FormBorderStyle = FormBorderStyle.FixedDialog;

            if (flag)
            {
                Cef.Initialize(new CefSettings());
                flag = false;
            }
            browser1.Dock = DockStyle.Fill;
            this.Controls.Add(browser1);
            browser1.Load("https://vp.fact.qq.com/home?ADTAG=xw-1.jz&chlid=news_news_top&devid=7cc3fdfd5ab80b44&qimei=862187033020340&uid=&shareto=wx&from=singlemessage&isappinstalled=0");
        }

        private void browser_Closing(object sender, FormClosingEventArgs e)
        {
            FormCount -= 1;
        }
    }
}

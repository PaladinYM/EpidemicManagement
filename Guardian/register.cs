using Model;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guardian
{
    public partial class register : Form
    {
        IUserBLL userbll = new UserBLL();
        public register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim().Length == 0)
            {
                MessageBox.Show("信息", "用户名不能为空！");
                return;
            }
            if (txtUserName.Text.Trim().Length != 0 && txtPassWord.Text.Trim().Length == 0)
            {
                MessageBox.Show("密码不能为空！", "信息");
                return;
            }
            if (txtUserName.Text.Trim().Length != 0 && txtPassWord.Text.Trim() != txtPassWord2.Text.Trim())
            {
                MessageBox.Show("确认密码错误！", "信息");
                return;
            }
            User objUser = new User(txtUserName.Text.Trim(), txtPassWord.Text.Trim());

            bool result = userbll.register(objUser);
            if (result == true)
            {
                MessageBox.Show("注册成功！", "信息");
                login f = new login();
                this.Visible = false;
                f.Show();

            }
            else
            {
                MessageBox.Show("注册失败，用户名已存在！", "信息");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void register_FormClosing(object sender, FormClosingEventArgs e)
        {
            login f = new login();
            this.Visible = false;
            f.Show();
        }
        private void register_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }
    }
}

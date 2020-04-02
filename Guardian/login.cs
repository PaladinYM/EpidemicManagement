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
using Sunisoft.IrisSkin;
using System.Net;
using System.IO;

namespace Guardian
{
    public partial class login : Form
    {
        private SkinEngine objSkinEngine = new SkinEngine();
        string path = Application.StartupPath;
        string ext = ".ssk";
        string filename = "skin.dat";
        string skin_path = Application.StartupPath + "/skin/";

        IUserBLL userbll = new UserBLL();
        public login()
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
            User objUser = new User(txtUserName.Text.Trim(), txtPassWord.Text.Trim());

            bool result = userbll.login(objUser);
            if (result == true)
            {
                MessageBox.Show("登录成功！", "信息");
                Form1 f = new Form1(this, objUser);
                this.Visible = false;
                f.Show();
            }
            else
            {
                MessageBox.Show("登录失败，用户名不存在或者密码错误！", "信息");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            register r = new register();
            this.Visible = false;
            r.Show();
            //this.Close();
        }

        private void login_Load(object sender, EventArgs e)
        {
            //1. 读取文件设置皮肤
            ReadSkin();

            //2. 读取皮肤文件列表，动态形成菜单
            //LoadSkin();
            FormBorderStyle = FormBorderStyle.FixedDialog;

            //3. 点击动态形成的菜单，立即换肤，并保存为文件
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
            }

        }
    }
}

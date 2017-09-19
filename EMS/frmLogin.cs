using System;
using System.Data;
using System.Windows.Forms;
using EMS.BaseClass;

namespace EMS
{
    public partial class frmLogin : Form
    {
        private readonly BaseClass.BaseInfo baseinfo = new BaseClass.BaseInfo();
        private readonly cPopedom popedom = new cPopedom();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == string.Empty)
            {
                MessageBox.Show("用户名称不能为空！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataSet ds = null;
            popedom.SysUser = txtUserName.Text;
            popedom.Password = txtUserPwd.Text;
            ds = baseinfo.Login(popedom);
            if (ds.Tables[0].Rows.Count > 0)
            {
                frmMain frm_main = new frmMain();
                frm_main.Show();
                if (Convert.ToBoolean(ds.Tables[0].Rows[0]["stock"])) frm_main.toolStripMenuItem1.Enabled = true;
                if (Convert.ToBoolean(ds.Tables[0].Rows[0]["vendition"])) frm_main.toolStripMenuItem7.Enabled = true;
                if (Convert.ToBoolean(ds.Tables[0].Rows[0]["storage"])) frm_main.toolStripMenuItem15.Enabled = true;
                if (Convert.ToBoolean(ds.Tables[0].Rows[0]["system"])) frm_main.toolStripMenuItem24.Enabled = true;
                if (Convert.ToBoolean(ds.Tables[0].Rows[0]["base"])) frm_main.toolStripMenuItem20.Enabled = true;
                Visible = false;
            }
            else
            {
                MessageBox.Show("用户名称或密码不正确！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUserName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13) txtUserPwd.Focus();
        }

        private void txtUserPwd_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13) btnLogin.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
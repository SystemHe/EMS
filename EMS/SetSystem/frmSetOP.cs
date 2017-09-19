using System;
using System.Windows.Forms;
using EMS.BaseClass;

namespace EMS.SetSystem
{
    public partial class frmSetOP : Form
    {
        private readonly BaseClass.BaseInfo baseinfo = new BaseClass.BaseInfo();
        private readonly cPopedom popedom = new cPopedom();
        private int ID;

        public frmSetOP()
        {
            InitializeComponent();
        }

        public void SetHeadText()
        {
            dgvSysUserList.Columns[0].HeaderText = "ID";
            dgvSysUserList.Columns[0].Width = 40;
            dgvSysUserList.Columns[1].HeaderText = "�û�����";
            dgvSysUserList.Columns[2].HeaderText = "�û�����";
            dgvSysUserList.Columns[3].HeaderText = "��������";
            dgvSysUserList.Columns[3].Width = 80;
            dgvSysUserList.Columns[4].HeaderText = "���۹���";
            dgvSysUserList.Columns[4].Width = 80;
            dgvSysUserList.Columns[5].HeaderText = "������";
            dgvSysUserList.Columns[5].Width = 80;
            dgvSysUserList.Columns[6].HeaderText = "ϵͳ����";
            dgvSysUserList.Columns[6].Width = 80;
            dgvSysUserList.Columns[7].HeaderText = "������Ϣ����";
        }

        private void tlbtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tlbtnAdd_Click(object sender, EventArgs e)
        {
            if (tltxtUserName.Text == string.Empty)
            {
                MessageBox.Show("�û����Ʋ���Ϊ�գ�", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (baseinfo.FindUserName(tltxtUserName.Text))
            {
                MessageBox.Show("�û������Ѿ����ڣ�������ظ����û�����", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            baseinfo.AddSysUser(tltxtUserName.Text, tltxtPwd.Text);
            MessageBox.Show("ϵͳ���û�--��ӳɹ���", "�ɹ���ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvSysUserList.DataSource = baseinfo.GetAllUser().Tables[0].DefaultView;
            SetHeadText();
        }

        private void tlbtnDel_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                MessageBox.Show("��ѡ��Ҫɾ����ϵͳ�û���", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            baseinfo.DeleteSysUser(ID);
            MessageBox.Show("ϵͳ�û�--ɾ���ɹ���", "�ɹ���ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvSysUserList.DataSource = baseinfo.GetAllUser().Tables[0].DefaultView;
            SetHeadText();
        }

        private void frmSetOP_Load(object sender, EventArgs e)
        {
            dgvSysUserList.DataSource = baseinfo.GetAllUser().Tables[0].DefaultView;
            SetHeadText();
        }

        private void tlbtnUpdate_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                MessageBox.Show("��ѡ��Ҫ�޸ĵ�ϵͳ�û���", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            popedom.SysUser = tltxtUserName.Text;
            popedom.Password = tltxtPwd.Text;

            baseinfo.UpdateSysUser(popedom);
            dgvSysUserList.DataSource = baseinfo.GetAllUser().Tables[0].DefaultView;
            SetHeadText();
        }

        private void dgvSysUserList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                popedom.Stock = Convert.ToBoolean(dgvSysUserList[3, e.RowIndex].Value.ToString());
                popedom.Vendition = Convert.ToBoolean(dgvSysUserList[4, e.RowIndex].Value.ToString());
                popedom.Storage = Convert.ToBoolean(dgvSysUserList[5, e.RowIndex].Value.ToString());
                popedom.SystemSet = Convert.ToBoolean(dgvSysUserList[6, e.RowIndex].Value.ToString());
                popedom.Base_Info = Convert.ToBoolean(dgvSysUserList[7, e.RowIndex].Value.ToString());
            }
            catch
            {
            }
        }

        private void dgvSysUserList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID = Convert.ToInt16(dgvSysUserList[0, e.RowIndex].Value.ToString());
                tltxtUserName.Text = dgvSysUserList[1, e.RowIndex].Value.ToString();
                tltxtPwd.Text = dgvSysUserList[2, e.RowIndex].Value.ToString();
                popedom.ID = ID;
            }
            catch
            {
            }
        }
    }
}
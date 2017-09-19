using System;
using System.Windows.Forms;

namespace EMS.SetSystem
{
    public partial class frmBakup : Form
    {
        private readonly BaseClass.BaseInfo baseinfo = new BaseClass.BaseInfo();

        public frmBakup()
        {
            InitializeComponent();
        }

        private void btnBak_Click(object sender, EventArgs e)
        {
            string fileName = "";
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = ".bak";
            saveFile.ShowDialog();
            fileName = saveFile.FileName;
            if (fileName == "") return;
            baseinfo.BackUp(fileName);
            MessageBox.Show("���ݿⱸ��--�ɹ���", "�ɹ���ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRestor_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "BakUp files (*.bak)|*.bak";
            openFile.ShowDialog();
            string fileName = "";
            fileName = openFile.FileName;
            if (fileName == "") return;
            baseinfo.ReStore(fileName);
            MessageBox.Show("���ݿ�ָ�--�ɹ���", "�ɹ���ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
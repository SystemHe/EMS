using System;
using System.Windows.Forms;

namespace EMS.SaleStock
{
    public partial class frmSellStockDetailed : Form
    {
        public frmSellStockDetailed()
        {
            InitializeComponent();
        }

        private void frmSellDetailed_Load(object sender, EventArgs e)
        {
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                dgvResellStockList.Columns[0].HeaderText = "�����˻�����";
                dgvResellStockList.Columns[1].HeaderText = "���ݱ��";
                dgvResellStockList.Columns[2].HeaderText = "��Ʒ���";
                dgvResellStockList.Columns[3].HeaderText = "��Ʒ����";
                dgvResellStockList.Columns[4].HeaderText = "�����˻��۸�";
                dgvResellStockList.Columns[5].HeaderText = "�����˻�����";
                dgvResellStockList.Columns[5].HeaderText = "�����˻�����";
            }
        }
    }
}
using System;
using System.Data;
using System.Windows.Forms;
using EMS.BuyStock;
using EMS.SaleStock;

namespace EMS.SelectDataDialog
{
    public partial class frmSelectHandle : Form
    {
        public string M_str_object = "";
        public frmBuyStock buyStock;
        public frmRebuyStock reBuyStock;
        public frmResellStock resellStock;
        public frmSellStock sellStock;

        public frmSelectHandle()
        {
            InitializeComponent();
        }

        private void selectHandle_Load(object sender, EventArgs e)
        {
            BaseClass.BaseInfo baseinfo = new BaseClass.BaseInfo();
            DataSet ds = baseinfo.GetAllEmployee("tb_employee");
            dgvSelectHandleList.DataSource = ds.Tables[0].DefaultView;

            //�����б����
            dgvSelectHandleList.Columns[0].HeaderText = "ְԱ���";
            dgvSelectHandleList.Columns[1].HeaderText = "ְԱ����";
            dgvSelectHandleList.Columns[2].HeaderText = "�Ա�";
            dgvSelectHandleList.Columns[3].HeaderText = "���ڲ���";
            dgvSelectHandleList.Columns[4].HeaderText = "��ϵ�绰";
            dgvSelectHandleList.Columns[5].HeaderText = "��ע";
        }

        private void dgvSelectHandleList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (M_str_object == "BuyStock")
            {
                buyStock.txtHandle.Text = dgvSelectHandleList[1, e.RowIndex].Value.ToString(); //ѡ�о�����
                Close();
            }
            if (M_str_object == "ResellStock")
            {
                resellStock.txtHandle.Text = dgvSelectHandleList[1, e.RowIndex].Value.ToString(); //ѡ�о�����
                Close();
            }
            if (M_str_object == "RebuyStock")
            {
                reBuyStock.txtHandle.Text = dgvSelectHandleList[1, e.RowIndex].Value.ToString(); //ѡ�о�����
                Close();
            }
            if (M_str_object == "SellStock")
            {
                sellStock.txtHandle.Text = dgvSelectHandleList[1, e.RowIndex].Value.ToString(); //ѡ�о�����
                Close();
            }
        }
    }
}
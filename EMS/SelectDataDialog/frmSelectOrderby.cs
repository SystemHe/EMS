using System;
using System.Data;
using System.Windows.Forms;
using EMS.SaleStock;

namespace EMS.SelectDataDialog
{
    public partial class frmSelectOrderby : Form
    {
        private readonly BaseClass.BaseInfo baseinfo = new BaseClass.BaseInfo(); //����BaseInfo��Ķ���

        public frmSelectOrderby()
        {
            InitializeComponent();
        }

        private void frmSelectOrderby_Load(object sender, EventArgs e)
        {
            DataSet ds = null; //�������ݼ�����
            ds = baseinfo.SetUnitsList("tb_units"); //��ȡ������λ��Ϣ
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++) //����������λ��Ϣ���ݼ�
            {
                cmbUnits.Items.Add(ds.Tables[0].Rows[i]["fullname"].ToString()); //��ʾ������λ����
            }
            ds = baseinfo.SetHandleList("tb_employee"); //��ȡְԱ��Ϣ
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++) //����ְԱ��Ϣ����
            {
                cmbHandle.Items.Add(ds.Tables[0].Rows[i]["fullname"].ToString()); //��ʾְԱ����
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            frmSellStockDesc sellStockDesc = new frmSellStockDesc(); //������Ʒ�������а������
            DataSet ds = null; //�������ݼ�����
            if (rdbSaleSum.Checked) //�жϡ������۽�����С���ѡ��ť�Ƿ�ѡ��
            {
                //�����۽�����в�ѯ����
                ds = baseinfo.GetTSumDesc(cmbHandle.Text, cmbUnits.Text, dtpStar.Value, dtpEnd.Value, "tb_desc");
                sellStockDesc.dgvStockList.DataSource = ds.Tables[0].DefaultView; //����Ʒ�������а�������ʾ��ѯ��������
            }
            else
            {
                //�������������в�ѯ����
                ds = baseinfo.GetQtyDesc(cmbHandle.Text, cmbUnits.Text, dtpStar.Value, dtpEnd.Value, "tb_desc");
                sellStockDesc.dgvStockList.DataSource = ds.Tables[0].DefaultView; //����Ʒ�������а�������ʾ��ѯ��������
            }
            sellStockDesc.Show(); //��ʾ��Ʒ�������а���
            Close(); //�رյ�ǰ����
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close(); //�رյ�ǰ����
        }
    }
}
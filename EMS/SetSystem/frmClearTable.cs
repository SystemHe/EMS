using System;
using System.Windows.Forms;

namespace EMS.SetSystem
{
    public partial class frmClearTable : Form
    {
        private readonly BaseClass.BaseInfo baseinfo = new BaseClass.BaseInfo(); //����BaseInfo��Ķ���

        public frmClearTable()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (chkCurrent.Checked) //�ж���������ϸ��ѡ���Ƿ�ѡ��
                baseinfo.ClearTable("tb_currentaccount"); //��������������ϸ��Ϣ
            if (chkWarehouse.Checked) //�жϽ�����ѡ���Ƿ�ѡ��
            {
                baseinfo.ClearTable("tb_warehouse_main"); //�������������Ϣ
                baseinfo.ClearTable("tb_warehouse_detailed"); //���������ϸ����Ϣ
            }
            if (chkRewarehouse.Checked) //�жϽ����˻���ѡ���Ƿ�ѡ��
            {
                baseinfo.ClearTable("tb_rewarehouse_main"); //��������˻�������Ϣ
                baseinfo.ClearTable("tb_rewarehouse_detailed"); //��������˻���ϸ����Ϣ
            }
            if (chkSell.Checked) //�ж����۱�ѡ���Ƿ�ѡ��
            {
                baseinfo.ClearTable("tb_sell_main"); //��������������Ϣ
                baseinfo.ClearTable("tb_sell_detailed"); //����������ϸ����Ϣ
            }
            if (chkResell.Checked) //�ж������˻���ѡ���Ƿ�ѡ��
            {
                baseinfo.ClearTable("tb_resell_main"); //���������˻�������Ϣ
                baseinfo.ClearTable("tb_resell_detailed"); //���������˻���ϸ����Ϣ
            }
            if (chkUser.Checked) baseinfo.ClearTable("tb_power"); //�����û���Ϣ
            if (chkUnit.Checked) baseinfo.ClearTable("tb_unit"); //������λ��Ϣ
            if (chkStock.Checked) baseinfo.ClearTable("tb_stock"); //��������Ϣ
            if (chkEmployee.Checked) baseinfo.ClearTable("tb_employee"); //����˾ְԱ��Ϣ
            if (chkUnits.Checked) baseinfo.ClearTable("tb_units"); //����������λ��Ϣ
            MessageBox.Show("ϵͳ��������ɹ���", "�ɹ���ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close(); //�رյ�ǰ����
        }
    }
}
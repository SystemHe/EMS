using System;
using System.Data;
using System.Windows.Forms;
using EMS.BaseClass;
using EMS.SelectDataDialog;

namespace EMS.BuyStock
{
    public partial class frmRebuyStock : Form
    {
        private readonly BaseClass.BaseInfo baseinfo = new BaseClass.BaseInfo();
        private readonly cBillInfo billinfo = new cBillInfo();
        private readonly cCurrentAccount currentAccount = new cCurrentAccount();
        private readonly cStockInfo stockinfo = new cStockInfo();

        public frmRebuyStock()
        {
            InitializeComponent();
        }

        private void frmRebuyStock_Load(object sender, EventArgs e)
        {
            txtBillDate.Text = DateTime.Now.ToString("yyyy-MM-dd");

            DataSet ds = null;
            string P_Str_newBillCode = "";
            int P_Int_newBillCode = 0;

            ds = baseinfo.GetAllBill("tb_rewarehouse_main");
            if (ds.Tables[0].Rows.Count == 0)
            {
                txtBillCode.Text = DateTime.Now.ToString("yyyyMMdd") + "JHTH" + "1000001";
            }
            else
            {
                P_Str_newBillCode = Convert.ToString(ds.Tables[0].Rows[ds.Tables[0].Rows.Count - 1]["billcode"]);
                P_Int_newBillCode = Convert.ToInt32(P_Str_newBillCode.Substring(12, 7)) + 1;
                P_Str_newBillCode = DateTime.Now.ToString("yyyyMMdd") + "JHTH" + P_Int_newBillCode.ToString();
                txtBillCode.Text = P_Str_newBillCode;
            }
            txtHandle.Focus();
        }

        private void btnSelectHandle_Click(object sender, EventArgs e)
        {
            frmSelectHandle selecthandle;
            selecthandle = new frmSelectHandle();
            selecthandle.reBuyStock = this; //���´����Ĵ����������Ϊͬһ���������ʵ��������
            selecthandle.M_str_object = "RebuyStock"; //����ʶ������һ��������õ�selecthandle���ڵ�
            selecthandle.ShowDialog();
        }

        private void btnSelectUnits_Click(object sender, EventArgs e)
        {
            frmSelectUnits selectUnits;
            selectUnits = new frmSelectUnits();
            selectUnits.reBuyStock = this; //���´����Ĵ����������Ϊͬһ���������ʵ��������
            selectUnits.M_str_object = "RebuyStock"; //����ʶ������һ��������õ�selectUnits���ڵ�
            selectUnits.ShowDialog();
        }

        private void dgvStockList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmSelectStock selectStock = new frmSelectStock();
            selectStock.reBuyStock = this; //���´����Ĵ����������Ϊͬһ���������ʵ��������
            selectStock.M_int_CurrentRow = e.RowIndex;
            selectStock.M_str_object = "RebuyStock"; //����ʶ������һ��������õ�selectStock���ڵ�
            selectStock.ShowDialog();
        }

        private void dgvStockList_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            //ͳ����Ʒ���������ͽ��
            try
            {
                float tqty = 0;
                float tsum = 0;
                for (int i = 0; i <= dgvStockList.RowCount; i++)
                {
                    tsum = tsum + Convert.ToSingle(dgvStockList[5, i].Value.ToString());
                    tqty = tqty + Convert.ToSingle(dgvStockList[3, i].Value.ToString());
                    txtFullPayment.Text = tsum.ToString();
                    txtStockQty.Text = tqty.ToString();
                }
            }
            catch
            {
            }
        }

        private void dgvStockList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3) //���㣭��ͳ����Ʒ���
            {
                try
                {
                    float tsum = Convert.ToSingle(dgvStockList[3, e.RowIndex].Value.ToString())*
                                 Convert.ToSingle(dgvStockList[4, e.RowIndex].Value.ToString());
                    dgvStockList[5, e.RowIndex].Value = tsum.ToString();
                }
                catch
                {
                }
            }
            if (e.ColumnIndex == 4)
            {
                try
                {
                    float tsum = Convert.ToSingle(dgvStockList[3, e.RowIndex].Value.ToString())*
                                 Convert.ToSingle(dgvStockList[4, e.RowIndex].Value.ToString());
                    dgvStockList[5, e.RowIndex].Value = tsum.ToString();
                }
                catch
                {
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //������λ�;����˲���Ϊ�գ�
            if (txtHandle.Text == string.Empty || txtUnits.Text == string.Empty)
            {
                MessageBox.Show("������λ�;�����Ϊ�����", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //�б������ݲ���Ϊ��
            if (Convert.ToString(dgvStockList[3, 0].Value) == string.Empty ||
                Convert.ToString(dgvStockList[4, 0].Value) == string.Empty ||
                Convert.ToString(dgvStockList[5, 0].Value) == string.Empty)
            {
                MessageBox.Show("���ʵ�б������ݣ����������������ۡ�����������Ϊ�գ�", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Ӧ������Ϊ��
            if (txtFullPayment.Text.Trim() == "0")
            {
                MessageBox.Show("Ӧ������Ϊ��������", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //�����������¼����Ʒ������Ϣ
            billinfo.BillCode = txtBillCode.Text;
            billinfo.Handle = txtHandle.Text;
            billinfo.Units = txtUnits.Text;
            billinfo.Summary = txtSummary.Text;
            billinfo.FullPayment = Convert.ToSingle(txtFullPayment.Text);
            billinfo.Payment = Convert.ToSingle(txtpayment.Text);
            //ִ�����
            baseinfo.AddTableMainSellhouse(billinfo, "tb_rewarehouse_main");

            //���������ϸ����¼����Ʒ������Ϣ
            for (int i = 0; i < dgvStockList.RowCount - 1; i++)
            {
                billinfo.BillCode = txtBillCode.Text;
                billinfo.TradeCode = dgvStockList[0, i].Value.ToString();
                billinfo.FullName = dgvStockList[1, i].Value.ToString();
                billinfo.TradeUnit = dgvStockList[2, i].Value.ToString();
                billinfo.Qty = Convert.ToSingle(dgvStockList[3, i].Value.ToString());
                billinfo.Price = Convert.ToSingle(dgvStockList[4, i].Value.ToString());
                billinfo.TSum = Convert.ToSingle(dgvStockList[5, i].Value.ToString());
                //ִ�ж���¼�����ݣ���ӵ���ϸ���У�
                baseinfo.AddTableDetailedWarehouse(billinfo, "tb_rewarehouse_detailed");
                //����--��Ʒ�������
                DataSet ds = null;
                stockinfo.TradeCode = dgvStockList[0, i].Value.ToString();
                ds = baseinfo.GetStockByTradeCode(stockinfo, "tb_Stock");
                stockinfo.Qty = Convert.ToSingle(ds.Tables[0].Rows[0]["qty"]);

                stockinfo.Qty = stockinfo.Qty - billinfo.Qty;
                int d = baseinfo.UpdateSaleStock_Qty(stockinfo);
            }
            //��������λ��ϸ��--¼������--��������Ϊ����
            currentAccount.BillCode = txtBillCode.Text;
            currentAccount.AddGathering = Convert.ToSingle(txtFullPayment.Text);
            currentAccount.FactAddFee = Convert.ToSingle(txtpayment.Text);
            currentAccount.Balance = Convert.ToSingle(txtBalance.Text);
            currentAccount.Units = txtUnits.Text;
            //ִ�����
            int ca = baseinfo.AddCurrentAccount(currentAccount);
            MessageBox.Show("�����˻����������˳ɹ���", "�ɹ���ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void btnEixt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtpayment_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtBalance.Text =
                    Convert.ToString(Convert.ToSingle(txtFullPayment.Text) - Convert.ToSingle(txtpayment.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("¼��Ƿ��ַ�������" + ex.Message, "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpayment.Focus();
            }
        }
    }
}
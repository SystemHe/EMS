using System;
using System.Data;
using System.Windows.Forms;
using EMS.BaseClass;
using EMS.SelectDataDialog;

namespace EMS.BuyStock
{
    public partial class frmBuyStock : Form
    {
        private readonly BaseClass.BaseInfo baseinfo = new BaseClass.BaseInfo(); //����BaseInfo��Ķ���
        private readonly cBillInfo billinfo = new cBillInfo(); //����cBillInfo��Ķ���
        private readonly cCurrentAccount currentAccount = new cCurrentAccount(); //����cCurrentAccount��Ķ���
        private readonly cStockInfo stockinfo = new cStockInfo(); //����cStockInfo��Ķ���

        public frmBuyStock()
        {
            InitializeComponent();
        }

        private void frmBuyStock_Load(object sender, EventArgs e)
        {
            txtBillDate.Text = DateTime.Now.ToString("yyyy-MM-dd"); //��ȡ¼������
            DataSet ds = null; //�������ݼ�����
            string P_Str_newBillCode = ""; //��¼�µĵ��ݱ��
            int P_Int_newBillCode = 0; //��¼���ݱ���е�������
            ds = baseinfo.GetAllBill("tb_warehouse_main"); //��ȡ���н�������Ϣ
            if (ds.Tables[0].Rows.Count == 0) //�ж����ݼ����Ƿ���ֵ
            {
                txtBillCode.Text = DateTime.Now.ToString("yyyyMMdd") + "JH" + "1000001"; //�����µĵ��ݱ��
            }
            else
            {
                P_Str_newBillCode = Convert.ToString(ds.Tables[0].Rows[ds.Tables[0].Rows.Count - 1]["billcode"]);
                //��ȡ�Ѿ����ڵ������
                P_Int_newBillCode = Convert.ToInt32(P_Str_newBillCode.Substring(10, 7)) + 1; //��ȡһ�����µ�������
                P_Str_newBillCode = DateTime.Now.ToString("yyyyMMdd") + "JH" + P_Int_newBillCode.ToString(); //��ȡ���µ��ݱ��
                txtBillCode.Text = P_Str_newBillCode; //�����ݱ����ʾ���ı�����
            }
            txtHandle.Focus(); //ʹ�������ı�������꽹��
        }

        private void btnSelectHandle_Click(object sender, EventArgs e)
        {
            frmSelectHandle selecthandle; //����frmSelectHandle�������
            selecthandle = new frmSelectHandle(); //��ʼ��frmSelectHandle�������
            selecthandle.buyStock = this; //���´����Ĵ����������Ϊͬһ��������Ķ���
            selecthandle.M_str_object = "BuyStock"; //����ʶ������һ��������õ�selecthandle����
            selecthandle.ShowDialog(); //��ʾfrmSelectHandle����
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //������λ�;����˲���Ϊ��
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
            //ִ����Ӳ���
            baseinfo.AddTableMainWarehouse(billinfo, "tb_warehouse_main");
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
                baseinfo.AddTableDetailedWarehouse(billinfo, "tb_warehouse_detailed");
                //���Ŀ�������ͼ�Ȩƽ���۸�
                DataSet ds = null; //�������ݼ�����
                stockinfo.TradeCode = dgvStockList[0, i].Value.ToString();
                ds = baseinfo.GetStockByTradeCode(stockinfo, "tb_stock");
                stockinfo.Qty = Convert.ToSingle(ds.Tables[0].Rows[0]["qty"]);
                stockinfo.Price = Convert.ToSingle(ds.Tables[0].Rows[0]["price"]);
                stockinfo.AveragePrice = Convert.ToSingle(ds.Tables[0].Rows[0]["averageprice"]);
                //����--��Ȩƽ���۸�
                if (stockinfo.Price == 0)
                {
                    stockinfo.AveragePrice = billinfo.Price; //��һ�ν���ʱ����Ȩƽ���۸���ڽ����۸�
                    stockinfo.Price = billinfo.Price; //��ȡ����
                }
                else
                {
                    //��Ȩƽ���۸�=����Ȩƽ����*���������+���ν����۸�*���ν���������/�����������+���ν���������
                    stockinfo.AveragePrice = ((stockinfo.AveragePrice*stockinfo.Qty + billinfo.Price*billinfo.Qty)/
                                              (stockinfo.Qty + billinfo.Qty));
                }
                //����--��Ʒ�������
                stockinfo.Qty = stockinfo.Qty + billinfo.Qty;
                int d = baseinfo.UpdateStock_QtyAndAveragerprice(stockinfo); //ִ�и��²���
            }
            //��������λ��ϸ��--¼������--����һ��Ϊ����
            currentAccount.BillCode = txtBillCode.Text;
            currentAccount.ReduceGathering = Convert.ToSingle(txtFullPayment.Text);
            currentAccount.FactReduceGathering = Convert.ToSingle(txtpayment.Text);
            currentAccount.Balance = Convert.ToSingle(txtBalance.Text);
            currentAccount.Units = txtUnits.Text;
            //ִ����Ӳ���
            int ca = baseinfo.AddCurrentAccount(currentAccount);
            MessageBox.Show("�������������˳ɹ���", "�ɹ���ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close(); //�رյ�ǰ����
        }

        private void btnSelectUnits_Click(object sender, EventArgs e)
        {
            frmSelectUnits selectUnits; //����frmSelectUnits�������
            selectUnits = new frmSelectUnits(); //��ʼ��frmSelectUnits�������
            selectUnits.buyStock = this; //���´����Ĵ����������Ϊͬһ��������Ķ���
            selectUnits.M_str_object = "BuyStock"; //����ʶ������һ��������õ�selectUnits����
            selectUnits.ShowDialog(); //��ʾfrmSelectUnits����
        }

        private void dgvStockList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmSelectStock selectStock = new frmSelectStock(); //����frmSelectStock�������
            selectStock.buyStock = this; //���´����Ĵ����������Ϊͬһ��������Ķ���
            selectStock.M_int_CurrentRow = e.RowIndex; //��¼ѡ�е�������
            selectStock.M_str_object = "BuyStock"; //����ʶ������һ��������õ�selectStock����
            selectStock.ShowDialog(); //��ʾfrmSelectStock����
        }

        private void btnEixt_Click(object sender, EventArgs e)
        {
            Close(); //�رյ�ǰ����
        }

        private void dgvStockList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3) //���㣭��ͳ����Ʒ���
            {
                try
                {
                    //������Ʒ�ܽ��
                    float tsum = Convert.ToSingle(dgvStockList[3, e.RowIndex].Value.ToString())*
                                 Convert.ToSingle(dgvStockList[4, e.RowIndex].Value.ToString());
                    dgvStockList[5, e.RowIndex].Value = tsum.ToString(); //��ʾ��Ʒ�ܽ��
                }
                catch
                {
                }
            }
            if (e.ColumnIndex == 4)
            {
                try
                {
                    //������Ʒ�ܽ��
                    float tsum = Convert.ToSingle(dgvStockList[3, e.RowIndex].Value.ToString())*
                                 Convert.ToSingle(dgvStockList[4, e.RowIndex].Value.ToString());
                    dgvStockList[5, e.RowIndex].Value = tsum.ToString(); //��ʾ��Ʒ�ܽ��
                }
                catch
                {
                }
            }
        }

        private void dgvStockList_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            try
            {
                float tqty = 0; //��¼��������
                float tsum = 0; //��¼Ӧ�����
                for (int i = 0; i <= dgvStockList.RowCount; i++) //����DataGridView�ؼ��е�������
                {
                    tsum = tsum + Convert.ToSingle(dgvStockList[5, i].Value.ToString()); //����Ӧ�����
                    tqty = tqty + Convert.ToSingle(dgvStockList[3, i].Value.ToString()); //�����������
                    txtFullPayment.Text = tsum.ToString(); //��ʾӦ�����
                    txtStockQty.Text = tqty.ToString(); //��ʾ��������
                }
            }
            catch
            {
            }
        }

        private void txtpayment_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtBalance.Text =
                    Convert.ToString(Convert.ToSingle(txtFullPayment.Text) - Convert.ToSingle(txtpayment.Text));
                //�Զ�������
            }
            catch (Exception ex)
            {
                MessageBox.Show("¼��Ƿ��ַ�������" + ex.Message, "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpayment.Focus(); //ʹʵ������ı�������꽹��
            }
        }
    }
}
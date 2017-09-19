using System;
using System.Data;
using System.Windows.Forms;
using EMS.BaseClass;
using EMS.SelectDataDialog;

namespace EMS.BuyStock
{
    public partial class frmBuyStock : Form
    {
        private readonly BaseClass.BaseInfo baseinfo = new BaseClass.BaseInfo(); //创建BaseInfo类的对象
        private readonly cBillInfo billinfo = new cBillInfo(); //创建cBillInfo类的对象
        private readonly cCurrentAccount currentAccount = new cCurrentAccount(); //创建cCurrentAccount类的对象
        private readonly cStockInfo stockinfo = new cStockInfo(); //创建cStockInfo类的对象

        public frmBuyStock()
        {
            InitializeComponent();
        }

        private void frmBuyStock_Load(object sender, EventArgs e)
        {
            txtBillDate.Text = DateTime.Now.ToString("yyyy-MM-dd"); //获取录单日期
            DataSet ds = null; //创建数据集对象
            string P_Str_newBillCode = ""; //记录新的单据编号
            int P_Int_newBillCode = 0; //记录单据编号中的数字码
            ds = baseinfo.GetAllBill("tb_warehouse_main"); //获取所有进货单信息
            if (ds.Tables[0].Rows.Count == 0) //判断数据集中是否有值
            {
                txtBillCode.Text = DateTime.Now.ToString("yyyyMMdd") + "JH" + "1000001"; //生成新的单据编号
            }
            else
            {
                P_Str_newBillCode = Convert.ToString(ds.Tables[0].Rows[ds.Tables[0].Rows.Count - 1]["billcode"]);
                //获取已经存在的最大编号
                P_Int_newBillCode = Convert.ToInt32(P_Str_newBillCode.Substring(10, 7)) + 1; //获取一个最新的数字码
                P_Str_newBillCode = DateTime.Now.ToString("yyyyMMdd") + "JH" + P_Int_newBillCode.ToString(); //获取最新单据编号
                txtBillCode.Text = P_Str_newBillCode; //将单据编号显示在文本框中
            }
            txtHandle.Focus(); //使经手人文本框获得鼠标焦点
        }

        private void btnSelectHandle_Click(object sender, EventArgs e)
        {
            frmSelectHandle selecthandle; //声明frmSelectHandle窗体对象
            selecthandle = new frmSelectHandle(); //初始化frmSelectHandle窗体对象
            selecthandle.buyStock = this; //将新创建的窗体对象设置为同一个窗体类的对象
            selecthandle.M_str_object = "BuyStock"; //用于识别是那一个窗体调用的selecthandle窗口
            selecthandle.ShowDialog(); //显示frmSelectHandle窗体
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //往来单位和经手人不能为空
            if (txtHandle.Text == string.Empty || txtUnits.Text == string.Empty)
            {
                MessageBox.Show("供货单位和经手人为必填项！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //列表中数据不能为空
            if (Convert.ToString(dgvStockList[3, 0].Value) == string.Empty ||
                Convert.ToString(dgvStockList[4, 0].Value) == string.Empty ||
                Convert.ToString(dgvStockList[5, 0].Value) == string.Empty)
            {
                MessageBox.Show("请核实列表中数据：‘数量’、‘单价’、‘金额’不能为空！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //应付金额不能为空
            if (txtFullPayment.Text.Trim() == "0")
            {
                MessageBox.Show("应付金额不能为‘０’！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //向进货表（主表）录入商品单据信息
            billinfo.BillCode = txtBillCode.Text;
            billinfo.Handle = txtHandle.Text;
            billinfo.Units = txtUnits.Text;
            billinfo.Summary = txtSummary.Text;
            billinfo.FullPayment = Convert.ToSingle(txtFullPayment.Text);
            billinfo.Payment = Convert.ToSingle(txtpayment.Text);
            //执行添加操作
            baseinfo.AddTableMainWarehouse(billinfo, "tb_warehouse_main");
            //向进货（明细表）中录入商品单据信息
            for (int i = 0; i < dgvStockList.RowCount - 1; i++)
            {
                billinfo.BillCode = txtBillCode.Text;
                billinfo.TradeCode = dgvStockList[0, i].Value.ToString();
                billinfo.FullName = dgvStockList[1, i].Value.ToString();
                billinfo.TradeUnit = dgvStockList[2, i].Value.ToString();
                billinfo.Qty = Convert.ToSingle(dgvStockList[3, i].Value.ToString());
                billinfo.Price = Convert.ToSingle(dgvStockList[4, i].Value.ToString());
                billinfo.TSum = Convert.ToSingle(dgvStockList[5, i].Value.ToString());
                //执行多行录入数据（添加到明细表中）
                baseinfo.AddTableDetailedWarehouse(billinfo, "tb_warehouse_detailed");
                //更改库存数量和加权平均价格
                DataSet ds = null; //创建数据集对象
                stockinfo.TradeCode = dgvStockList[0, i].Value.ToString();
                ds = baseinfo.GetStockByTradeCode(stockinfo, "tb_stock");
                stockinfo.Qty = Convert.ToSingle(ds.Tables[0].Rows[0]["qty"]);
                stockinfo.Price = Convert.ToSingle(ds.Tables[0].Rows[0]["price"]);
                stockinfo.AveragePrice = Convert.ToSingle(ds.Tables[0].Rows[0]["averageprice"]);
                //处理--加权平均价格
                if (stockinfo.Price == 0)
                {
                    stockinfo.AveragePrice = billinfo.Price; //第一次进货时，加权平均价格等于进货价格
                    stockinfo.Price = billinfo.Price; //获取单价
                }
                else
                {
                    //加权平均价格=（加权平均价*库存总数量+本次进货价格*本次进货数量）/（库存总数量+本次进货数量）
                    stockinfo.AveragePrice = ((stockinfo.AveragePrice*stockinfo.Qty + billinfo.Price*billinfo.Qty)/
                                              (stockinfo.Qty + billinfo.Qty));
                }
                //更新--商品库存数量
                stockinfo.Qty = stockinfo.Qty + billinfo.Qty;
                int d = baseinfo.UpdateStock_QtyAndAveragerprice(stockinfo); //执行更新操作
            }
            //向往来单位明细表--录入数据--这样一来为分析
            currentAccount.BillCode = txtBillCode.Text;
            currentAccount.ReduceGathering = Convert.ToSingle(txtFullPayment.Text);
            currentAccount.FactReduceGathering = Convert.ToSingle(txtpayment.Text);
            currentAccount.Balance = Convert.ToSingle(txtBalance.Text);
            currentAccount.Units = txtUnits.Text;
            //执行添加操作
            int ca = baseinfo.AddCurrentAccount(currentAccount);
            MessageBox.Show("进货单－－过账成功！", "成功提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close(); //关闭当前窗体
        }

        private void btnSelectUnits_Click(object sender, EventArgs e)
        {
            frmSelectUnits selectUnits; //声明frmSelectUnits窗体对象
            selectUnits = new frmSelectUnits(); //初始化frmSelectUnits窗体对象
            selectUnits.buyStock = this; //将新创建的窗体对象设置为同一个窗体类的对象
            selectUnits.M_str_object = "BuyStock"; //用于识别是那一个窗体调用的selectUnits窗口
            selectUnits.ShowDialog(); //显示frmSelectUnits窗体
        }

        private void dgvStockList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmSelectStock selectStock = new frmSelectStock(); //创建frmSelectStock窗体对象
            selectStock.buyStock = this; //将新创建的窗体对象设置为同一个窗体类的对象
            selectStock.M_int_CurrentRow = e.RowIndex; //记录选中的行索引
            selectStock.M_str_object = "BuyStock"; //用于识别是那一个窗体调用的selectStock窗口
            selectStock.ShowDialog(); //显示frmSelectStock窗体
        }

        private void btnEixt_Click(object sender, EventArgs e)
        {
            Close(); //关闭当前窗体
        }

        private void dgvStockList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3) //计算－－统计商品金额
            {
                try
                {
                    //计算商品总金额
                    float tsum = Convert.ToSingle(dgvStockList[3, e.RowIndex].Value.ToString())*
                                 Convert.ToSingle(dgvStockList[4, e.RowIndex].Value.ToString());
                    dgvStockList[5, e.RowIndex].Value = tsum.ToString(); //显示商品总金额
                }
                catch
                {
                }
            }
            if (e.ColumnIndex == 4)
            {
                try
                {
                    //计算商品总金额
                    float tsum = Convert.ToSingle(dgvStockList[3, e.RowIndex].Value.ToString())*
                                 Convert.ToSingle(dgvStockList[4, e.RowIndex].Value.ToString());
                    dgvStockList[5, e.RowIndex].Value = tsum.ToString(); //显示商品总金额
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
                float tqty = 0; //记录进货数量
                float tsum = 0; //记录应付金额
                for (int i = 0; i <= dgvStockList.RowCount; i++) //遍历DataGridView控件中的所有行
                {
                    tsum = tsum + Convert.ToSingle(dgvStockList[5, i].Value.ToString()); //计算应付金额
                    tqty = tqty + Convert.ToSingle(dgvStockList[3, i].Value.ToString()); //计算进货数量
                    txtFullPayment.Text = tsum.ToString(); //显示应付金额
                    txtStockQty.Text = tqty.ToString(); //显示进货数量
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
                //自动计算差额
            }
            catch (Exception ex)
            {
                MessageBox.Show("录入非法字符！！！" + ex.Message, "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpayment.Focus(); //使实付金额文本框获得鼠标焦点
            }
        }
    }
}
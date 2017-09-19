using System;
using System.Data;
using System.Windows.Forms;
using EMS.BaseClass;

namespace EMS.BuyStock
{
    public partial class frmBuyStockSum : Form
    {
        private readonly BaseClass.BaseInfo baseinfo = new BaseClass.BaseInfo();
        private readonly cBillInfo billinfo = new cBillInfo();

        public frmBuyStockSum()
        {
            InitializeComponent();
        }

        private void tlbtnSumDetailed_Click(object sender, EventArgs e)
        {
            DataSet ds = null;
            billinfo.Handle = tltxtHandle.Text;
            billinfo.Units = tltxtUnits.Text;
            ds = baseinfo.BuyStockSumDetailed(billinfo, "tb_StockSumDetailed", dtpStar.Value, dtpEnd.Value);
            dgvStockList.DataSource = ds.Tables[0].DefaultView;
        }

        private void tlbtnSum_Click(object sender, EventArgs e)
        {
            DataSet ds = null;
            ds = baseinfo.BuyStockSum("tb_StockSum");
            dgvStockList.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
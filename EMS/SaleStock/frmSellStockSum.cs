using System;
using System.Data;
using System.Windows.Forms;
using EMS.BaseClass;

namespace EMS.SaleStock
{
    public partial class frmSellStockSum : Form
    {
        private readonly BaseClass.BaseInfo baseinfo = new BaseClass.BaseInfo();
        private readonly cBillInfo billinfo = new cBillInfo();

        public frmSellStockSum()
        {
            InitializeComponent();
        }

        private void tlbtnSumDetailed_Click(object sender, EventArgs e)
        {
            DataSet ds = null;
            billinfo.Handle = tltxtHandle.Text;
            billinfo.Units = tltxtUnits.Text;
            ds = baseinfo.SellStockSumDetailed(billinfo, "tb_SellStockSumDetailed", dtpStar.Value, dtpEnd.Value);
            dgvStockList.DataSource = ds.Tables[0].DefaultView;
        }

        private void tlbtnSum_Click(object sender, EventArgs e)
        {
            DataSet ds = null;
            ds = baseinfo.SellStockSum("tb_SellStock");
            dgvStockList.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
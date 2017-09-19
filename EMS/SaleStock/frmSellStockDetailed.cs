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
                dgvResellStockList.Columns[0].HeaderText = "销售退货日期";
                dgvResellStockList.Columns[1].HeaderText = "单据编号";
                dgvResellStockList.Columns[2].HeaderText = "商品编号";
                dgvResellStockList.Columns[3].HeaderText = "商品名称";
                dgvResellStockList.Columns[4].HeaderText = "销售退货价格";
                dgvResellStockList.Columns[5].HeaderText = "销售退货数量";
                dgvResellStockList.Columns[5].HeaderText = "销售退货数量";
            }
        }
    }
}
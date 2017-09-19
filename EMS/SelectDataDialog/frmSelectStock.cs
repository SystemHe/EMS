using System;
using System.Data;
using System.Windows.Forms;
using EMS.BuyStock;
using EMS.SaleStock;

namespace EMS.SelectDataDialog
{
    public partial class frmSelectStock : Form
    {
        public int M_int_CurrentRow;
        public string M_str_object = "";
        public frmBuyStock buyStock;
        public frmRebuyStock reBuyStock;
        public frmResellStock resellStock;
        public frmSellStock sellStock;

        public frmSelectStock()
        {
            InitializeComponent();
        }

        private void SelectStock_Load(object sender, EventArgs e)
        {
            BaseClass.BaseInfo baseinfo = new BaseClass.BaseInfo();
            DataSet ds = baseinfo.GetAllStock("tb_Stock");
            dgvSelectStockList.DataSource = ds.Tables[0].DefaultView;

            dgvSelectStockList.Columns[0].HeaderText = "商品编号";
            dgvSelectStockList.Columns[0].Width = 80;
            dgvSelectStockList.Columns[1].HeaderText = "商品名称";
            dgvSelectStockList.Columns[2].HeaderText = "商品型号";
            dgvSelectStockList.Columns[2].Width = 80;
            dgvSelectStockList.Columns[3].HeaderText = "商品规格";
            dgvSelectStockList.Columns[3].Width = 80;
            dgvSelectStockList.Columns[4].Visible = false;
            dgvSelectStockList.Columns[5].Visible = false;
            dgvSelectStockList.Columns[6].HeaderText = "库存数量";
            dgvSelectStockList.Columns[6].Width = 80;
            dgvSelectStockList.Columns[7].Visible = false;
            dgvSelectStockList.Columns[8].Visible = false;
            dgvSelectStockList.Columns[9].Visible = false;
            dgvSelectStockList.Columns[10].HeaderText = "盘点数量";
            dgvSelectStockList.Columns[10].Width = 80;
            dgvSelectStockList.Columns[11].Visible = false;
            dgvSelectStockList.Columns[12].Visible = false;
        }

        private void dgvSelectStockList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (M_str_object == "BuyStock")
            {
                buyStock.dgvStockList[0, M_int_CurrentRow].Value = dgvSelectStockList[0, e.RowIndex].Value.ToString();
                buyStock.dgvStockList[1, M_int_CurrentRow].Value = dgvSelectStockList[1, e.RowIndex].Value.ToString();
                buyStock.dgvStockList[2, M_int_CurrentRow].Value = dgvSelectStockList[4, e.RowIndex].Value.ToString();
                buyStock.dgvStockList[4, M_int_CurrentRow].Value = dgvSelectStockList[7, e.RowIndex].Value.ToString();
                Close();
            }
            if (M_str_object == "ResellStock")
            {
                resellStock.dgvStockList[0, M_int_CurrentRow].Value = dgvSelectStockList[0, e.RowIndex].Value.ToString();
                resellStock.dgvStockList[1, M_int_CurrentRow].Value = dgvSelectStockList[1, e.RowIndex].Value.ToString();
                resellStock.dgvStockList[2, M_int_CurrentRow].Value = dgvSelectStockList[4, e.RowIndex].Value.ToString();
                resellStock.dgvStockList[4, M_int_CurrentRow].Value = dgvSelectStockList[7, e.RowIndex].Value.ToString();
                Close();
            }
            if (M_str_object == "RebuyStock")
            {
                reBuyStock.dgvStockList[0, M_int_CurrentRow].Value = dgvSelectStockList[0, e.RowIndex].Value.ToString();
                reBuyStock.dgvStockList[1, M_int_CurrentRow].Value = dgvSelectStockList[1, e.RowIndex].Value.ToString();
                reBuyStock.dgvStockList[2, M_int_CurrentRow].Value = dgvSelectStockList[4, e.RowIndex].Value.ToString();
                reBuyStock.dgvStockList[4, M_int_CurrentRow].Value = dgvSelectStockList[7, e.RowIndex].Value.ToString();
                Close();
            }
            if (M_str_object == "SellStock")
            {
                sellStock.dgvStockList[0, M_int_CurrentRow].Value = dgvSelectStockList[0, e.RowIndex].Value.ToString();
                sellStock.dgvStockList[1, M_int_CurrentRow].Value = dgvSelectStockList[1, e.RowIndex].Value.ToString();
                sellStock.dgvStockList[2, M_int_CurrentRow].Value = dgvSelectStockList[4, e.RowIndex].Value.ToString();
                sellStock.dgvStockList[4, M_int_CurrentRow].Value = dgvSelectStockList[7, e.RowIndex].Value.ToString();
                Close();
            }
        }
    }
}
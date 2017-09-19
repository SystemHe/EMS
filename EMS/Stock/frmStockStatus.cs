using System;
using System.Data;
using System.Windows.Forms;
using EMS.SelectDataDialog;

namespace EMS.Stock
{
    public partial class frmStockStatus : Form
    {
        private readonly BaseClass.BaseInfo baseinfo = new BaseClass.BaseInfo();
        private string G_Str_TradeCode = "";
        private string G_Str_fullname = "";

        public frmStockStatus()
        {
            InitializeComponent();
        }

        private void StockStatus_Load(object sender, EventArgs e)
        {
            DataSet ds = null;
            ds = baseinfo.setStockStatus("tb_stock");
            dgvStockList.RowCount = ds.Tables[0].Rows.Count + 1;
            dgvStockList.ColumnCount = 5;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dgvStockList[0, i].Value = ds.Tables[0].Rows[i]["tradecode"].ToString();
                dgvStockList[1, i].Value = ds.Tables[0].Rows[i]["fullname"].ToString();
                dgvStockList[2, i].Value = ds.Tables[0].Rows[i]["qty"].ToString();
                if (ds.Tables[0].Rows[i]["averageprice"].ToString() == "0")
                {
                    dgvStockList[3, i].Value = ds.Tables[0].Rows[i]["price"].ToString();
                }
                else
                {
                    dgvStockList[3, i].Value = ds.Tables[0].Rows[i]["averageprice"].ToString();
                }
                dgvStockList[4, i].Value = Convert.ToSingle(ds.Tables[0].Rows[i]["qty"].ToString())*
                                           Convert.ToSingle(dgvStockList[3, i].Value);
            }
            SetdgvStockListHeadText();
        }

        private void SetdgvStockListHeadText()
        {
            dgvStockList.Columns[0].HeaderText = "商品编号";
            dgvStockList.Columns[1].HeaderText = "商品名称";
            dgvStockList.Columns[2].HeaderText = "库存数量";
            dgvStockList.Columns[3].HeaderText = "成本均价";
            dgvStockList.Columns[4].HeaderText = "库存总价";
        }

        private void tlbtnSetStockLimit_Click(object sender, EventArgs e)
        {
            frmSetStockLimit setStockLimit = new frmSetStockLimit();
            DataSet ds = null;
            ds = baseinfo.GetStockLimitByTradeCode(G_Str_TradeCode, "tb_stock");
            setStockLimit.txtUpperLimit.Text = ds.Tables[0].Rows[0]["upperlimit"].ToString();
            setStockLimit.txtLowerLimit.Text = ds.Tables[0].Rows[0]["lowerlimit"].ToString();
            setStockLimit.groupBox1.Text = "(" + G_Str_TradeCode + ")" + G_Str_fullname;

            setStockLimit.ShowDialog();
        }

        private void dgvStockList_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                G_Str_TradeCode = dgvStockList[0, e.RowIndex].Value.ToString();
                G_Str_fullname = dgvStockList[1, e.RowIndex].Value.ToString();
            }
            catch
            {
            }
        }

        private void tlbtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
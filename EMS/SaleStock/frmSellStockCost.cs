using System;
using System.Data;
using System.Windows.Forms;

namespace EMS.SaleStock
{
    public partial class frmSellStockCost : Form
    {
        private readonly BaseClass.BaseInfo baseinfo = new BaseClass.BaseInfo();

        public frmSellStockCost()
        {
            InitializeComponent();
        }

        private void frmSellStockCost_Load(object sender, EventArgs e)
        {
            DataSet ds = null;
            DataSet ds_Stock = null;
            DataSet ds_Detailed = null;

            ds = baseinfo.GetAllBill("tb_sell_main");
            //设置初始化表格
            dgvStockList.RowCount = ds.Tables[0].Rows.Count + 1;
            dgvStockList.ColumnCount = ds.Tables[0].Columns.Count - 1;


            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dgvStockList[0, i].Value = ds.Tables[0].Rows[i]["billdate"].ToString().Substring(0, 10);
                dgvStockList[5, i].Value = ds.Tables[0].Rows[i]["units"].ToString();
                //设置清单摘要
                ds_Detailed = baseinfo.GetDetailedkByBillCode(ds.Tables[0].Rows[i]["billcode"].ToString(),
                                                              "tb_sell_detailed");
                dgvStockList[1, i].Value = "销售【" + ds_Detailed.Tables[0].Rows[0]["fullname"] + "】商品给『" +
                                           ds.Tables[0].Rows[i]["units"] + "』：" + ds.Tables[0].Rows[i]["handle"];
                dgvStockList[2, i].Value = ds_Detailed.Tables[0].Rows[0]["tsum"].ToString();
                //设置销售成本-----销售成本=加权平均价*总销售数量
                ds_Stock = baseinfo.GetStockByTradeCode(ds_Detailed.Tables[0].Rows[0]["tradecode"].ToString(),
                                                        "tb_Stock");
                float P_flt_averageprice = 0;
                float P_flt_price = 0;
                float P_flt_SaleCost = 0;
                P_flt_averageprice = Convert.ToSingle(ds_Stock.Tables[0].Rows[0]["averageprice"]);
                P_flt_price = Convert.ToSingle(ds_Stock.Tables[0].Rows[0]["price"]);
                if (P_flt_averageprice == 0)
                {
                    P_flt_SaleCost = P_flt_price*Convert.ToSingle(ds_Detailed.Tables[0].Rows[0]["qty"]);
                }
                else
                {
                    P_flt_SaleCost = P_flt_averageprice*Convert.ToSingle(ds_Detailed.Tables[0].Rows[0]["qty"]);
                }
                dgvStockList[3, i].Value = P_flt_SaleCost.ToString();
                //设置销售毛利　　　销售毛利=销售金额-销售成本
                dgvStockList[4, i].Value =
                    (Convert.ToSingle(ds_Detailed.Tables[0].Rows[0]["tsum"]) - P_flt_SaleCost).ToString();
            }
            Set_dgvSellStockList();
        }

        private void Set_dgvSellStockList()
        {
            dgvStockList.Columns[0].HeaderText = "日期";
            dgvStockList.Columns[0].Width = 80;
            dgvStockList.Columns[1].HeaderText = "摘要";
            dgvStockList.Columns[1].Width = 340;
            dgvStockList.Columns[2].HeaderText = "金额￥.00";
            dgvStockList.Columns[2].Width = 65;
            dgvStockList.Columns[3].HeaderText = "成本￥.00";
            dgvStockList.Columns[3].Width = 65;
            dgvStockList.Columns[4].HeaderText = "毛利￥.00";
            dgvStockList.Columns[4].Width = 65;
            dgvStockList.Columns[5].HeaderText = "往来单位";
            dgvStockList.Columns[5].Width = 120;
        }

        private void tlbtnFind_Click(object sender, EventArgs e)
        {
            DataSet ds = null;
            DataSet ds_Stock = null;
            DataSet ds_Detailed = null;

            ds = baseinfo.FindSellStock(dtpStar.Value, dtpEnd.Value);
            //设置初始化表格
            dgvStockList.RowCount = ds.Tables[0].Rows.Count + 1;
            dgvStockList.ColumnCount = ds.Tables[0].Columns.Count - 1;


            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dgvStockList[0, i].Value = ds.Tables[0].Rows[i]["billdate"].ToString().Substring(0, 10);
                dgvStockList[5, i].Value = ds.Tables[0].Rows[i]["units"].ToString();
                //设置清单摘要
                ds_Detailed = baseinfo.GetDetailedkByBillCode(ds.Tables[0].Rows[i]["billcode"].ToString(),
                                                              "tb_sell_detailed");
                dgvStockList[1, i].Value = "销售【" + ds_Detailed.Tables[0].Rows[0]["fullname"] + "】商品给『" +
                                           ds.Tables[0].Rows[i]["units"] + "』：" + ds.Tables[0].Rows[i]["handle"];
                dgvStockList[2, i].Value = ds_Detailed.Tables[0].Rows[0]["tsum"].ToString();
                //设置销售成本-----销售成本=加权平均价*总销售数量
                ds_Stock = baseinfo.GetStockByTradeCode(ds_Detailed.Tables[0].Rows[0]["tradecode"].ToString(),
                                                        "tb_Stock");
                float P_flt_averageprice = 0;
                float P_flt_price = 0;
                float P_flt_SaleCost = 0;
                P_flt_averageprice = Convert.ToSingle(ds_Stock.Tables[0].Rows[0]["averageprice"]);
                P_flt_price = Convert.ToSingle(ds_Stock.Tables[0].Rows[0]["price"]);
                if (P_flt_averageprice == 0)
                {
                    P_flt_SaleCost = P_flt_price*Convert.ToSingle(ds_Detailed.Tables[0].Rows[0]["qty"]);
                }
                else
                {
                    P_flt_SaleCost = P_flt_averageprice*Convert.ToSingle(ds_Detailed.Tables[0].Rows[0]["qty"]);
                }
                dgvStockList[3, i].Value = P_flt_SaleCost.ToString();
                //设置销售毛利　　　销售毛利=销售金额-销售成本
                dgvStockList[4, i].Value =
                    (Convert.ToSingle(ds_Detailed.Tables[0].Rows[0]["tsum"]) - P_flt_SaleCost).ToString();
            }
            Set_dgvSellStockList();
        }

        private void tlbtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
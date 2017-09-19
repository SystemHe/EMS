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
            //���ó�ʼ�����
            dgvStockList.RowCount = ds.Tables[0].Rows.Count + 1;
            dgvStockList.ColumnCount = ds.Tables[0].Columns.Count - 1;


            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dgvStockList[0, i].Value = ds.Tables[0].Rows[i]["billdate"].ToString().Substring(0, 10);
                dgvStockList[5, i].Value = ds.Tables[0].Rows[i]["units"].ToString();
                //�����嵥ժҪ
                ds_Detailed = baseinfo.GetDetailedkByBillCode(ds.Tables[0].Rows[i]["billcode"].ToString(),
                                                              "tb_sell_detailed");
                dgvStockList[1, i].Value = "���ۡ�" + ds_Detailed.Tables[0].Rows[0]["fullname"] + "����Ʒ����" +
                                           ds.Tables[0].Rows[i]["units"] + "����" + ds.Tables[0].Rows[i]["handle"];
                dgvStockList[2, i].Value = ds_Detailed.Tables[0].Rows[0]["tsum"].ToString();
                //�������۳ɱ�-----���۳ɱ�=��Ȩƽ����*����������
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
                //��������ë������������ë��=���۽��-���۳ɱ�
                dgvStockList[4, i].Value =
                    (Convert.ToSingle(ds_Detailed.Tables[0].Rows[0]["tsum"]) - P_flt_SaleCost).ToString();
            }
            Set_dgvSellStockList();
        }

        private void Set_dgvSellStockList()
        {
            dgvStockList.Columns[0].HeaderText = "����";
            dgvStockList.Columns[0].Width = 80;
            dgvStockList.Columns[1].HeaderText = "ժҪ";
            dgvStockList.Columns[1].Width = 340;
            dgvStockList.Columns[2].HeaderText = "��.00";
            dgvStockList.Columns[2].Width = 65;
            dgvStockList.Columns[3].HeaderText = "�ɱ���.00";
            dgvStockList.Columns[3].Width = 65;
            dgvStockList.Columns[4].HeaderText = "ë����.00";
            dgvStockList.Columns[4].Width = 65;
            dgvStockList.Columns[5].HeaderText = "������λ";
            dgvStockList.Columns[5].Width = 120;
        }

        private void tlbtnFind_Click(object sender, EventArgs e)
        {
            DataSet ds = null;
            DataSet ds_Stock = null;
            DataSet ds_Detailed = null;

            ds = baseinfo.FindSellStock(dtpStar.Value, dtpEnd.Value);
            //���ó�ʼ�����
            dgvStockList.RowCount = ds.Tables[0].Rows.Count + 1;
            dgvStockList.ColumnCount = ds.Tables[0].Columns.Count - 1;


            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dgvStockList[0, i].Value = ds.Tables[0].Rows[i]["billdate"].ToString().Substring(0, 10);
                dgvStockList[5, i].Value = ds.Tables[0].Rows[i]["units"].ToString();
                //�����嵥ժҪ
                ds_Detailed = baseinfo.GetDetailedkByBillCode(ds.Tables[0].Rows[i]["billcode"].ToString(),
                                                              "tb_sell_detailed");
                dgvStockList[1, i].Value = "���ۡ�" + ds_Detailed.Tables[0].Rows[0]["fullname"] + "����Ʒ����" +
                                           ds.Tables[0].Rows[i]["units"] + "����" + ds.Tables[0].Rows[i]["handle"];
                dgvStockList[2, i].Value = ds_Detailed.Tables[0].Rows[0]["tsum"].ToString();
                //�������۳ɱ�-----���۳ɱ�=��Ȩƽ����*����������
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
                //��������ë������������ë��=���۽��-���۳ɱ�
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
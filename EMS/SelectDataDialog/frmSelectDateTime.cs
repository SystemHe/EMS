using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using EMS.BuyStock;
using EMS.SaleStock;

namespace EMS.SelectDataDialog
{
    public partial class frmSelectDateTime : Form
    {
        private readonly string[] G_AStr_Temp = new string[5];
        private readonly BaseClass.BaseInfo baseinfo = new BaseClass.BaseInfo();
        private readonly frmCurrentAccountBook currentAccountBook = new frmCurrentAccountBook();
        public int G_Int_CurrrentRows = 0;
        private int G_Int_JH;
        public int G_Int_rows = 0;
        public string G_Str_fullName = "";
        public string G_Str_tradeCode = "";

        public string M_Str_object = "";
        public string M_Str_units = "";

        public frmSelectDateTime()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (M_Str_object == "Detailed")
            {
                frmSellStockDetailed sellDetailed = new frmSellStockDetailed();
                DataSet ds = null;
                ds = baseinfo.SellStockDetailed(G_Str_tradeCode, dtpStar.Value, dtpEnd.Value, "tb_sell_detailed");
                sellDetailed.dgvSaleStockList.DataSource = ds.Tables[0].DefaultView;
                ds = baseinfo.SellStockDetailed(G_Str_tradeCode, dtpStar.Value, dtpEnd.Value, "tb_resell_detailed");
                sellDetailed.dgvResellStockList.DataSource = ds.Tables[0].DefaultView;
                sellDetailed.Text = "明细账本－－商品：" + G_Str_fullName + "　日期：【" + dtpStar.Value.ToString() + "】至【" +
                                    dtpEnd.Value.ToString() + "】";
                sellDetailed.ShowDialog();
            }
            else
            {
                DataSet ds = null;
                DataSet ds_main = null;
                DataSet ds_Detailed = null;
                string P_Str_Code = "";
                ds = baseinfo.FindCurrentAccountDate(M_Str_units, dtpStar.Value, dtpEnd.Value);
                //设置表格列
                currentAccountBook.dgvCurrentAccountList.ColumnCount = 7;
                currentAccountBook.dgvCurrentAccountList.Columns[0].HeaderText = "日期";
                currentAccountBook.dgvCurrentAccountList.Columns[0].Width = 75;
                currentAccountBook.dgvCurrentAccountList.Columns[1].HeaderText = "单据编号";
                currentAccountBook.dgvCurrentAccountList.Columns[1].Width = 125;
                currentAccountBook.dgvCurrentAccountList.Columns[2].HeaderText = "摘要";
                currentAccountBook.dgvCurrentAccountList.Columns[2].Width = 260;
                currentAccountBook.dgvCurrentAccountList.Columns[3].HeaderText = "应收增加";
                currentAccountBook.dgvCurrentAccountList.Columns[3].Width = 80;
                currentAccountBook.dgvCurrentAccountList.Columns[4].HeaderText = "实际增加";
                currentAccountBook.dgvCurrentAccountList.Columns[4].Width = 80;
                currentAccountBook.dgvCurrentAccountList.Columns[5].HeaderText = "应收减少";
                currentAccountBook.dgvCurrentAccountList.Columns[5].Width = 80;
                currentAccountBook.dgvCurrentAccountList.Columns[6].HeaderText = "实际减少";
                currentAccountBook.dgvCurrentAccountList.Columns[6].Width = 80;
                if (ds.Tables[0].Rows.Count > 0) //存在往来关系
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        //识别－－货物状态
                        P_Str_Code = ds.Tables[0].Rows[i]["billCode"].ToString().Substring(8, 4);
                        if (P_Str_Code.Substring(0, 2) == "JH" && P_Str_Code != "JHTH")
                        {
                            ds_Detailed = baseinfo.FindDetailde("tb_warehouse_detailed",
                                                                ds.Tables[0].Rows[i]["billcode"].ToString());
                            ds_main = baseinfo.FindMain("tb_warehouse_main", ds.Tables[0].Rows[i]["billcode"].ToString());
                            //动态设置表格行数(注意:每当增加一些新表格的时,原有表格中最后一行数据,DataGridView控件将其自动清空)
                            G_Int_rows = G_Int_rows + ds_Detailed.Tables[0].Rows.Count;
                            currentAccountBook.dgvCurrentAccountList.RowCount = G_Int_rows;
                            //动态创建新表格后,填充-自动清空的行数据
                            try
                            {
                                //当表格中没有数据时,作出异常处理.
                                currentAccountBook.dgvCurrentAccountList[0, G_Int_JH].Value = G_AStr_Temp[0];
                                currentAccountBook.dgvCurrentAccountList[1, G_Int_JH].Value = G_AStr_Temp[1];
                                currentAccountBook.dgvCurrentAccountList[2, G_Int_JH].Value = G_AStr_Temp[2];
                                currentAccountBook.dgvCurrentAccountList[5, G_Int_JH].Value = G_AStr_Temp[3];
                                currentAccountBook.dgvCurrentAccountList[6, G_Int_JH].Value = G_AStr_Temp[4];
                            }
                            catch
                            {
                            }
                            G_Int_CurrrentRows = currentAccountBook.dgvCurrentAccountList.RowCount -
                                                 ds_Detailed.Tables[0].Rows.Count;

                            for (int jh = G_Int_CurrrentRows;
                                 jh < ds_Detailed.Tables[0].Rows.Count + G_Int_CurrrentRows;
                                 jh++)
                            {
                                currentAccountBook.dgvCurrentAccountList[0, jh].Value =
                                    ds_Detailed.Tables[0].Rows[jh - G_Int_CurrrentRows]["billdate"].ToString().Substring
                                        (0, 10);
                                currentAccountBook.dgvCurrentAccountList[1, jh].Value =
                                    ds_Detailed.Tables[0].Rows[jh - G_Int_CurrrentRows]["billcode"].ToString();
                                currentAccountBook.dgvCurrentAccountList[2, jh].Value = "进货：" +
                                                                                        ds_Detailed.Tables[0].Rows[
                                                                                            jh - G_Int_CurrrentRows][
                                                                                                "fullname"] +
                                                                                        ds_Detailed.Tables[0].Rows[
                                                                                            jh - G_Int_CurrrentRows][
                                                                                                "qty"] + "*" +
                                                                                        ds_Detailed.Tables[0].Rows[
                                                                                            jh - G_Int_CurrrentRows][
                                                                                                "price"] + "：" +
                                                                                        ds_main.Tables[0].Rows[0][
                                                                                            "handle"];
                                currentAccountBook.dgvCurrentAccountList[5, jh].Value =
                                    ds_Detailed.Tables[0].Rows[jh - G_Int_CurrrentRows]["tsum"].ToString();
                                currentAccountBook.dgvCurrentAccountList[6, jh].Value =
                                    ds_main.Tables[0].Rows[0]["payment"].ToString();
                                //当动态创建表格时,将表格中最后一行数据存储到数组中.
                                G_AStr_Temp[0] = currentAccountBook.dgvCurrentAccountList[0, jh].Value.ToString();
                                G_AStr_Temp[1] = currentAccountBook.dgvCurrentAccountList[1, jh].Value.ToString();
                                G_AStr_Temp[2] = currentAccountBook.dgvCurrentAccountList[2, jh].Value.ToString();
                                G_AStr_Temp[3] = currentAccountBook.dgvCurrentAccountList[5, jh].Value.ToString();
                                G_AStr_Temp[4] = currentAccountBook.dgvCurrentAccountList[6, jh].Value.ToString();
                                //记录最后一行记录
                                G_Int_JH = jh;
                            }
                        }
                        else if (P_Str_Code == "JHTH")
                        {
                            ds_Detailed = baseinfo.FindDetailde("tb_rewarehouse_detailed",
                                                                ds.Tables[0].Rows[i]["billcode"].ToString());
                            ds_main = baseinfo.FindMain("tb_rewarehouse_main",
                                                        ds.Tables[0].Rows[i]["billcode"].ToString());
                            //动态设置表格行数(注意:每当增加一些新表格的时,原有表格中最后一行数据,DataGridView控件将其自动清空)
                            G_Int_rows = G_Int_rows + ds_Detailed.Tables[0].Rows.Count;
                            currentAccountBook.dgvCurrentAccountList.RowCount = G_Int_rows;
                            //动态创建新表格后,填充-自动清空的行数据
                            try
                            {
                                //当表格中没有数据时,作出异常处理.
                                currentAccountBook.dgvCurrentAccountList[0, G_Int_JH].Value = G_AStr_Temp[0];
                                currentAccountBook.dgvCurrentAccountList[1, G_Int_JH].Value = G_AStr_Temp[1];
                                currentAccountBook.dgvCurrentAccountList[2, G_Int_JH].Value = G_AStr_Temp[2];
                                currentAccountBook.dgvCurrentAccountList[5, G_Int_JH].Value = G_AStr_Temp[3];
                                currentAccountBook.dgvCurrentAccountList[6, G_Int_JH].Value = G_AStr_Temp[4];
                            }
                            catch
                            {
                            }
                            G_Int_CurrrentRows = currentAccountBook.dgvCurrentAccountList.RowCount -
                                                 ds_Detailed.Tables[0].Rows.Count;

                            for (int jh = G_Int_CurrrentRows;
                                 jh < ds_Detailed.Tables[0].Rows.Count + G_Int_CurrrentRows;
                                 jh++)
                            {
                                currentAccountBook.dgvCurrentAccountList[0, jh].Value =
                                    ds_Detailed.Tables[0].Rows[jh - G_Int_CurrrentRows]["billdate"].ToString().Substring
                                        (0, 10);
                                currentAccountBook.dgvCurrentAccountList[1, jh].Value =
                                    ds_Detailed.Tables[0].Rows[jh - G_Int_CurrrentRows]["billcode"].ToString();
                                currentAccountBook.dgvCurrentAccountList[2, jh].Value = "进货退货：" +
                                                                                        ds_Detailed.Tables[0].Rows[
                                                                                            jh - G_Int_CurrrentRows][
                                                                                                "fullname"] +
                                                                                        ds_Detailed.Tables[0].Rows[
                                                                                            jh - G_Int_CurrrentRows][
                                                                                                "qty"] + "*" +
                                                                                        ds_Detailed.Tables[0].Rows[
                                                                                            jh - G_Int_CurrrentRows][
                                                                                                "price"] + "：" +
                                                                                        ds_main.Tables[0].Rows[0][
                                                                                            "handle"];
                                currentAccountBook.dgvCurrentAccountList[3, jh].Value =
                                    ds_Detailed.Tables[0].Rows[jh - G_Int_CurrrentRows]["tsum"].ToString();
                                currentAccountBook.dgvCurrentAccountList[4, jh].Value =
                                    ds_main.Tables[0].Rows[0]["gathering"].ToString();
                                //当动态创建表格时,将表格中最后一行数据存储到数组中.
                                G_AStr_Temp[0] = currentAccountBook.dgvCurrentAccountList[0, jh].Value.ToString();
                                G_AStr_Temp[1] = currentAccountBook.dgvCurrentAccountList[1, jh].Value.ToString();
                                G_AStr_Temp[2] = currentAccountBook.dgvCurrentAccountList[2, jh].Value.ToString();
                                G_AStr_Temp[3] = currentAccountBook.dgvCurrentAccountList[3, jh].Value.ToString();
                                G_AStr_Temp[4] = currentAccountBook.dgvCurrentAccountList[4, jh].Value.ToString();
                                //记录最后一行记录
                                G_Int_JH = jh;
                            }
                        }
                        else if (P_Str_Code.Substring(0, 2) == "XS" && P_Str_Code != "XSTH")
                        {
                            ds_Detailed = baseinfo.FindDetailde("tb_sell_detailed",
                                                                ds.Tables[0].Rows[i]["billcode"].ToString());
                            ds_main = baseinfo.FindMain("tb_sell_main", ds.Tables[0].Rows[i]["billcode"].ToString());
                            //动态设置表格行数(注意:每当增加一些新表格的时,原有表格中最后一行数据,DataGridView控件将其自动清空)
                            G_Int_rows = G_Int_rows + ds_Detailed.Tables[0].Rows.Count;
                            currentAccountBook.dgvCurrentAccountList.RowCount = G_Int_rows;
                            //动态创建新表格后,填充-自动清空的行数据
                            try
                            {
                                //当表格中没有数据时,作出异常处理.
                                currentAccountBook.dgvCurrentAccountList[0, G_Int_JH].Value = G_AStr_Temp[0];
                                currentAccountBook.dgvCurrentAccountList[1, G_Int_JH].Value = G_AStr_Temp[1];
                                currentAccountBook.dgvCurrentAccountList[2, G_Int_JH].Value = G_AStr_Temp[2];
                                currentAccountBook.dgvCurrentAccountList[3, G_Int_JH].Value = G_AStr_Temp[3];
                                currentAccountBook.dgvCurrentAccountList[4, G_Int_JH].Value = G_AStr_Temp[4];
                            }
                            catch
                            {
                            }
                            G_Int_CurrrentRows = currentAccountBook.dgvCurrentAccountList.RowCount -
                                                 ds_Detailed.Tables[0].Rows.Count;

                            for (int jh = G_Int_CurrrentRows;
                                 jh < ds_Detailed.Tables[0].Rows.Count + G_Int_CurrrentRows;
                                 jh++)
                            {
                                currentAccountBook.dgvCurrentAccountList[0, jh].Value =
                                    ds_Detailed.Tables[0].Rows[jh - G_Int_CurrrentRows]["billdate"].ToString().Substring
                                        (0, 10);
                                currentAccountBook.dgvCurrentAccountList[1, jh].Value =
                                    ds_Detailed.Tables[0].Rows[jh - G_Int_CurrrentRows]["billcode"].ToString();
                                currentAccountBook.dgvCurrentAccountList[2, jh].Value = "销售：" +
                                                                                        ds_Detailed.Tables[0].Rows[
                                                                                            jh - G_Int_CurrrentRows][
                                                                                                "fullname"] +
                                                                                        ds_Detailed.Tables[0].Rows[
                                                                                            jh - G_Int_CurrrentRows][
                                                                                                "qty"] + "*" +
                                                                                        ds_Detailed.Tables[0].Rows[
                                                                                            jh - G_Int_CurrrentRows][
                                                                                                "price"] + "：" +
                                                                                        ds_main.Tables[0].Rows[0][
                                                                                            "handle"];
                                currentAccountBook.dgvCurrentAccountList[3, jh].Value =
                                    ds_Detailed.Tables[0].Rows[jh - G_Int_CurrrentRows]["tsum"].ToString();
                                currentAccountBook.dgvCurrentAccountList[4, jh].Value =
                                    ds_main.Tables[0].Rows[0]["gathering"].ToString();
                                //当动态创建表格时,将表格中最后一行数据存储到数组中.
                                G_AStr_Temp[0] = currentAccountBook.dgvCurrentAccountList[0, jh].Value.ToString();
                                G_AStr_Temp[1] = currentAccountBook.dgvCurrentAccountList[1, jh].Value.ToString();
                                G_AStr_Temp[2] = currentAccountBook.dgvCurrentAccountList[2, jh].Value.ToString();
                                G_AStr_Temp[3] = currentAccountBook.dgvCurrentAccountList[3, jh].Value.ToString();
                                G_AStr_Temp[4] = currentAccountBook.dgvCurrentAccountList[4, jh].Value.ToString();
                                //记录最后一行记录
                                G_Int_JH = jh;
                            }
                        }
                        else if (P_Str_Code == "XSTH")
                        {
                            ds_Detailed = baseinfo.FindDetailde("tb_resell_detailed",
                                                                ds.Tables[0].Rows[i]["billcode"].ToString());
                            ds_main = baseinfo.FindMain("tb_resell_main", ds.Tables[0].Rows[i]["billcode"].ToString());
                            //动态设置表格行数(注意:每当增加一些新表格的时,原有表格中最后一行数据,DataGridView控件将其自动清空)
                            G_Int_rows = G_Int_rows + ds_Detailed.Tables[0].Rows.Count;
                            currentAccountBook.dgvCurrentAccountList.RowCount = G_Int_rows;
                            //动态创建新表格后,填充-自动清空的行数据
                            try
                            {
                                //当表格中没有数据时,作出异常处理.
                                currentAccountBook.dgvCurrentAccountList[0, G_Int_JH].Value = G_AStr_Temp[0];
                                currentAccountBook.dgvCurrentAccountList[1, G_Int_JH].Value = G_AStr_Temp[1];
                                currentAccountBook.dgvCurrentAccountList[2, G_Int_JH].Value = G_AStr_Temp[2];
                                currentAccountBook.dgvCurrentAccountList[5, G_Int_JH].Value = G_AStr_Temp[3];
                                currentAccountBook.dgvCurrentAccountList[6, G_Int_JH].Value = G_AStr_Temp[4];
                            }
                            catch
                            {
                            }
                            G_Int_CurrrentRows = currentAccountBook.dgvCurrentAccountList.RowCount -
                                                 ds_Detailed.Tables[0].Rows.Count;

                            for (int jh = G_Int_CurrrentRows;
                                 jh < ds_Detailed.Tables[0].Rows.Count + G_Int_CurrrentRows;
                                 jh++)
                            {
                                currentAccountBook.dgvCurrentAccountList[0, jh].Value =
                                    ds_Detailed.Tables[0].Rows[jh - G_Int_CurrrentRows]["billdate"].ToString().Substring
                                        (0, 10);
                                currentAccountBook.dgvCurrentAccountList[1, jh].Value =
                                    ds_Detailed.Tables[0].Rows[jh - G_Int_CurrrentRows]["billcode"].ToString();
                                currentAccountBook.dgvCurrentAccountList[2, jh].Value = "销售退货：" +
                                                                                        ds_Detailed.Tables[0].Rows[
                                                                                            jh - G_Int_CurrrentRows][
                                                                                                "fullname"] +
                                                                                        ds_Detailed.Tables[0].Rows[
                                                                                            jh - G_Int_CurrrentRows][
                                                                                                "qty"] + "*" +
                                                                                        ds_Detailed.Tables[0].Rows[
                                                                                            jh - G_Int_CurrrentRows][
                                                                                                "price"] + "：" +
                                                                                        ds_main.Tables[0].Rows[0][
                                                                                            "handle"];
                                currentAccountBook.dgvCurrentAccountList[5, jh].Value =
                                    ds_Detailed.Tables[0].Rows[jh - G_Int_CurrrentRows]["tsum"].ToString();
                                currentAccountBook.dgvCurrentAccountList[6, jh].Value =
                                    ds_main.Tables[0].Rows[0]["payment"].ToString();
                                //当动态创建表格时,将表格中最后一行数据存储到数组中.
                                G_AStr_Temp[0] = currentAccountBook.dgvCurrentAccountList[0, jh].Value.ToString();
                                G_AStr_Temp[1] = currentAccountBook.dgvCurrentAccountList[1, jh].Value.ToString();
                                G_AStr_Temp[2] = currentAccountBook.dgvCurrentAccountList[2, jh].Value.ToString();
                                G_AStr_Temp[3] = currentAccountBook.dgvCurrentAccountList[5, jh].Value.ToString();
                                G_AStr_Temp[4] = currentAccountBook.dgvCurrentAccountList[6, jh].Value.ToString();
                                //记录最后一行记录
                                G_Int_JH = jh;
                            }
                        }
                    }
                    SetAndClearCell(); //填充完数据后---处理DataGridView控件中无效数据．
                    currentAccountBook.tltxtUnits.Text = ds.Tables[0].Rows[0]["units"].ToString();
                    //计算--应收和应付
                    float P_flt_payment = 0, P_flt_fullpayment = 0;
                    float P_flt_gathering = 0, P_flt_fullgathering = 0;
                    string P_Str_payment = "", P_Str_fullpayment = "";
                    string p_Str_gathering = "", p_Str_fullgathering = "";
                    for (int j = 0; j < currentAccountBook.dgvCurrentAccountList.Rows.Count; j++)
                    {
                        p_Str_gathering = Convert.ToString(currentAccountBook.dgvCurrentAccountList[3, j].Value);
                        p_Str_fullgathering = Convert.ToString(currentAccountBook.dgvCurrentAccountList[4, j].Value);
                        P_Str_payment = Convert.ToString(currentAccountBook.dgvCurrentAccountList[5, j].Value);
                        P_Str_fullpayment = Convert.ToString(currentAccountBook.dgvCurrentAccountList[6, j].Value);

                        if (p_Str_gathering == "")
                            p_Str_gathering = "0";
                        if (p_Str_fullgathering == "")
                            p_Str_fullgathering = "0";
                        if (P_Str_payment == "")
                            P_Str_payment = "0";
                        if (P_Str_fullpayment == "")
                            P_Str_fullpayment = "0";

                        P_flt_gathering = P_flt_gathering + Convert.ToSingle(p_Str_gathering);
                        P_flt_fullgathering = P_flt_fullgathering + Convert.ToSingle(p_Str_fullgathering);
                        P_flt_payment = P_flt_payment + Convert.ToSingle(P_Str_payment);
                        P_flt_fullpayment = P_flt_fullpayment + Convert.ToSingle(P_Str_fullpayment);
                    }
                    currentAccountBook.tltxtGathering.Text = (P_flt_gathering - P_flt_fullgathering).ToString("0.00");
                    currentAccountBook.tltxtPayment.Text = (P_flt_payment - P_flt_fullpayment).ToString("0.00");
                    currentAccountBook.ShowDialog(); //以对话框的形式打开　　往来关系窗体
                }
                else
                {
                    MessageBox.Show("没有符合条件的记录", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Close();
        }

        private void SetAndClearCell()
        {
            //清除最后一行多余数据
            if (
                currentAccountBook.dgvCurrentAccountList[1, currentAccountBook.dgvCurrentAccountList.RowCount - 1].Value
                    .ToString().Substring(8, 4) == "JHTH")
            {
                currentAccountBook.dgvCurrentAccountList[5, currentAccountBook.dgvCurrentAccountList.RowCount - 1].Value
                    = "";
                currentAccountBook.dgvCurrentAccountList[6, currentAccountBook.dgvCurrentAccountList.RowCount - 1].Value
                    = "";
            }
            if (
                currentAccountBook.dgvCurrentAccountList[1, currentAccountBook.dgvCurrentAccountList.RowCount - 1].Value
                    .ToString().Substring(8, 2) == "XS")
            {
                currentAccountBook.dgvCurrentAccountList[5, currentAccountBook.dgvCurrentAccountList.RowCount - 1].Value
                    = "";
                currentAccountBook.dgvCurrentAccountList[6, currentAccountBook.dgvCurrentAccountList.RowCount - 1].Value
                    = "";
            }
            if (
                currentAccountBook.dgvCurrentAccountList[1, currentAccountBook.dgvCurrentAccountList.RowCount - 1].Value
                    .ToString().Substring(8, 4) == "XSTH")
            {
                currentAccountBook.dgvCurrentAccountList[3, currentAccountBook.dgvCurrentAccountList.RowCount - 1].Value
                    = "";
                currentAccountBook.dgvCurrentAccountList[4, currentAccountBook.dgvCurrentAccountList.RowCount - 1].Value
                    = "";
            }
            if (
                currentAccountBook.dgvCurrentAccountList[1, currentAccountBook.dgvCurrentAccountList.RowCount - 1].Value
                    .ToString().Substring(8, 2) == "JH")
            {
                currentAccountBook.dgvCurrentAccountList[3, currentAccountBook.dgvCurrentAccountList.RowCount - 1].Value
                    = "";
                currentAccountBook.dgvCurrentAccountList[4, currentAccountBook.dgvCurrentAccountList.RowCount - 1].Value
                    = "";
            }
            //清除多余数据
            for (int i = 0; i < currentAccountBook.dgvCurrentAccountList.RowCount; i++)
            {
                if (currentAccountBook.dgvCurrentAccountList[1, i].Value.ToString().Substring(8, 4) == "JHTH" &&
                    currentAccountBook.dgvCurrentAccountList[3, i].Value == null)
                {
                    currentAccountBook.dgvCurrentAccountList[3, i].Value =
                        currentAccountBook.dgvCurrentAccountList[5, i].Value;
                    currentAccountBook.dgvCurrentAccountList[4, i].Value =
                        currentAccountBook.dgvCurrentAccountList[6, i].Value;
                    currentAccountBook.dgvCurrentAccountList[5, i].Value = "";
                    currentAccountBook.dgvCurrentAccountList[6, i].Value = "";
                }
                if (currentAccountBook.dgvCurrentAccountList[1, i].Value.ToString().Substring(8, 2) == "XS" &&
                    currentAccountBook.dgvCurrentAccountList[3, i].Value == null)
                {
                    currentAccountBook.dgvCurrentAccountList[3, i].Value =
                        currentAccountBook.dgvCurrentAccountList[5, i].Value;
                    currentAccountBook.dgvCurrentAccountList[4, i].Value =
                        currentAccountBook.dgvCurrentAccountList[6, i].Value;
                    currentAccountBook.dgvCurrentAccountList[5, i].Value = "";
                    currentAccountBook.dgvCurrentAccountList[6, i].Value = "";
                }
                if (currentAccountBook.dgvCurrentAccountList[1, i].Value.ToString().Substring(8, 4) == "XSTH" &&
                    currentAccountBook.dgvCurrentAccountList[5, i].Value.ToString() == "")
                {
                    currentAccountBook.dgvCurrentAccountList[5, i].Value =
                        currentAccountBook.dgvCurrentAccountList[3, i].Value;
                    currentAccountBook.dgvCurrentAccountList[6, i].Value =
                        currentAccountBook.dgvCurrentAccountList[4, i].Value;
                    currentAccountBook.dgvCurrentAccountList[3, i].Value = "";
                    currentAccountBook.dgvCurrentAccountList[4, i].Value = "";
                }
                //设置货物状态－－颜色
                if (currentAccountBook.dgvCurrentAccountList[1, i].Value.ToString().Substring(8, 2) == "JH")
                    currentAccountBook.dgvCurrentAccountList.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                if (currentAccountBook.dgvCurrentAccountList[1, i].Value.ToString().Substring(8, 4) == "JHTH")
                    currentAccountBook.dgvCurrentAccountList.Rows[i].DefaultCellStyle.BackColor = Color.OrangeRed;
                if (currentAccountBook.dgvCurrentAccountList[1, i].Value.ToString().Substring(8, 2) == "XS")
                    currentAccountBook.dgvCurrentAccountList.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                if (currentAccountBook.dgvCurrentAccountList[1, i].Value.ToString().Substring(8, 4) == "XSTH")
                    currentAccountBook.dgvCurrentAccountList.Rows[i].DefaultCellStyle.BackColor = Color.YellowGreen;
                //如果到最后一行，清除
                if (i == currentAccountBook.dgvCurrentAccountList.RowCount - 1 &&
                    currentAccountBook.dgvCurrentAccountList[1, i].Value.ToString() ==
                    currentAccountBook.dgvCurrentAccountList[1 - 1, i].Value.ToString())
                {
                    currentAccountBook.dgvCurrentAccountList[4, i].Value = null;
                    currentAccountBook.dgvCurrentAccountList[6, i].Value = null;
                    break;
                }
                //到最后一行直接跳出循环
                if (i == currentAccountBook.dgvCurrentAccountList.RowCount - 1) break;
                //清除同一单据中重复数据
                if (currentAccountBook.dgvCurrentAccountList[1, i].Value.ToString() ==
                    currentAccountBook.dgvCurrentAccountList[1, i + 1].Value.ToString())
                {
                    currentAccountBook.dgvCurrentAccountList[0, i + 1].Value = null;
                    currentAccountBook.dgvCurrentAccountList[4, i + 1].Value = null;
                    currentAccountBook.dgvCurrentAccountList[6, i + 1].Value = null;
                }
            }
        }
    }
}
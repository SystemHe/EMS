using System;
using System.Data;
using System.Windows.Forms;
using EMS.BaseClass;

namespace EMS.BaseInfo
{
    public partial class frmStock : Form
    {
        private readonly BaseClass.BaseInfo baseinfo = new BaseClass.BaseInfo(); //创建BaseInfo类的对象
        private readonly cStockInfo stockinfo = new cStockInfo(); //创建cStockInfo类的对象
        private int G_Int_addOrUpdate; //定义添加/修改操作标识

        public frmStock()
        {
            InitializeComponent();
        }

        private void tlBtnAdd_Click(object sender, EventArgs e)
        {
            editEnabled(); //设置各个控件的可用状态
            clearText(); //清空文本框
            G_Int_addOrUpdate = 0; //等于0为添加数据
            DataSet ds = null; //创建数据集对象
            string P_Str_newTradeCode = ""; //设置库存商品编号为空
            int P_Int_newTradeCode = 0; //初始化商品编号中的数字码
            ds = baseinfo.GetAllStock("tb_stock"); //获取库存商品信息
            if (ds.Tables[0].Rows.Count == 0) //判断数据集中是否有值
            {
                txtTradeCode.Text = "T1001"; //设置默认商品编号
            }
            else
            {
                P_Str_newTradeCode = Convert.ToString(ds.Tables[0].Rows[ds.Tables[0].Rows.Count - 1]["tradecode"]);
                //获取已经存在的最大编号
                P_Int_newTradeCode = Convert.ToInt32(P_Str_newTradeCode.Substring(1, 4)) + 1; //获取一个最新的数字码
                P_Str_newTradeCode = "T" + P_Int_newTradeCode.ToString(); //获取最新商品编号
                txtTradeCode.Text = P_Str_newTradeCode; //将商品编号显示在文本框中
            }
        }

        //设置各按钮的可用状态
        private void editEnabled()
        {
            groupBox1.Enabled = true;
            tlBtnAdd.Enabled = false;
            tlBtnEdit.Enabled = false;
            tlBtnDelete.Enabled = false;
            tlBtnSave.Enabled = true;
            tlBtnCancel.Enabled = true;
        }

        //设置各按钮的可用状态
        private void cancelEnabled()
        {
            groupBox1.Enabled = false;
            tlBtnAdd.Enabled = true;
            tlBtnEdit.Enabled = true;
            tlBtnDelete.Enabled = true;
            tlBtnSave.Enabled = false;
            tlBtnCancel.Enabled = false;
        }

        //清空文本框
        private void clearText()
        {
            txtTradeCode.Text = string.Empty;
            txtFullName.Text = string.Empty;
            txtType.Text = string.Empty;
            txtStandard.Text = string.Empty;
            txtUnit.Text = string.Empty;
            txtProduce.Text = string.Empty;
        }

        //设置DataGridView列标题
        private void SetdgvStockListHeadText()
        {
            dgvStockList.Columns[0].HeaderText = "商品编号";
            dgvStockList.Columns[1].HeaderText = "商品名称";
            dgvStockList.Columns[2].HeaderText = "商品型号";
            dgvStockList.Columns[3].HeaderText = "商品规格";
            dgvStockList.Columns[4].HeaderText = "商品单位";
            dgvStockList.Columns[5].HeaderText = "商品产地";
            dgvStockList.Columns[6].HeaderText = "库存数量";
            dgvStockList.Columns[7].Visible = false;
            dgvStockList.Columns[8].HeaderText = "商品价格（加权平均价格）";
            dgvStockList.Columns[9].Visible = false;
            dgvStockList.Columns[10].HeaderText = "盘点数量";
            dgvStockList.Columns[11].Visible = false;
            dgvStockList.Columns[12].Visible = false;
        }

        private void frmStock_Load(object sender, EventArgs e)
        {
            txtTradeCode.ReadOnly = true; //设置商品编号文本框只读
            cancelEnabled(); //设置各按钮的可用状态
            //显示所有库存商品信息
            dgvStockList.DataSource = baseinfo.GetAllStock("tb_stock").Tables[0].DefaultView;
            SetdgvStockListHeadText(); //设置DataGridView控件的列标题
        }

        private void tlBtnSave_Click(object sender, EventArgs e)
        {
            //判断是添加还是修改数据
            if (G_Int_addOrUpdate == 0)
            {
                try
                {
                    //添加数据
                    stockinfo.TradeCode = txtTradeCode.Text;
                    stockinfo.FullName = txtFullName.Text;
                    stockinfo.TradeType = txtType.Text;
                    stockinfo.Standard = txtStandard.Text;
                    stockinfo.Unit = txtUnit.Text;
                    stockinfo.Produce = txtProduce.Text;
                    //执行添加操作
                    int id = baseinfo.AddStock(stockinfo);
                    MessageBox.Show("新增--库存商品数据--成功！", "成功提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //修改数据
                stockinfo.TradeCode = txtTradeCode.Text;
                stockinfo.FullName = txtFullName.Text;
                stockinfo.TradeType = txtType.Text;
                stockinfo.Standard = txtStandard.Text;
                stockinfo.Unit = txtUnit.Text;
                stockinfo.Produce = txtProduce.Text;
                //执行修改操作
                int id = baseinfo.UpdateStock(stockinfo);
                MessageBox.Show("修改--库存商品数据--成功！", "成功提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dgvStockList.DataSource = baseinfo.GetAllStock("tb_stock").Tables[0].DefaultView; //显示最新的库存商品信息
            SetdgvStockListHeadText(); //设置DataGridView控件列标题
            cancelEnabled(); //设置各个按钮的可用状态
        }

        private void tlBtnEdit_Click(object sender, EventArgs e)
        {
            editEnabled(); //设置各个按钮的可用状态
            G_Int_addOrUpdate = 1; //等于1为修改数据
        }

        private void tlBtnFind_Click(object sender, EventArgs e)
        {
            if (tlCmbStockType.Text == string.Empty) //判断查询类别是否为空
            {
                MessageBox.Show("查询类别不能为空！", "错误提示！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tlCmbStockType.Focus(); //使查询类别下拉列表获得鼠标焦点
                return;
            }
            else
            {
                if (tlTxtFindStock.Text.Trim() == string.Empty) //判断查询关键字是否为空
                {
                    //显示所有库存商品信息
                    dgvStockList.DataSource = baseinfo.GetAllStock("tb_stock").Tables[0].DefaultView;
                    SetdgvStockListHeadText(); //设置DataGridView控件的列标题
                    return;
                }
            }
            DataSet ds = null; //创建DataSet对象
            if (tlCmbStockType.Text == "商品产地") //按商品产地查询
            {
                stockinfo.Produce = tlTxtFindStock.Text; //记录商品产地
                ds = baseinfo.FindStockByProduce(stockinfo, "tb_Stock"); //根据商品产地查询商品信息
                dgvStockList.DataSource = ds.Tables[0].DefaultView; //显示查询到的信息
            }
            else //按商品名称查询
            {
                stockinfo.FullName = tlTxtFindStock.Text; //记录商品名称
                ds = baseinfo.FindStockByFullName(stockinfo, "tb_stock"); //根据商品名称查询商品信息
                dgvStockList.DataSource = ds.Tables[0].DefaultView; //显示查询到的信息
            }
            SetdgvStockListHeadText(); //设置DataGridView控件列标题
        }

        private void tlBtnDelete_Click(object sender, EventArgs e)
        {
            if (txtTradeCode.Text.Trim() == string.Empty) //判断是否选择了商品编号
            {
                MessageBox.Show("删除--库存商品数据--失败！", "错误提示！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            stockinfo.TradeCode = txtTradeCode.Text; //记录商品编号
            int id = baseinfo.DeleteStock(stockinfo); //执行删除操作
            MessageBox.Show("删除--库存商品数据--成功！", "成功提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvStockList.DataSource = baseinfo.GetAllStock("tb_stock").Tables[0].DefaultView; //显示最新的库存商品信息
            SetdgvStockListHeadText(); //设置DataGridView控件列标题
            clearText(); //清空文本框
        }

        private void tlBtnCancel_Click(object sender, EventArgs e)
        {
            cancelEnabled(); //设置各个按钮的可用状态
        }

        private void dgvStockList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTradeCode.Text = dgvStockList[0, dgvStockList.CurrentCell.RowIndex].Value.ToString(); //显示商品编号
            txtFullName.Text = dgvStockList[1, dgvStockList.CurrentCell.RowIndex].Value.ToString(); //显示商品全称
            txtType.Text = dgvStockList[2, dgvStockList.CurrentCell.RowIndex].Value.ToString(); //显示商品型号
            txtStandard.Text = dgvStockList[3, dgvStockList.CurrentCell.RowIndex].Value.ToString(); //显示商品规格
            txtUnit.Text = dgvStockList[4, dgvStockList.CurrentCell.RowIndex].Value.ToString(); //显示商品单位
            txtProduce.Text = dgvStockList[5, dgvStockList.CurrentCell.RowIndex].Value.ToString(); //显示商品产地
        }

        private void tlBtnExit_Click(object sender, EventArgs e)
        {
            Close(); //关闭当前窗体
        }
    }
}
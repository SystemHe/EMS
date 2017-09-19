using System;
using System.Data;
using System.Windows.Forms;
using EMS.BaseClass;

namespace EMS.Stock
{
    public partial class frmCheckStock : Form
    {
        private readonly BaseClass.BaseInfo baseinfo = new BaseClass.BaseInfo(); //创建BaseInfo类的对象
        private readonly cStockInfo stockinfo = new cStockInfo(); //创建cStockInfo类的对象
        private string G_Str_tradecode = ""; //记录要盘点的商品编号

        public frmCheckStock()
        {
            InitializeComponent();
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
            dgvStockList.Columns[8].Visible = false;
            dgvStockList.Columns[9].Visible = false;
            dgvStockList.Columns[10].HeaderText = "盘点数量";
            dgvStockList.Columns[11].Visible = false;
            dgvStockList.Columns[12].Visible = false;
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
                if (tlTxtFindStock.Text.Trim() == string.Empty) //判断是否输入了查询关键字
                {
                    dgvStockList.DataSource = baseinfo.GetAllStock("tb_stock").Tables[0].DefaultView; //获取所有商品信息并显示
                    SetdgvStockListHeadText(); //设置DataGridView控件列标题
                    return;
                }
            }
            DataSet ds = null; //创建DataSet对象
            if (tlCmbStockType.Text == "商品产地") //按商品产地查询
            {
                stockinfo.Produce = tlTxtFindStock.Text; //记录商品产地
                ds = baseinfo.FindStockByProduce(stockinfo, "tb_stock"); //根据商品产地查询信息
                dgvStockList.DataSource = ds.Tables[0].DefaultView; //显示查询到的信息
            }
            else //按商品名称查询
            {
                stockinfo.FullName = tlTxtFindStock.Text; //记录商品名称
                ds = baseinfo.FindStockByFullName(stockinfo, "tb_stock"); //根据商品名称查询信息
                dgvStockList.DataSource = ds.Tables[0].DefaultView; //显示查询到的信息
            }
            SetdgvStockListHeadText(); //设置DataGridView控件列标题
        }

        private void frmCheckStock_Load(object sender, EventArgs e)
        {
            dgvStockList.DataSource = baseinfo.GetAllStock("tb_stock").Tables[0].DefaultView; //显示所有商品信息
            SetdgvStockListHeadText(); //设置DataGridView控件列标题
        }

        private void dgvStockList_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            tltxtFullName.Text = dgvStockList[1, e.RowIndex].Value.ToString(); //显示商品名称
            G_Str_tradecode = dgvStockList[0, e.RowIndex].Value.ToString(); //记录商品编号
        }

        private void tlbtnCheckStock_Click(object sender, EventArgs e)
        {
            if (tltxtCheckStock.Text == string.Empty) //判断是否输入了盘点数量
            {
                MessageBox.Show("盘点数量不能为空！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //验证输入的文本必须为阿拉伯数字
            for (int i = 0; i < tltxtCheckStock.Text.Length; i++)
            {
                if (!Char.IsNumber(tltxtCheckStock.Text, i)) //判断是否为数字
                {
                    MessageBox.Show("库存上限设置必须为阿拉伯数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            stockinfo.TradeCode = G_Str_tradecode; //设置商品编号
            stockinfo.Check = Convert.ToSingle(tltxtCheckStock.Text); //设置盘点数量
            int d = baseinfo.CheckStock(stockinfo); //执行库存盘点操作
            dgvStockList.DataSource = baseinfo.GetAllStock("tb_stock").Tables[0].DefaultView; //显示最新的库存商品信息
            SetdgvStockListHeadText(); //设置DataGridView控件列标题
            MessageBox.Show("保存库存商品盘点成功！", "成功提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tlBtnExit_Click(object sender, EventArgs e)
        {
            Close(); //关闭当前窗体
        }
    }
}
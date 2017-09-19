using System;
using System.Windows.Forms;

namespace EMS.SetSystem
{
    public partial class frmClearTable : Form
    {
        private readonly BaseClass.BaseInfo baseinfo = new BaseClass.BaseInfo(); //创建BaseInfo类的对象

        public frmClearTable()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (chkCurrent.Checked) //判断往来账明细表复选框是否选中
                baseinfo.ClearTable("tb_currentaccount"); //清理往来对账明细信息
            if (chkWarehouse.Checked) //判断进货表复选框是否选中
            {
                baseinfo.ClearTable("tb_warehouse_main"); //清理进货主表信息
                baseinfo.ClearTable("tb_warehouse_detailed"); //清理进货明细表信息
            }
            if (chkRewarehouse.Checked) //判断进货退货表复选框是否选中
            {
                baseinfo.ClearTable("tb_rewarehouse_main"); //清理进货退货主表信息
                baseinfo.ClearTable("tb_rewarehouse_detailed"); //清理进货退货明细表信息
            }
            if (chkSell.Checked) //判断销售表复选框是否选中
            {
                baseinfo.ClearTable("tb_sell_main"); //清理销售主表信息
                baseinfo.ClearTable("tb_sell_detailed"); //清理销售明细表信息
            }
            if (chkResell.Checked) //判断销售退货表复选框是否选中
            {
                baseinfo.ClearTable("tb_resell_main"); //清理销售退货主表信息
                baseinfo.ClearTable("tb_resell_detailed"); //清理销售退货明细表信息
            }
            if (chkUser.Checked) baseinfo.ClearTable("tb_power"); //清理用户信息
            if (chkUnit.Checked) baseinfo.ClearTable("tb_unit"); //清理本单位信息
            if (chkStock.Checked) baseinfo.ClearTable("tb_stock"); //清理库存信息
            if (chkEmployee.Checked) baseinfo.ClearTable("tb_employee"); //清理公司职员信息
            if (chkUnits.Checked) baseinfo.ClearTable("tb_units"); //清理往来单位信息
            MessageBox.Show("系统数据清理成功！", "成功提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close(); //关闭当前窗体
        }
    }
}
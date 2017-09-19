using System;
using System.Windows.Forms;
using EMS.BaseClass;

namespace EMS.SelectDataDialog
{
    public partial class frmSetStockLimit : Form
    {
        public frmSetStockLimit()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //验证输入的文本必须为阿拉伯数字。
            for (int i = 0; i < txtUpperLimit.Text.Length; i++)
            {
                if (!Char.IsNumber(txtUpperLimit.Text, i))
                {
                    MessageBox.Show("库存上限设置必须为阿拉伯数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            for (int i = 0; i < txtLowerLimit.Text.Length; i++)
            {
                if (!Char.IsNumber(txtLowerLimit.Text, i))
                {
                    MessageBox.Show("库存上限设置必须为阿拉伯数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            //更新数据
            BaseClass.BaseInfo baseinfo = new BaseClass.BaseInfo();
            cStockInfo stock = new cStockInfo();
            stock.TradeCode = groupBox1.Text.Substring(1, 5);
            stock.UpperLimit = Convert.ToSingle(txtUpperLimit.Text);
            stock.LowerLimit = Convert.ToSingle(txtLowerLimit.Text);
            int d = baseinfo.UpdateStockLimit(stock);
            MessageBox.Show("库存上下限设置成功！", "成功提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
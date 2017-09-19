using System;
using System.Diagnostics;
using System.Windows.Forms;
using EMS.BaseInfo;
using EMS.BuyStock;
using EMS.SaleStock;
using EMS.SelectDataDialog;
using EMS.SetSystem;
using EMS.Stock;
using frmUnits = EMS.BaseInfo.frmUnits;

namespace EMS
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void fileUnits_Click(object sender, EventArgs e)
        {
            frmUnits frm_units = new frmUnits();
            frm_units.Show();
        }

        private void fileStore_Click(object sender, EventArgs e)
        {
            new frmStock().Show();
        }

        private void fileEmployee_Click(object sender, EventArgs e)
        {
            new frmEmployee().Show();
        }

        private void fileBuyStock_Click(object sender, EventArgs e)
        {
            new frmBuyStock().Show();
        }

        private void fileResellStock_Click(object sender, EventArgs e)
        {
            new frmResellStock().Show();
        }

        private void fileRebuyStock_Click(object sender, EventArgs e)
        {
            new frmRebuyStock().Show();
        }

        private void fileSellStock_Click(object sender, EventArgs e)
        {
            new frmSellStock().Show();
        }

        private void fileBuyStockAnalyse_Click(object sender, EventArgs e)
        {
            new frmBuyStockAnalyse().Show();
        }

        private void fileBuyStockSum_Click(object sender, EventArgs e)
        {
            new frmBuyStockSum().Show();
        }

        private void fileSellStockSum_Click(object sender, EventArgs e)
        {
            new frmSellStockSum().Show();
        }

        private void fileSellStockStatus_Click(object sender, EventArgs e)
        {
            new frmSellStockStatus().Show();
        }

        private void fileSellStockOrderBy_Click(object sender, EventArgs e)
        {
            new frmSelectOrderby().Show();
        }

        private void fileSellStockCost_Click(object sender, EventArgs e)
        {
            new frmSellStockCost().Show();
        }

        private void fileStockStatus_Click(object sender, EventArgs e)
        {
            new frmStockStatus().Show();
        }

        private void fileUpperLimit_Click(object sender, EventArgs e)
        {
            new frmUpperLimit().Show();
        }

        private void fileLowerLimit_Click(object sender, EventArgs e)
        {
            new frmLowerLimit().Show();
        }

        private void fileCheckStock_Click(object sender, EventArgs e)
        {
            new frmCheckStock().Show();
        }

        private void 本单位ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SetSystem.frmUnits().Show();
        }

        private void fileUnitsList_Click(object sender, EventArgs e)
        {
            new frmUnitsList().Show();
        }

        private void fileCurrentBook_Click(object sender, EventArgs e)
        {
            new frmUnitsList().Show();
        }

        private void fileBakupAndRestor_Click(object sender, EventArgs e)
        {
            new frmBakup().Show();
        }

        private void fileClearTable_Click(object sender, EventArgs e)
        {
            new frmClearTable().Show();
        }

        private void fileSetOP_Click(object sender, EventArgs e)
        {
            new frmSetOP().Show();
        }

        private void frmSysPopedom_Click(object sender, EventArgs e)
        {
            new frmSetOP().Show();
        }

        private void fileEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void 登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("iexplore.exe");
        }

        private void 启动WordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("WINWORD.EXE");
        }

        private void 启动ExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("excel.exe");
        }

        private void 系统计算器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }
    }
}
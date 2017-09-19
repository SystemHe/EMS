using System;
using System.Data;
using System.Windows.Forms;

namespace EMS.Stock
{
    public partial class frmLowerLimit : Form
    {
        public frmLowerLimit()
        {
            InitializeComponent();
        }

        private void frmLowerLimit_Load(object sender, EventArgs e)
        {
            BaseClass.BaseInfo baseinfo = new BaseClass.BaseInfo();
            DataSet ds = null;
            ds = baseinfo.GetLowerLimit();
            dgvStockList.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
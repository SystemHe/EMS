using System;
using System.Data;
using System.Windows.Forms;
using EMS.SelectDataDialog;

namespace EMS.BuyStock
{
    public partial class frmUnitsList : Form
    {
        private readonly BaseClass.BaseInfo baseinfo = new BaseClass.BaseInfo();

        public frmUnitsList()
        {
            InitializeComponent();
        }

        private void frmUnitsList_Load(object sender, EventArgs e)
        {
            DataSet ds = null;
            ds = baseinfo.GetUnitsList();
            dgvUnitsList.DataSource = ds.Tables[0].DefaultView;
            dgvUnitsList.Columns[0].Width = 200;
        }

        private void dgvUnitsList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmSelectDateTime selectDateTime = new frmSelectDateTime();
            selectDateTime.M_Str_units = dgvUnitsList[0, e.RowIndex].Value.ToString();
            selectDateTime.Show();
        }
    }
}
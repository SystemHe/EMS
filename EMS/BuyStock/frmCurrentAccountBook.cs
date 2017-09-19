using System;
using System.Windows.Forms;

namespace EMS.BuyStock
{
    public partial class frmCurrentAccountBook : Form
    {
        public frmCurrentAccountBook()
        {
            InitializeComponent();
        }

        private void frmCurrentAccountBook_Load(object sender, EventArgs e)
        {
        }

        private void tlbtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
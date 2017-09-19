using System;
using System.Data;
using System.Windows.Forms;
using EMS.BaseClass;

namespace EMS.BaseInfo
{
    public partial class frmEmployee : Form
    {
        private readonly BaseClass.BaseInfo baseinfo = new BaseClass.BaseInfo();
        private readonly cEmployeeInfo employeeinfo = new cEmployeeInfo();
        private int G_Int_addOrUpdate;

        public frmEmployee()
        {
            InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            txtEmpployCode.ReadOnly = true; //商品编号为唯一标识不能更改
            cancelEnabled();
            dgvEmployeeList.DataSource = baseinfo.GetAllEmployee("tb_employee").Tables[0].DefaultView;
            SetdgvEmployeeListHeadText();
        }

        private void editEnabled() //屏毕与此功能无关的按钮
        {
            groupBox1.Enabled = true; //将容器可以使用，准备添加新的往来单位信息
            tlBtnAdd.Enabled = false;
            tlBtnEdit.Enabled = false;
            tlBtnDelete.Enabled = false;
            tlBtnSave.Enabled = true;
            tlBtnCancel.Enabled = true;
        }

        private void cancelEnabled()
        {
            groupBox1.Enabled = false;
            tlBtnAdd.Enabled = true;
            tlBtnEdit.Enabled = true;
            tlBtnDelete.Enabled = true;
            tlBtnSave.Enabled = false;
            tlBtnCancel.Enabled = false;
        }

        private void clearText()
        {
            txtEmpployCode.Text = string.Empty;
            txtFullName.Text = string.Empty;
            cmbSex.Text = string.Empty;
            txtDept.Text = string.Empty;
            txtTel.Text = string.Empty;
            txtMemo.Text = string.Empty;
        }

        //设置DataGridView标题
        private void SetdgvEmployeeListHeadText()
        {
            dgvEmployeeList.Columns[0].HeaderText = "职员编号";
            dgvEmployeeList.Columns[1].HeaderText = "职员姓名";
            dgvEmployeeList.Columns[2].HeaderText = "性别";
            dgvEmployeeList.Columns[3].HeaderText = "所在部门";
            dgvEmployeeList.Columns[4].HeaderText = "联系电话";
            dgvEmployeeList.Columns[5].HeaderText = "备注";
        }

        private void tlBtnFind_Click(object sender, EventArgs e)
        {
            if (tlCmbEmployeeType.Text.Trim() == string.Empty)
            {
                MessageBox.Show("查询类别不能为空！", "错误提示！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tlCmbEmployeeType.Focus();
                return;
            }
            else
            {
                if (tlTxtFindEmployee.Text.Trim() == string.Empty)
                {
                    dgvEmployeeList.DataSource = baseinfo.GetAllEmployee("tb_Employee").Tables[0].DefaultView;
                    SetdgvEmployeeListHeadText();
                    return;
                }
            }
            DataSet ds = null; //创建DataSet对象
            if (tlCmbEmployeeType.Text == "所在部门") //按单位编号查询
            {
                employeeinfo.Dept = tlTxtFindEmployee.Text;
                ds = baseinfo.FindEmployeeByDept(employeeinfo, "tb_employee");
                dgvEmployeeList.DataSource = ds.Tables[0].DefaultView;
            }
            else //按单位名称查询
            {
                employeeinfo.FullName = tlTxtFindEmployee.Text;
                ds = baseinfo.FindEmployeeByFullName(employeeinfo, "tb_Employee");
                dgvEmployeeList.DataSource = ds.Tables[0].DefaultView;
            }
            SetdgvEmployeeListHeadText();
        }

        private void tlBtnAdd_Click(object sender, EventArgs e)
        {
            editEnabled();
            clearText();
            G_Int_addOrUpdate = 0; //等于０为添加数据
            //设置自动编号
            DataSet ds = null;
            string P_Str_newEmployeeCode = "";
            int P_Int_newEmployeeCode = 0;
            ds = baseinfo.GetAllEmployee("tb_employee");


            if (ds.Tables[0].Rows.Count == 0)
            {
                txtEmpployCode.Text = "E1001";
            }
            else
            {
                P_Str_newEmployeeCode = Convert.ToString(ds.Tables[0].Rows[ds.Tables[0].Rows.Count - 1]["employeecode"]);
                P_Int_newEmployeeCode = Convert.ToInt32(P_Str_newEmployeeCode.Substring(1, 4)) + 1;
                P_Str_newEmployeeCode = "E" + P_Int_newEmployeeCode.ToString();
                txtEmpployCode.Text = P_Str_newEmployeeCode;
            }
        }

        private void tlBtnEdit_Click(object sender, EventArgs e)
        {
            editEnabled();
            G_Int_addOrUpdate = 1; //等于１为修改数据
        }

        private void tlBtnSave_Click(object sender, EventArgs e)
        {
            //判断是添加还是修改数据
            if (G_Int_addOrUpdate == 0)
            {
                try
                {
                    //添加数据
                    employeeinfo.EmployeeCode = txtEmpployCode.Text;
                    employeeinfo.FullName = txtFullName.Text;
                    employeeinfo.Sex = cmbSex.Text;
                    employeeinfo.Dept = txtDept.Text;
                    employeeinfo.Tel = txtTel.Text;
                    employeeinfo.Memo = txtMemo.Text;

                    //执行添加
                    int id = baseinfo.AddEmployee(employeeinfo);
                    MessageBox.Show("新增--公司职员数据--成功！", "成功提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //修改数据
                employeeinfo.EmployeeCode = txtEmpployCode.Text;
                employeeinfo.FullName = txtFullName.Text;
                employeeinfo.Sex = cmbSex.Text;
                employeeinfo.Dept = txtDept.Text;
                employeeinfo.Tel = txtTel.Text;
                employeeinfo.Memo = txtMemo.Text;

                //执行修改
                int id = baseinfo.UpdateEmployee(employeeinfo);
                MessageBox.Show("修改--公司职员数据--成功！", "成功提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dgvEmployeeList.DataSource = baseinfo.GetAllEmployee("tb_employee").Tables[0].DefaultView;
            SetdgvEmployeeListHeadText();
            cancelEnabled();
        }

        private void tlBtnCancel_Click(object sender, EventArgs e)
        {
            cancelEnabled();
        }

        private void tlBtnDelete_Click(object sender, EventArgs e)
        {
            if (txtEmpployCode.Text.Trim() == string.Empty)
            {
                MessageBox.Show("删除--公司职员数据--失败！", "错误提示！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            employeeinfo.EmployeeCode = txtEmpployCode.Text;
            //执行删除
            int id = baseinfo.DeleteEmployee(employeeinfo);
            MessageBox.Show("删除--公司职员数据--成功！", "成功提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvEmployeeList.DataSource = baseinfo.GetAllEmployee("tb_employee").Tables[0].DefaultView;
            SetdgvEmployeeListHeadText();
            clearText();
        }

        private void dgvEmployeeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEmpployCode.Text = dgvEmployeeList[0, dgvEmployeeList.CurrentCell.RowIndex].Value.ToString();
            txtFullName.Text = dgvEmployeeList[1, dgvEmployeeList.CurrentCell.RowIndex].Value.ToString();
            cmbSex.Text = dgvEmployeeList[2, dgvEmployeeList.CurrentCell.RowIndex].Value.ToString();
            txtDept.Text = dgvEmployeeList[3, dgvEmployeeList.CurrentCell.RowIndex].Value.ToString();
            txtTel.Text = dgvEmployeeList[4, dgvEmployeeList.CurrentCell.RowIndex].Value.ToString();
            txtMemo.Text = dgvEmployeeList[5, dgvEmployeeList.CurrentCell.RowIndex].Value.ToString();
        }

        private void tlBtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
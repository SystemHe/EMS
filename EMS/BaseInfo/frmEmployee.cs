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
            txtEmpployCode.ReadOnly = true; //��Ʒ���ΪΨһ��ʶ���ܸ���
            cancelEnabled();
            dgvEmployeeList.DataSource = baseinfo.GetAllEmployee("tb_employee").Tables[0].DefaultView;
            SetdgvEmployeeListHeadText();
        }

        private void editEnabled() //������˹����޹صİ�ť
        {
            groupBox1.Enabled = true; //����������ʹ�ã�׼������µ�������λ��Ϣ
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

        //����DataGridView����
        private void SetdgvEmployeeListHeadText()
        {
            dgvEmployeeList.Columns[0].HeaderText = "ְԱ���";
            dgvEmployeeList.Columns[1].HeaderText = "ְԱ����";
            dgvEmployeeList.Columns[2].HeaderText = "�Ա�";
            dgvEmployeeList.Columns[3].HeaderText = "���ڲ���";
            dgvEmployeeList.Columns[4].HeaderText = "��ϵ�绰";
            dgvEmployeeList.Columns[5].HeaderText = "��ע";
        }

        private void tlBtnFind_Click(object sender, EventArgs e)
        {
            if (tlCmbEmployeeType.Text.Trim() == string.Empty)
            {
                MessageBox.Show("��ѯ�����Ϊ�գ�", "������ʾ��", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            DataSet ds = null; //����DataSet����
            if (tlCmbEmployeeType.Text == "���ڲ���") //����λ��Ų�ѯ
            {
                employeeinfo.Dept = tlTxtFindEmployee.Text;
                ds = baseinfo.FindEmployeeByDept(employeeinfo, "tb_employee");
                dgvEmployeeList.DataSource = ds.Tables[0].DefaultView;
            }
            else //����λ���Ʋ�ѯ
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
            G_Int_addOrUpdate = 0; //���ڣ�Ϊ�������
            //�����Զ����
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
            G_Int_addOrUpdate = 1; //���ڣ�Ϊ�޸�����
        }

        private void tlBtnSave_Click(object sender, EventArgs e)
        {
            //�ж�����ӻ����޸�����
            if (G_Int_addOrUpdate == 0)
            {
                try
                {
                    //�������
                    employeeinfo.EmployeeCode = txtEmpployCode.Text;
                    employeeinfo.FullName = txtFullName.Text;
                    employeeinfo.Sex = cmbSex.Text;
                    employeeinfo.Dept = txtDept.Text;
                    employeeinfo.Tel = txtTel.Text;
                    employeeinfo.Memo = txtMemo.Text;

                    //ִ�����
                    int id = baseinfo.AddEmployee(employeeinfo);
                    MessageBox.Show("����--��˾ְԱ����--�ɹ���", "�ɹ���ʾ��", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //�޸�����
                employeeinfo.EmployeeCode = txtEmpployCode.Text;
                employeeinfo.FullName = txtFullName.Text;
                employeeinfo.Sex = cmbSex.Text;
                employeeinfo.Dept = txtDept.Text;
                employeeinfo.Tel = txtTel.Text;
                employeeinfo.Memo = txtMemo.Text;

                //ִ���޸�
                int id = baseinfo.UpdateEmployee(employeeinfo);
                MessageBox.Show("�޸�--��˾ְԱ����--�ɹ���", "�ɹ���ʾ��", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("ɾ��--��˾ְԱ����--ʧ�ܣ�", "������ʾ��", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            employeeinfo.EmployeeCode = txtEmpployCode.Text;
            //ִ��ɾ��
            int id = baseinfo.DeleteEmployee(employeeinfo);
            MessageBox.Show("ɾ��--��˾ְԱ����--�ɹ���", "�ɹ���ʾ��", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
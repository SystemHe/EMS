using System;
using System.Data;
using System.Windows.Forms;
using EMS.BaseClass;

//�������

namespace EMS.BaseInfo
{
    public partial class frmUnits : Form
    {
        private readonly BaseClass.BaseInfo baseinfo = new BaseClass.BaseInfo();
        private readonly cUnitsInfo unitsInfo = new cUnitsInfo();
        private int G_Int_addOrUpdate;

        public frmUnits()
        {
            InitializeComponent();
        }

        private void frmUnits_Load(object sender, EventArgs e)
        {
            txtUnitCode.ReadOnly = true; //��λ���ΪΨһ��ʶ���ܸ���
            cancelEnabled();
            dgvUnitsList.DataSource = baseinfo.GetAllUnits("tb_units").Tables[0].DefaultView;
            SetdgvUnitsListHeadText();
        }

        private void tlBtnAdd_Click(object sender, EventArgs e)
        {
            editEnabled();
            clearText();
            G_Int_addOrUpdate = 0; //���ڣ�Ϊ�������
            //�����Զ����
            DataSet ds = null;
            string P_Str_newUnitcode = "";
            int P_Int_newUnitcode = 0;
            ds = baseinfo.GetAllUnits("tb_units");
            if (ds.Tables[0].Rows.Count == 0)
            {
                txtUnitCode.Text = "U1001";
            }
            else
            {
                P_Str_newUnitcode = Convert.ToString(ds.Tables[0].Rows[ds.Tables[0].Rows.Count - 1]["unitcode"]);
                P_Int_newUnitcode = Convert.ToInt32(P_Str_newUnitcode.Substring(1, 4)) + 1;
                P_Str_newUnitcode = "U" + P_Int_newUnitcode.ToString();
                txtUnitCode.Text = P_Str_newUnitcode;
            }
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
            txtUnitCode.Text = string.Empty;
            txtFullName.Text = string.Empty;
            txtTax.Text = string.Empty;
            txtTel.Text = string.Empty;
            txtLinkMan.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtAccounts.Text = string.Empty;
        }

        private void tlBtnCancel_Click(object sender, EventArgs e)
        {
            cancelEnabled();
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
                    unitsInfo.UnitCode = txtUnitCode.Text;
                    unitsInfo.FullName = txtFullName.Text;
                    unitsInfo.Tax = txtTax.Text;
                    unitsInfo.Tel = txtTel.Text;
                    unitsInfo.LinkMan = txtLinkMan.Text;
                    unitsInfo.Address = txtAddress.Text;
                    unitsInfo.Accounts = txtAccounts.Text;
                    //ִ�����
                    int id = baseinfo.AddUnits(unitsInfo);
                    MessageBox.Show("����--������λ����--�ɹ���", "�ɹ���ʾ��", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //�޸�����
                unitsInfo.UnitCode = txtUnitCode.Text;
                unitsInfo.FullName = txtFullName.Text;
                unitsInfo.Tax = txtTax.Text;
                unitsInfo.Tel = txtTel.Text;
                unitsInfo.LinkMan = txtLinkMan.Text;
                unitsInfo.Address = txtAddress.Text;
                unitsInfo.Accounts = txtAccounts.Text;
                //ִ���޸�
                int id = baseinfo.UpdateUnits(unitsInfo);
                MessageBox.Show("�޸�--������λ����--�ɹ���", "�ɹ���ʾ��", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dgvUnitsList.DataSource = baseinfo.GetAllUnits("tb_units").Tables[0].DefaultView;
            SetdgvUnitsListHeadText();
            cancelEnabled();
        }

        //��ѯ������λ
        private void tlBtnFind_Click(object sender, EventArgs e)
        {
            if (tlCmbUnitsType.Text == string.Empty)
            {
                MessageBox.Show("��ѯ�����Ϊ�գ�", "������ʾ��", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tlCmbUnitsType.Focus();
                return;
            }
            else
            {
                if (tlTxtFindUnits.Text.Trim() == string.Empty)
                {
                    dgvUnitsList.DataSource = baseinfo.GetAllUnits("tb_units").Tables[0].DefaultView;
                    SetdgvUnitsListHeadText();
                    return;
                }
            }
            DataSet ds = null; //����DataSet����
            if (tlCmbUnitsType.Text == "��λ���") //����λ��Ų�ѯ
            {
                unitsInfo.UnitCode = tlTxtFindUnits.Text;
                ds = baseinfo.FindUnitsByUnitCode(unitsInfo, "tbUnits");
                dgvUnitsList.DataSource = ds.Tables[0].DefaultView;
            }
            else //����λ���Ʋ�ѯ
            {
                unitsInfo.FullName = tlTxtFindUnits.Text;
                ds = baseinfo.FindUnitsByFullName(unitsInfo, "tbUnits");
                dgvUnitsList.DataSource = ds.Tables[0].DefaultView;
            }
            SetdgvUnitsListHeadText();
        }

        //����DataGridView����
        public void SetdgvUnitsListHeadText()
        {
            dgvUnitsList.Columns[0].HeaderText = "��λ���";
            dgvUnitsList.Columns[1].HeaderText = "��λ����";
            dgvUnitsList.Columns[2].HeaderText = "˰��";
            dgvUnitsList.Columns[3].HeaderText = "��λ�绰";
            dgvUnitsList.Columns[4].HeaderText = "��ϵ��";
            dgvUnitsList.Columns[5].HeaderText = "��λ��ַ";
            dgvUnitsList.Columns[6].HeaderText = "�����м��˺�";
            dgvUnitsList.Columns[7].HeaderText = "�ۼ�Ӧ�տ�";
            dgvUnitsList.Columns[7].Visible = false;
            dgvUnitsList.Columns[8].HeaderText = "�ۼ�Ӧ����";
            dgvUnitsList.Columns[8].Visible = false;
        }

        private void dgvUnitsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUnitCode.Text = dgvUnitsList[0, dgvUnitsList.CurrentCell.RowIndex].Value.ToString();
            txtFullName.Text = dgvUnitsList[1, dgvUnitsList.CurrentCell.RowIndex].Value.ToString();
            txtTax.Text = dgvUnitsList[2, dgvUnitsList.CurrentCell.RowIndex].Value.ToString();
            txtTel.Text = dgvUnitsList[3, dgvUnitsList.CurrentCell.RowIndex].Value.ToString();
            txtLinkMan.Text = dgvUnitsList[4, dgvUnitsList.CurrentCell.RowIndex].Value.ToString();
            txtAddress.Text = dgvUnitsList[5, dgvUnitsList.CurrentCell.RowIndex].Value.ToString();
            txtAccounts.Text = dgvUnitsList[6, dgvUnitsList.CurrentCell.RowIndex].Value.ToString();
        }

        private void tlBtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tlBtnDelete_Click(object sender, EventArgs e)
        {
            if (txtUnitCode.Text.Trim() == string.Empty)
            {
                MessageBox.Show("ɾ��--������λ����--ʧ�ܣ�", "������ʾ��", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            unitsInfo.UnitCode = txtUnitCode.Text;
            //ִ��ɾ��
            int id = baseinfo.DeleteUnits(unitsInfo);
            MessageBox.Show("ɾ��--������λ����--�ɹ���", "�ɹ���ʾ��", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvUnitsList.DataSource = baseinfo.GetAllUnits("tb_units").Tables[0].DefaultView;
            SetdgvUnitsListHeadText();
            clearText();
        }
    }
}
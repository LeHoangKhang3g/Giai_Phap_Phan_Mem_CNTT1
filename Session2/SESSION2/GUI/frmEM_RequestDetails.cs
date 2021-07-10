using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace GUI
{
    public partial class frmEM_RequestDetails : Form
    {
        private PartBUS _partBUS = new PartBUS();
        private ChangedPartBUS _changedPart = new ChangedPartBUS();
        private EmergencyMaintenanceBUS _EM = new EmergencyMaintenanceBUS();
        public frmEM_RequestDetails()
        {
            InitializeComponent();
            dgvParts.AutoGenerateColumns = false;
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTechnicianNote.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(_EM.UpdateEM(frmEM_Management_Admin._id, dtpStartDate.Value, dtpCompletedOn.Value, txtTechnicianNote.Text))
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void frmEM_RequestDetails_Load(object sender, EventArgs e)
        {
            lblAssetSN.Text = frmEM_Management_Admin._assetSN;
            lblAssetName.Text = frmEM_Management_Admin._assetName;
            lblDepartment.Text = frmEM_Management_Admin._department;
            dtpStartDate.Value = DateTime.Now;

            cbbPartName.DataSource = _partBUS.GetListPart();
            cbbPartName.DisplayMember = "Name";
            cbbPartName.ValueMember = "ID";
            dgvParts.DataSource = _changedPart.GetListChangedPart(frmEM_Management_Admin._id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtAmount.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(_changedPart.InsertChangedPart(frmEM_Management_Admin._id, Int64.Parse(cbbPartName.SelectedValue.ToString()), Decimal.Parse(txtAmount.Text)))
            {
                dgvParts.DataSource = _changedPart.GetListChangedPart(frmEM_Management_Admin._id);
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvParts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvParts.Columns[e.ColumnIndex].Name=="Action")
            {
                DataGridViewRow row = dgvParts.Rows[dgvParts.CurrentCell.RowIndex];
                if(MessageBox.Show("Bạn có muốn xóa phần này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==DialogResult.Yes)
                {
                    _changedPart.DeleteChangedPart(Int64.Parse(row.Cells[3].Value.ToString()));
                    dgvParts.DataSource = _changedPart.GetListChangedPart(frmEM_Management_Admin._id);
                }
            }
        }
    }
}

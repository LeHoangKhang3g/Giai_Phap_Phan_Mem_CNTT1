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
    public partial class frmEM_Request : Form
    {
        EmergencyMaintenanceBUS _emergencyMaintenanceBUS = new EmergencyMaintenanceBUS();
        PriorityBUS _priorityBUS = new PriorityBUS();
        public frmEM_Request()
        {
            InitializeComponent();
        }

        private void frmEM_Request_Load(object sender, EventArgs e)
        {
            lblAssetSN.Text = frmEM_Management._assetSN;
            lblAssetName.Text = frmEM_Management._assetName;
            lblDepartment.Text = frmEM_Management._department;

            cbbPriority.DataSource = _priorityBUS.GetPriorities();
            cbbPriority.SelectedIndex = 0;
            cbbPriority.DisplayMember = "Name";
            cbbPriority.ValueMember = "ID";
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDescriptionOfEmergency.Text) == true || String.IsNullOrEmpty(txtOtherConsiderations.Text) == true)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                EmergencyMaintenanceDTO emergencyMaintenanceDTO = new EmergencyMaintenanceDTO();
                emergencyMaintenanceDTO.AssetID = frmEM_Management._assetID;
                emergencyMaintenanceDTO.PriorityID = Convert.ToInt64(cbbPriority.SelectedValue.ToString());
                emergencyMaintenanceDTO.DescriptionEmergency = txtDescriptionOfEmergency.Text;
                emergencyMaintenanceDTO.OtherConsiderations = txtOtherConsiderations.Text;

                if (_emergencyMaintenanceBUS.AddEM_Request(emergencyMaintenanceDTO.AssetID, emergencyMaintenanceDTO.PriorityID, emergencyMaintenanceDTO.DescriptionEmergency, emergencyMaintenanceDTO.OtherConsiderations))
                {
                    MessageBox.Show("Đã thêm thành công Emergency Maintenance Request", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm không thành công Emergency Maintenance Request", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmEM_Management : Form
    {
        public static string _assetSN;
        public static string _assetName;
        public static string _department;

        public frmEM_Management()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSendEmergencyMaintenanceRequest_Click(object sender, EventArgs e)
        {
            if (dgvAvailableAsset.Rows.Count > 0)
            {
                DataGridViewRow row = dgvAvailableAsset.Rows[dgvAvailableAsset.CurrentCell.RowIndex];
                _assetSN = row.Cells[0].Value.ToString();
                _assetName = row.Cells[1].Value.ToString();
                frmEM_Request frmRequest = new frmEM_Request();
                frmRequest.Show();
            }
        }
    }
}

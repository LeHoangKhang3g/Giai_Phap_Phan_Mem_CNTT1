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
    public partial class frmEM_RequestDetails : Form
    {
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

        }

        private void frmEM_RequestDetails_Load(object sender, EventArgs e)
        {
            lblAssetSN.Text = frmEM_Management_Admin._assetSN;
            lblAssetName.Text = frmEM_Management_Admin._assetName;
            lblDepartment.Text = frmEM_Management_Admin._department;
        }
    }
}

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
        public frmEM_Request()
        {
            InitializeComponent();
        }

        private void frmEM_Request_Load(object sender, EventArgs e)
        {
            lblAssetSN.Text = frmEM_Management._assetSN;
            lblAssetName.Text = frmEM_Management._assetName;
            lblDepartment.Text = frmEM_Management._department;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSendRequest_Click(object sender, EventArgs e)
        {

        }
    }
}

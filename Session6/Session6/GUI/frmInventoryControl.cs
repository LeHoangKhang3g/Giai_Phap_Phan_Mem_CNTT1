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
    public partial class frmInventoryControl : Form
    {
        public frmInventoryControl()
        {
            InitializeComponent();
        }

        private void frmInventoryControl_Load(object sender, EventArgs e)
        {
            #region TRANSLATE SCREEN IN HERE 
            lblAllocationMethod.Text = "Allocation Method";
            lblAmount.Text = "Amount:";
            lblAssetName.Text = "Asset Name (EM Number):";
            lblDate.Text = "Date:";
            lblHeaderInventoryControl.Text = "Inventory Control";
            lblPartName.Text = "Part Name:";
            lblWarehouse.Text = "Warehouse";

            grbAllocatedParts.Text = "Allocated Parts";
            grbSearchForParts.Text = "Search for Parts";
            grbAssignedParts.Text = "Assigned Parts";

            btnAllocate.Text = "*Allocate";
            btnAssignToEM.Text = "Assign to EM";
            btnCancel.Text = "Cancel";
            btnSubmit.Text = "Submit";
            #endregion
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

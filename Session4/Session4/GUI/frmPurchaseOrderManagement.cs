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
    public partial class frmPurchaseOrderManagement : Form
    {
        private SuppliersBUS _supp = new SuppliersBUS();
        private WarehouseBUS _ware = new WarehouseBUS();
        private PartsBUS _part = new PartsBUS();
        public frmPurchaseOrderManagement()
        {
            InitializeComponent();
        }

        private void frmPurchaseOrderManagement_Load(object sender, EventArgs e)
        {
            cbbSupplier.DataSource = _supp.GetAllSuppliers();
            cbbSupplier.DisplayMember = "Name";
            cbbSupplier.ValueMember = "ID";

            cboWarehouse.DataSource = _ware.GetAllWarehouse();
            cboWarehouse.DisplayMember = "Name";
            cboWarehouse.ValueMember = "ID";

            cboPartName.DataSource = _part.GetAllPart();
            cboPartName.DisplayMember = "Name";
            cboPartName.ValueMember = "BatchNumberHasRequired";

            if (cboPartName.SelectedValue.ToString().Equals("False"))
            {
                txtBatchNumber.Enabled = false;
            }
            else
            {
                txtBatchNumber.Enabled = true;
            }
        }

        private void cboPartName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPartName.SelectedValue.ToString().Equals("False"))
            {
                txtBatchNumber.Enabled = false;
            }
            else
            {
                txtBatchNumber.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

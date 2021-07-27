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
    public partial class frmInventoryManagement : Form
    {
        private PartsBUS _part = new PartsBUS();
        public long orderID;
        public frmInventoryManagement()
        {
            InitializeComponent();
        }

        private void frmInventoryManagement_Load(object sender, EventArgs e)
        {
            dgvPurchaseOrderManagement.AutoGenerateColumns = false;
            dgvPurchaseOrderManagement.DataSource = _part.GetAllActivities();
        }

        private void dgvPurchaseOrderManagement_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dgvPurchaseOrderManagement.Rows)
            {
                if(row.Cells[5].Value == null)
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                }
            }
        }

        private void purchaseOrderManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchaseOrderManagement fPurchaseOrder = new frmPurchaseOrderManagement();
            this.Hide();
            fPurchaseOrder.ShowDialog();
            this.Show();
        }

        private void warehouseManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orderID = 0;
            frmWarehouseManagement fWarehouseManagement = new frmWarehouseManagement();
            this.Hide();
            fWarehouseManagement.ShowDialog();
            this.Show();
        }

        private void inventoryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventoryReport fInventoryReport = new frmInventoryReport();
            this.Hide();
            fInventoryReport.ShowDialog();
            this.Show();
        }
    }   
}

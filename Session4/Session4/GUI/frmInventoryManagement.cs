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
        public frmInventoryManagement()
        {
            InitializeComponent();
        }

        private void frmInventoryManagement_Load(object sender, EventArgs e)
        {
            dgvPurchaseOrderManagement.AutoGenerateColumns = false;
            dgvPurchaseOrderManagement.DataSource = _part.GetAllActivities();
        }


        private void purchaseOrderManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

    }
}

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
    public partial class frmInventoryManagement : Form
    {
        public frmInventoryManagement()
        {
            InitializeComponent();
        }

        private void frmInventoryManagement_Load(object sender, EventArgs e)
        {

        }

        private void tsmiWarehouseManagement_Click(object sender, EventArgs e)
        {
            frmWarehouseManagement fWarehouseManagement = new frmWarehouseManagement();
            fWarehouseManagement.ShowDialog();
        }

        private void tsmiInventoryReport_Click(object sender, EventArgs e)
        {
            frmInventoryReport fInventoryReport = new frmInventoryReport();
            fInventoryReport.Show();
        }
    }
}
